using MultimodeSales.Programacion.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private string modelo = "MODELO";
        private string idusuario = "USUARIO";
        private bool successfulExecute;

        private void btnCargar_Click(object sender, EventArgs e)
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
                dgvExcel2.Columns[0].Width = 120;
                dgvExcel2.Columns[1].Width = 300;
                con.Close();
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            ExcelDB excelDB = new ExcelDB();
            foreach (DataGridViewRow row in dgvExcel.Rows)
            {
                successfulExecute = excelDB.AgregarPedidosFinal(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
                if (!successfulExecute)
                    MessageBox.Show($"Error en subir el modelo {row.Cells[0].Value} ya existe en la BASE de DATOS", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (successfulExecute)
                MessageBox.Show($"Importacion exitosa", "¡EXITO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
