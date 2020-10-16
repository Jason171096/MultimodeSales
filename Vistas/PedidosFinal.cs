﻿using System;
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

        public PedidosFinal()
        {
            InitializeComponent();
            CDataGrid.FormattingDataGridView(dgvPedidosFinal);
            rbtnNumPedido.CheckedChanged += new EventHandler(radioButtonBuscar_CheckedChanged);
            rbtnFecha.CheckedChanged += new EventHandler(radioButtonBuscar_CheckedChanged);
            CargarLista();
            dgvPedidosFinal.Columns[0].Visible = false;
        }

        private void radioButtonBuscar_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if(rb.Checked && rb.TabIndex == 10)
            {
                dateTimePicker1.Enabled = false;
                Buscar = 1;
            }
            else if(rb.Checked && rb.TabIndex == 12)
            {
                dateTimePicker1.Enabled = true;
                Buscar = 2;
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
            DataTable dt;
            dt = listaPedidosFinal.ObtenerListaPedidosFinal();
            dgvPedidosFinal.DataSource = dt;
            DarFormatoTabla();
        }

        private void DarFormatoTabla()
        {
            dgvPedidosFinal.Columns[0].Width = 100;
            dgvPedidosFinal.Columns[1].Width = 200;
            dgvPedidosFinal.Columns[2].Width = 200;
            dgvPedidosFinal.Columns[3].Width = 200;
            dgvPedidosFinal.Columns[4].Width = 300;
            dgvPedidosFinal.Columns[5].Width = 200;
        }

        private void dgvPedidosFinal_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl tb = (DataGridViewTextBoxEditingControl)e.Control;
            tb.KeyPress += new KeyPressEventHandler(dgvEditCell_KeyPress);
            e.Control.KeyPress += new KeyPressEventHandler(dgvEditCell_KeyPress);
        }

        private void dgvEditCell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 's')
            {
                dgvPedidosFinal.CurrentRow.DefaultCellStyle.BackColor = Color.YellowGreen;
            }
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
                    dgvPedidosFinal.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.Black;
                }
            }
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rows in dgvPedidosFinal.Rows)
            {
                if (rows.DefaultCellStyle.BackColor == Color.YellowGreen)
                    listaPedidosFinal.UpdatePedidoLlego2(rows.Cells[0].Value + "");
            }
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
