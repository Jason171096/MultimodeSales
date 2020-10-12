using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using excel = Microsoft.Office.Interop.Excel;
using MultimodeSales.Programacion.Marca;
using System.Collections.Generic;
using System.Linq;
using MultimodeSales.Programacion.Excel;
using System.Diagnostics;
using MultimodeSales.Programacion;
using MultimodeSales.Programacion.Modelo;

namespace MultimodeSales.Vistas
{
    public partial class ImportarListaMarca : Form
    {
        MarcaBD marca = new MarcaBD();
        CImportarCSVyExcel importarCSV = new CImportarCSVyExcel();
        ModelosDB modelos = new ModelosDB();
        CDataGridView cDataGrid = new CDataGridView();
        public ImportarListaMarca()
        {
            InitializeComponent();
            LlenarComboBoxMarca();
            cDataGrid.FormattingDataGridView(dgvExcel);
        }
        private string modelo = "MODELO";
        private string color = "COLOR";
        private string talla = "TALLA";
        private string claves = "CLAVES";
        private int MX;
        private int MY;

        public void LlenarComboBoxMarca()
        {
            List<object[]> list = marca.VerMarcas2();
            Dictionary<string, string> keyValues = new Dictionary<string, string>();
            keyValues.Add("-1", "--Elegir Marca--");
            foreach (object[] item in list)
            {
                keyValues.Add(item[0].ToString(), item[1].ToString());
            }
            cobxMarca.DataSource = new BindingSource(keyValues, null);
            cobxMarca.DisplayMember = "Value";
            cobxMarca.ValueMember = "Key";

        }

        private void btnCargar_Click_1(object sender, EventArgs e)
        {
            //CargarExcel();
            CargarCSV();
        }

        private void btnImportar_Click_1(object sender, EventArgs e)
        {
            string idmarca = cobxMarca.SelectedValue.ToString();
            foreach (DataGridViewRow row in dgvExcel.Rows)
            {
                modelos.AgregarModelo(row.Cells[0].Value.ToString(), idmarca, row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString());
            }
            MessageBox.Show($"Importacion exitosa", "¡EXITO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void CargarCSV()
        {
            DataTable dt;
            dgvExcel.DataSource = null;
            string openFile = importarCSV.GetFileName();
            if (!openFile.Equals(""))
            {
                dt = importarCSV.ImportarCSV(openFile);

                if (dt.Columns.Count > 4)
                {
                    for (int i = dt.Columns.Count - 1; i > 3; i--)
                    {
                        dt.Columns.RemoveAt(i);
                    }
                }
                dgvExcel.DataSource = dt;
                FormatoTabla();
            }
        }
        private void FormatoTabla()
        {
            dgvExcel.Columns[0].Width = 120;
            dgvExcel.Columns[1].Width = 300;
            dgvExcel.Columns[2].Width = 400;
            dgvExcel.Columns[3].Width = 150;
        }
        private void CargarExcel()
        {
            try
            {
                dgvExcel.DataSource = null;
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Title = "Select file";
                openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
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
                    OleDbCommand oconn = new OleDbCommand($"select {modelo}, {color}, {talla}, {claves} from [{wSheet.Name}$]", con);
                    con.Open();

                    OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
                    DataTable data = new DataTable();
                    DataTable data2 = new DataTable();
                    data2.Columns.Add(modelo);
                    data2.Columns.Add(color);
                    data2.Columns.Add(talla);
                    data2.Columns.Add(claves);
                    sda.Fill(data);
                    foreach (DataRow rows in data.Rows)
                    {
                        if (!rows.IsNull(modelo))
                        {
                            data2.Rows.Add(rows.ItemArray);
                        }
                    }
                    dgvExcel.DataSource = data2;
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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Panel Barras
        private void picMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void lbClientes_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }

        private void panelBarra_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }
        private new void MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                MX = e.X;
                MY = e.Y;
            }
            else
            {
                Left = Left + (e.X - MX);
                Top = Top + (e.Y - MY);
            }
        }
        #endregion
    }
}
