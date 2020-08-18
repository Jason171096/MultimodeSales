using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using excel = Microsoft.Office.Interop.Excel;

namespace MultimodeSales.Vistas
{
    public partial class PedidosFinal : Form
    {
        public PedidosFinal()
        {
            InitializeComponent();
        }

        private void btnCargarExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Select file";
            openFile.InitialDirectory = @"c:\";
            openFile.Filter = "Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.Multiselect = false;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //lblRoot.Text = openFile.FileName;
                //string sheetName = System.IO.Path.GetFileNameWithoutExtension(openFile.FileName);
                Application.DoEvents();
                string constr = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={openFile.FileName};Extended Properties='Excel 12.0 XML;HDR=YES;';";

                excel.Application xlApp = new excel.Application();

                //get the workbook
                excel.Workbook excelBook = xlApp.Workbooks.Open(openFile.FileName);

                //get the first worksheet
                excel.Worksheet wSheet = excelBook.Sheets.Item[1];

                OleDbConnection con = new OleDbConnection(constr);
                OleDbCommand oconn = new OleDbCommand($"select MODELO, COLOR, TALLA, NUMEROCLIENTE from [{wSheet.Name}$]", con);
                con.Open();

                OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
                DataTable data = new DataTable();
                sda.Fill(data);
                dgvExcel.DataSource = data;
                dgvExcel.Columns[0].Width = 120;
                dgvExcel.Columns[1].Width = 300;
                dgvExcel.Columns[2].Width = 400;
                dgvExcel.Columns[3].Width = 150;
            }
        }
    }
}
