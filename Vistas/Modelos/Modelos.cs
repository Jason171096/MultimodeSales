﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using MultimodeSales.Programacion;
using MultimodeSales.Programacion.Modelo;
using MultimodeSales.Vistas.Modelos;

namespace MultimodeSales.Vistas
{
    public partial class Modeloss : Form
    {
        ModelosDB modelos = new ModelosDB();
        CDataGridView cDataGrid = new CDataGridView();
        DataTable dt = new DataTable();
        DataTable Data = new DataTable();
        private int MX;
        private int MY;
        private int count = 0, opcion = 1;
        private bool stop = false, datePickerChangeValue = false;

        public Modeloss()
        {
            InitializeComponent();
            cDataGrid.FormattingDataGridView(dgvModelos);
            rbtnNumPedido.Checked = true;
            rbtnNumPedido.CheckedChanged += new EventHandler(radioButtonBuscar_CheckedChanged);
            rbtnFecha.CheckedChanged += new EventHandler(radioButtonBuscar_CheckedChanged);
            dtpFecha.MinDate = DateTime.Parse("01/01/2020");
            dtpFecha.MaxDate = DateTime.Now;
            Data.Columns.Add("IDModelo");
            Data.Columns.Add("IDMarca");
            Data.Columns.Add("Nombre");
            Data.Columns.Add("Color");
            Data.Columns.Add("Talla");
            Data.Columns.Add("PrecioCliente");
            Data.Columns.Add("Fecha");
            CargarModelos();
        }
        private void radioButtonBuscar_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked && rb.TabIndex == 10)
            {//RadioButtonBuscar
                dtpFecha.Value = dtpFecha.MaxDate;
                dtpFecha.Enabled = false;
                txtBuscarModelo.Enabled = true;
                opcion = 1;
                //CargarModelos();
            }
            else if (rb.Checked && rb.TabIndex == 12)
            {//RadioButtonFecha
                txtBuscarModelo.Text = "";
                txtBuscarModelo.Enabled = false;
                dtpFecha.Enabled = true;
                opcion = 2;
                //CargarModelos();
            }
        }
        private void CargarModelos()
        {
            dt = modelos.ObtenerModelos(count, opcion, txtBuscarModelo.Text, dtpFecha.Value);
            AsignarTable();
            dgvModelos.DataSource = Data;
            DarFormatoTabla();
        }
        private void DarFormatoTabla()
        {
            dgvModelos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvModelos.Columns[1].Visible = false;//IDMarca
            dgvModelos.Columns[0].Width = 200;//IDModelo
            dgvModelos.Columns[0].HeaderText = "ID Modelo";//IDModelo
            dgvModelos.Columns[2].Width = 200;//NombreMarca
            dgvModelos.Columns[2].HeaderText = "Nombre Marca";//NombreMarca
            dgvModelos.Columns[3].Width = 200;//Color
            dgvModelos.Columns[4].Width = 200;//Talla
            dgvModelos.Columns[5].Width = 200;//PrecioCliente
            dgvModelos.Columns[5].HeaderText = "Precio Cliente";//PrecioCliente
            dgvModelos.Columns[6].Width = 350;//Fecha
            
        }
        private void btnAgregarModelo_Click(object sender, EventArgs e)
        {
            new EditModelo(true, "", "", "", "", "").ShowDialog();
            BorrarTable();
            CargarModelos();
        }
        private void btnEditarModelo_Click(object sender, EventArgs e)
        {
            string idmodelo = dgvModelos.CurrentRow.Cells[0].Value + "";
            string idmarca = dgvModelos.CurrentRow.Cells[1].Value + "";
            string color = dgvModelos.CurrentRow.Cells[3].Value + "";
            string talla = dgvModelos.CurrentRow.Cells[4].Value + "";
            string precioCliente = dgvModelos.CurrentRow.Cells[5].Value + "";
                 
            new EditModelo(false, idmodelo, idmarca, color, talla, precioCliente).ShowDialog();
            BorrarTable();
            CargarModelos();
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            count = 0;
            BorrarTable();
            CargarModelos();
        }
        private void dgvModelos_Scroll(object sender, ScrollEventArgs e)
        {
            if (dgvModelos.DisplayedRowCount(false) + dgvModelos.FirstDisplayedScrollingRowIndex >= dgvModelos.Rows.Count && stop == false)
            {   
                count += 100;
                stop = true;
                CargarModelos();
            }
            else
                stop = false;
        }
        private void AsignarTable()
        {
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow rows in dt.Rows)
                {
                    Data.ImportRow(rows);
                }
            }
        }
        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            if (datePickerChangeValue)
            {
                BorrarTable();
                CargarModelos();
            }
            datePickerChangeValue = true;
        }
        private void BorrarTable()
        {
            dgvModelos.DataSource = null;
            Data.Clear();
        }
        #region Panel Barras
        private void panelBarras_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }

        private void lbModelos_MouseMove(object sender, MouseEventArgs e)
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