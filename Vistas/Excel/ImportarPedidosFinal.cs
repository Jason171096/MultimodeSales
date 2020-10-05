using MultimodeSales.Programacion;
using MultimodeSales.Programacion.Excel;
using System;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel;

namespace MultimodeSales.Vistas.Excel
{
    public partial class ImportarPedidosFinal : Form
    {
        public ImportarPedidosFinal()
        {
            InitializeComponent();
        }
        CImportarCSVyExcel importarCSV = new CImportarCSVyExcel();
        private string modelo = "MODELO";
        private string idusuario = "USUARIO";
        private bool successfulExecute;

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //CargarExcel();
            CargarCSV();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            ExcelDB excelDB = new ExcelDB();
            foreach (DataGridViewRow row in dgvExcel2.Rows)
            {
                successfulExecute = excelDB.AgregarPedidosFinal(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
                if (!successfulExecute)
                    MessageBox.Show($"Error en subir el modelo {row.Cells[0].Value} ya existe en la BASE de DATOS", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (successfulExecute)
                MessageBox.Show($"Importacion exitosa", "¡EXITO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CargarCSV()
        {
            DataTable dt;
            dgvExcel2.DataSource = null;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Select file";
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFile.Filter = "CSV(*.csv)|*.csv|All Files(*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.Multiselect = false;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                dt = importarCSV.ImportarCSV(openFile.FileName);

                if (dt.Columns.Count > 2)
                {
                    for (int i = dt.Columns.Count - 1; i > 1; i--)
                    {
                        dt.Columns.RemoveAt(i);
                    }
                }

                dgvExcel2.DataSource = dt;
                FormatoTabla();
            }
        }
        private void FormatoTabla()
        {
            dgvExcel2.Columns[0].Width = 300;
            dgvExcel2.Columns[1].Width = 280;
        }
        private void CargarExcel()
        {
            try
            {
                dgvExcel2.DataSource = null;
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Title = "Select file";
                openFile.InitialDirectory = @"c:\";
                openFile.Filter = "Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
                openFile.FilterIndex = 1;
                openFile.Multiselect = false;
                openFile.RestoreDirectory = true;
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    //string sheetName = System.IO.Path.GetFileNameWithoutExtension(openFile.FileName);
                    Application.DoEvents();
                    string constr = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={openFile.FileName};Extended Properties='Excel 12.0 XML;HDR=YES;';";

                    excel.Application xlApp = new excel.Application();

                    //get the workbook
                    excel.Workbook excelBook = xlApp.Workbooks.Open(openFile.FileName);

                    //get the first worksheet
                    excel.Worksheet wSheet = excelBook.Sheets.Item[1];

                    OleDbConnection con = new OleDbConnection(constr);
                    OleDbCommand oconn = new OleDbCommand($"select {modelo}, {idusuario} from [{wSheet.Name}$]", con);
                    con.Open();

                    OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
                    DataTable data = new DataTable();
                    DataTable data2 = new DataTable();
                    data2.Columns.Add(modelo);
                    data2.Columns.Add(idusuario);
                    sda.Fill(data);
                    foreach (DataRow rows in data.Rows)
                    {
                        if (!rows.IsNull(modelo))
                        {
                            data2.Rows.Add(rows.ItemArray);
                        }
                    }
                    dgvExcel2.DataSource = data2;
                    FormatoTabla();
                    con.Close();
                    foreach (var process in Process.GetProcessesByName("excel"))
                    {
                        process.Kill();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los parametros recibidos no son validos, intente de nuevo", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
    }
}
