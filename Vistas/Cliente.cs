﻿using MultimodeSales.Programacion;
using MultimodeSales.Programacion.Cliente;
using MultimodeSales.Programacion.Utilerias;
using System;
using System.Data;
using System.Windows.Forms;

namespace MultimodeSales.Vistas
{
    public partial class Cliente : Form
    {
        ClienteDB cliente = new ClienteDB();
        CDataGridView CDataGrid = new CDataGridView();
        Validaciones validaciones = new Validaciones();
        DataTable dt = new DataTable();
        private int MX = 0;
        private int MY = 0;
        private int Rowindex;
        public Cliente()
        {
            InitializeComponent();
            CDataGrid.FormattingDataGridView(dgvClientes);
            LlenarDataGridViewCliente();
        }
        public void LlenarDataGridViewCliente()
        {
            dgvClientes.DataSource = null;
            dt.Clear();
            dt = cliente.VerClientes();
            dgvClientes.DataSource = dt;
            dgvClientes.Columns[0].HeaderText = "ID Cliente";
            dgvClientes.Columns[0].Width = 200;
            dgvClientes.Columns[1].Width = 650;
        }
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNombreCliente.Text) || String.IsNullOrWhiteSpace(txtIDCliente.Text))
                CMsgBox.DisplayWarning("No pueden estar los campos vacios de ID de Cliente o Nombre");
            else
            {
                int cont = 0;
                for (int i = 0; i < dgvClientes.Rows.Count; i++)
                {
                    if (txtIDCliente.Text == dgvClientes.Rows[i].Cells[0].Value.ToString())
                        cont++;
                }
                if (cont >= 1)
                    CMsgBox.DisplayWarning("No pueden existir dos ID's iguales, intente con otro ID");
                else
                {
                    cliente.AgregarCliente(txtIDCliente.Text, txtNombreCliente.Text);
                    CMsgBox.DisplayInfo("Se agrego el cliente correctamente");
                    LlenarDataGridViewCliente();
                    BorrarDatos();
                }
            }
        }
        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            int cont = 0;
            for (int i = 0; i < dgvClientes.Rows.Count; i++)
            {
                if (txtIDCliente.Text == dgvClientes.Rows[i].Cells[0].Value.ToString())
                    if (Rowindex != dgvClientes.Rows[i].Index)
                        cont++;
            }
            if (cont >= 1)
                CMsgBox.DisplayWarning("No pueden existir dos clientes con ID's iguales, intente con otro ID");
            else
            {
                btnAgregarCliente.Enabled = true;
                btnEditarCliente.Enabled = false;
                btnCancelar.Visible = false;
                cliente.EditarCliente(txtIDCliente.Tag + "", txtIDCliente.Text, txtNombreCliente.Text);
                CMsgBox.DisplayInfo("Se edito el cliente correctamente");
                BorrarDatos();
                LlenarDataGridViewCliente();
            }
        }
        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                btnAgregarCliente.Enabled = false;
                btnEditarCliente.Enabled = true;
                btnCancelar.Visible = true;
                txtIDCliente.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
                txtNombreCliente.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
                txtIDCliente.Tag = dgvClientes.CurrentRow.Cells[0].Value.ToString();
                Rowindex = e.RowIndex;
            }
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("Convert(IDCliente, 'System.String') LIKE '%{0}%' OR Nombre LIKE '%{0}%'", txtBuscar.Text);
            dgvClientes.DataSource = dv;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            BorrarDatos();
            btnAgregarCliente.Enabled = true;
            btnEditarCliente.Enabled = false;
            btnCancelar.Visible = false;
        }
        private void BorrarDatos()
        {
            txtIDCliente.Text = "";
            txtNombreCliente.Text = "";
        }
        #region Validaciones
        private void txtIDCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloNumeros(e);
        }
        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloLetrasyNumeros(sender, e);
        }
        #endregion
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

        private void panelBarras_MouseMove(object sender, MouseEventArgs e)
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
