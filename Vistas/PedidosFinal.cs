﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel;
using MultimodeSales.Programacion;

namespace MultimodeSales.Vistas
{
    public partial class PedidosFinal : Form
    {
        private int Buscar;
        ListaPedidosFinal listaPedidosFinal = new ListaPedidosFinal();
        CDataGridView CDataGrid = new CDataGridView();
        private int MX;
        private int MY;
        DataTable dt;
        DataView dv;

        public PedidosFinal()
        {
            InitializeComponent();
            CDataGrid.FormattingDataGridView(dgvPedidosFinal);
            rbtnNumPedido.Checked = true;
            rbtnTodos.Checked = true;
            rbtnNumPedido.CheckedChanged += new EventHandler(radioButtonBuscar_CheckedChanged);
            rbtnFecha.CheckedChanged += new EventHandler(radioButtonBuscar_CheckedChanged);
            rbtnTodos.CheckedChanged += new EventHandler(radioButtonOrdenar_CheckedChanged);
            rbtnLlegaron.CheckedChanged += new EventHandler(radioButtonOrdenar_CheckedChanged);
            rbtnNoLlegaron.CheckedChanged += new EventHandler(radioButtonOrdenar_CheckedChanged);
        }
        private void PedidosFinal_Load(object sender, EventArgs e)
        {
            CargarLista();
            dv = new DataView(dt);
        }
        private void radioButtonBuscar_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked && rb.TabIndex == 10)
            {
                dtpFecha.Enabled = false;
                Buscar = 1;
            }
            else if (rb.Checked && rb.TabIndex == 12)
            {
                dtpFecha.Enabled = true;
                Buscar = 2;
            }
        }
        private void radioButtonOrdenar_CheckedChanged(object sender, EventArgs e)
        {
            Borrar();
            RadioButton rb = sender as RadioButton;
            if (rb.Checked && rb.TabIndex == 20)
            {//RadioButtonTodos
                CargarLista();
            }
            else if (rb.Checked && rb.TabIndex == 25)
            {//RadioButtonLlegaron
                dv.RowFilter = "Llego = 1";
                dgvPedidosFinal.DataSource = dv;
                DarFormatoTabla();
            }
            else if (rb.Checked && rb.TabIndex == 30)
            {//RadioButtonNoLlegaron
                dv.RowFilter = "Llego = 0";
                dgvPedidosFinal.DataSource = dv;
                DarFormatoTabla();
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (Buscar == 1)
            {

            }
            else if (Buscar == 2)
            {

            }
        }

        private void CargarLista()
        {
            dgvPedidosFinal.DataSource = null;
            dt = listaPedidosFinal.ObtenerListaPedidosFinal();
            dgvPedidosFinal.DataSource = dt;
            
            foreach (DataGridViewRow rows in dgvPedidosFinal.Rows)
            {
                if(rows.Cells[8].Value.ToString() == "1")
                {
                    dgvPedidosFinal.Rows[rows.Index].DefaultCellStyle.BackColor = Color.YellowGreen;
                    dgvPedidosFinal.Rows[rows.Index].DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
                }
            }
            DarFormatoTabla();
            dgvPedidosFinal.Rows[0].DefaultCellStyle.BackColor = Color.YellowGreen;
        }

        private void DarFormatoTabla()
        {
            dgvPedidosFinal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvPedidosFinal.Columns[1].Width = 115;//IDCliente
            dgvPedidosFinal.Columns[1].HeaderText = "ID Cliente";
            dgvPedidosFinal.Columns[2].Width = 300;//NombreCliente
            dgvPedidosFinal.Columns[2].HeaderText = "Nombre Cliente";
            dgvPedidosFinal.Columns[3].Width = 150;//IDModelo
            dgvPedidosFinal.Columns[3].HeaderText = "ID Modelo";
            dgvPedidosFinal.Columns[4].Width = 150;//Color
            dgvPedidosFinal.Columns[5].Width = 150;//Talla
            dgvPedidosFinal.Columns[6].Width = 170;//PrecioCliente
            dgvPedidosFinal.Columns[6].HeaderText = "Precio Cliente";
            dgvPedidosFinal.Columns[7].Width = 250;//Fecha
            dgvPedidosFinal.Columns[0].Visible = false;
            dgvPedidosFinal.Columns[8].Visible = false;
        }
        private void dgvPedidosFinal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvPedidosFinal.CurrentRow.DefaultCellStyle.BackColor == Color.YellowGreen)
                {
                    dgvPedidosFinal.CurrentRow.DefaultCellStyle.BackColor = Color.Indigo;
                    dgvPedidosFinal.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.MidnightBlue;
                }
                else
                {
                    dgvPedidosFinal.CurrentRow.DefaultCellStyle.BackColor = Color.YellowGreen;
                    dgvPedidosFinal.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
                }
            }
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rows in dgvPedidosFinal.Rows)
            {
                if (rows.DefaultCellStyle.BackColor == Color.YellowGreen)
                    listaPedidosFinal.UpdatePedidoLlego(rows.Cells[0].Value + "");
            }
        }
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            excel._Application app = new excel.Application();
            excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets[1];
            worksheet = workbook.ActiveSheet;
            worksheet.Rows.Font.Size = 14;
            try
            {
                for (int i = 0; i < dgvPedidosFinal.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dgvPedidosFinal.Columns[i].HeaderText;
                }
                for (int i = 0; i < dgvPedidosFinal.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvPedidosFinal.Columns.Count; j++)
                    {
                        if (dgvPedidosFinal.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = dgvPedidosFinal.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            worksheet.Cells[i + 2, j + 1] = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                app.Quit();
                workbook = null;
                worksheet = null;
            }
        }
        private void Borrar()
        {
            dgvPedidosFinal.DataSource = null;
        }
        #region Barra Superior
        private void panelBarras_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }

        private void lbPedidoFinal_MouseMove(object sender, MouseEventArgs e)
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

        private void picMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}


