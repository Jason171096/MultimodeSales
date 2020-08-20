using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using excel = Microsoft.Office.Interop.Excel;
using MultimodeSales.Programacion.Marca;
using System.Collections.Generic;
using System.Linq;
using MultimodeSales.Programacion.Excel;

namespace MultimodeSales.Vistas
{
    public partial class ImportarListaMarca : Form
    {
        MarcaBD marca = new MarcaBD();
        public ImportarListaMarca()
        {
            InitializeComponent();
            LlenarComboBoxMarca();
        }
        private string modelo = "MODELO";
        private string color = "COLOR";
        private string talla = "TALLA";
        private string claves = "CLAVES";
        private bool successfulExecute;

        public void LlenarComboBoxMarca()
        {
            List<object[]> list = marca.VerMarcas2();           
            Dictionary<string, string> keyValues = new Dictionary<string, string>();
            foreach (object[] item in list)
            {
                keyValues.Add(item[0].ToString(), item[1].ToString());
            }
            cobxMarca.DataSource = new BindingSource(keyValues, null);
            cobxMarca.DisplayMember = "Value";
            cobxMarca.ValueMember = "Key";
            
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            dgvExcel.DataSource = null;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Select file";
            openFile.InitialDirectory = @"c:\";
            openFile.Filter = "Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.Multiselect = false;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                lbRuta.Text = openFile.FileName;
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
                dgvExcel.Columns[0].Width = 120;
                dgvExcel.Columns[1].Width = 300;
                dgvExcel.Columns[2].Width = 400;
                dgvExcel.Columns[3].Width = 150;

                con.Close();
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            ExcelDB excelDB = new ExcelDB();
            foreach (DataGridViewRow row in dgvExcel.Rows)
            {
                successfulExecute = excelDB.AgregarListaMarca(cobxMarca.SelectedValue.ToString(), row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString());
                if (!successfulExecute)
                    MessageBox.Show($"Error en subir el modelo {row.Cells[0].Value} ya existe en la BASE de DATOS", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (successfulExecute)
                MessageBox.Show($"Importacion exitosa", "¡EXITO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
