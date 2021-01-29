﻿
namespace MultimodeSales.Vistas
{
    partial class Devolucion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBarras = new System.Windows.Forms.Panel();
            this.lbDevolucion = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDMarca = new System.Windows.Forms.TextBox();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.mtDivider = new MaterialSkin.Controls.MaterialDivider();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxCliente = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.checkCambioModelo = new MaterialSkin.Controls.MaterialCheckBox();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.IDPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDModelo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IDMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDColor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IDTalla = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.gBoxCambiar = new System.Windows.Forms.GroupBox();
            this.roundButton1 = new RoundButton.RoundButton();
            this.gBoxCambio = new System.Windows.Forms.GroupBox();
            this.roundButton2 = new RoundButton.RoundButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.rbtnAceptar = new RoundButton.RoundButton();
            this.rbtnCancelar = new RoundButton.RoundButton();
            this.rbtnBuscarFolio = new RoundButton.RoundButton();
            this.panelBarras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.gBoxCambiar.SuspendLayout();
            this.gBoxCambio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarras
            // 
            this.panelBarras.BackColor = System.Drawing.Color.Transparent;
            this.panelBarras.BackgroundImage = global::MultimodeSales.Properties.Resources.background5;
            this.panelBarras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBarras.Controls.Add(this.lbDevolucion);
            this.panelBarras.Controls.Add(this.picClose);
            this.panelBarras.Controls.Add(this.picMinimize);
            this.panelBarras.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarras.Location = new System.Drawing.Point(0, 0);
            this.panelBarras.Name = "panelBarras";
            this.panelBarras.Size = new System.Drawing.Size(880, 49);
            this.panelBarras.TabIndex = 19;
            this.panelBarras.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarras_MouseMove);
            // 
            // lbDevolucion
            // 
            this.lbDevolucion.AutoSize = true;
            this.lbDevolucion.BackColor = System.Drawing.Color.Transparent;
            this.lbDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDevolucion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDevolucion.Location = new System.Drawing.Point(6, 9);
            this.lbDevolucion.Name = "lbDevolucion";
            this.lbDevolucion.Size = new System.Drawing.Size(133, 29);
            this.lbDevolucion.TabIndex = 37;
            this.lbDevolucion.Text = "Devolución";
            this.lbDevolucion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbDevolucion_MouseMove);
            // 
            // picClose
            // 
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::MultimodeSales.Properties.Resources.close48;
            this.picClose.Location = new System.Drawing.Point(824, 0);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(48, 48);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picClose.TabIndex = 24;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picMinimize
            // 
            this.picMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimize.Image = global::MultimodeSales.Properties.Resources.minimize48px;
            this.picMinimize.Location = new System.Drawing.Point(773, 0);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(48, 48);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMinimize.TabIndex = 23;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(532, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Folio:";
            // 
            // txtIDMarca
            // 
            this.txtIDMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtIDMarca.Location = new System.Drawing.Point(595, 31);
            this.txtIDMarca.Name = "txtIDMarca";
            this.txtIDMarca.Size = new System.Drawing.Size(227, 29);
            this.txtIDMarca.TabIndex = 20;
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.BackColor = System.Drawing.Color.SlateBlue;
            this.btnAgregarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregarMarca.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgregarMarca.Location = new System.Drawing.Point(331, 19);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(179, 37);
            this.btnAgregarMarca.TabIndex = 22;
            this.btnAgregarMarca.Text = "Seleccionar Modelo";
            this.btnAgregarMarca.UseVisualStyleBackColor = false;
            // 
            // mtDivider
            // 
            this.mtDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mtDivider.Depth = 0;
            this.mtDivider.Location = new System.Drawing.Point(17, 407);
            this.mtDivider.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtDivider.Name = "mtDivider";
            this.mtDivider.Size = new System.Drawing.Size(850, 10);
            this.mtDivider.TabIndex = 25;
            this.mtDivider.Text = "materialDivider1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cboxCliente);
            this.groupBox2.Controls.Add(this.txtIDMarca);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox2.Location = new System.Drawing.Point(12, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(833, 81);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(10, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 41;
            this.label4.Text = "Cliente:";
            // 
            // cboxCliente
            // 
            this.cboxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cboxCliente.FormattingEnabled = true;
            this.cboxCliente.Location = new System.Drawing.Point(89, 31);
            this.cboxCliente.Name = "cboxCliente";
            this.cboxCliente.Size = new System.Drawing.Size(405, 32);
            this.cboxCliente.TabIndex = 53;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SlateBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(325, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 37);
            this.button3.TabIndex = 61;
            this.button3.Text = "Seleccionar Pedido";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // checkCambioModelo
            // 
            this.checkCambioModelo.AutoSize = true;
            this.checkCambioModelo.Depth = 0;
            this.checkCambioModelo.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkCambioModelo.Location = new System.Drawing.Point(666, 147);
            this.checkCambioModelo.Margin = new System.Windows.Forms.Padding(0);
            this.checkCambioModelo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkCambioModelo.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkCambioModelo.Name = "checkCambioModelo";
            this.checkCambioModelo.Ripple = true;
            this.checkCambioModelo.Size = new System.Drawing.Size(179, 30);
            this.checkCambioModelo.TabIndex = 62;
            this.checkCambioModelo.Text = "Cambio por otro modelo";
            this.checkCambioModelo.UseVisualStyleBackColor = true;
            this.checkCambioModelo.CheckedChanged += new System.EventHandler(this.checkCambioModelo_CheckedChanged);
            // 
            // dgvPedido
            // 
            this.dgvPedido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPedido.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvPedido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvPedido.ColumnHeadersHeight = 50;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPedido,
            this.IDModelo,
            this.IDMarca,
            this.IDColor,
            this.IDTalla,
            this.Eliminar});
            this.dgvPedido.EnableHeadersVisualStyles = false;
            this.dgvPedido.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvPedido.Location = new System.Drawing.Point(8, 62);
            this.dgvPedido.Name = "dgvPedido";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvPedido.RowHeadersVisible = false;
            this.dgvPedido.RowHeadersWidth = 30;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.dgvPedido.RowsDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvPedido.RowTemplate.Height = 30;
            this.dgvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPedido.Size = new System.Drawing.Size(850, 150);
            this.dgvPedido.TabIndex = 63;
            // 
            // IDPedido
            // 
            this.IDPedido.HeaderText = "Pedido";
            this.IDPedido.Name = "IDPedido";
            // 
            // IDModelo
            // 
            this.IDModelo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.IDModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IDModelo.HeaderText = "Modelo";
            this.IDModelo.Name = "IDModelo";
            this.IDModelo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IDModelo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // IDMarca
            // 
            this.IDMarca.HeaderText = "Marca";
            this.IDMarca.Name = "IDMarca";
            // 
            // IDColor
            // 
            this.IDColor.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.IDColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IDColor.HeaderText = "Color";
            this.IDColor.Name = "IDColor";
            this.IDColor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IDColor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // IDTalla
            // 
            this.IDTalla.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.IDTalla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IDTalla.HeaderText = "Talla";
            this.IDTalla.Name = "IDTalla";
            this.IDTalla.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IDTalla.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::MultimodeSales.Properties.Resources.basura24px;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // gBoxCambiar
            // 
            this.gBoxCambiar.Controls.Add(this.roundButton1);
            this.gBoxCambiar.Controls.Add(this.dgvPedido);
            this.gBoxCambiar.Controls.Add(this.btnAgregarMarca);
            this.gBoxCambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.gBoxCambiar.Location = new System.Drawing.Point(11, 180);
            this.gBoxCambiar.Name = "gBoxCambiar";
            this.gBoxCambiar.Size = new System.Drawing.Size(861, 221);
            this.gBoxCambiar.TabIndex = 65;
            this.gBoxCambiar.TabStop = false;
            this.gBoxCambiar.Text = "Modelos a cambiar";
            // 
            // roundButton1
            // 
            this.roundButton1.BorderColor = System.Drawing.Color.Silver;
            this.roundButton1.ButtonColor = System.Drawing.Color.Red;
            this.roundButton1.Location = new System.Drawing.Point(233, 19);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.roundButton1.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.roundButton1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.roundButton1.Size = new System.Drawing.Size(187, 37);
            this.roundButton1.TabIndex = 64;
            this.roundButton1.Text = "Seleccionar pedido";
            this.roundButton1.TextColor = System.Drawing.Color.White;
            this.roundButton1.UseVisualStyleBackColor = true;
            // 
            // gBoxCambio
            // 
            this.gBoxCambio.Controls.Add(this.roundButton2);
            this.gBoxCambio.Controls.Add(this.dataGridView1);
            this.gBoxCambio.Controls.Add(this.button3);
            this.gBoxCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.gBoxCambio.Location = new System.Drawing.Point(11, 423);
            this.gBoxCambio.Name = "gBoxCambio";
            this.gBoxCambio.Size = new System.Drawing.Size(861, 221);
            this.gBoxCambio.TabIndex = 66;
            this.gBoxCambio.TabStop = false;
            this.gBoxCambio.Text = "Modelo por cambio";
            // 
            // roundButton2
            // 
            this.roundButton2.BorderColor = System.Drawing.Color.Silver;
            this.roundButton2.ButtonColor = System.Drawing.Color.Red;
            this.roundButton2.Location = new System.Drawing.Point(233, 19);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.roundButton2.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.roundButton2.OnHoverTextColor = System.Drawing.Color.Gray;
            this.roundButton2.Size = new System.Drawing.Size(187, 37);
            this.roundButton2.TabIndex = 65;
            this.roundButton2.Text = "Seleccionar pedido";
            this.roundButton2.TextColor = System.Drawing.Color.White;
            this.roundButton2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewComboBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewComboBoxColumn2,
            this.dataGridViewComboBoxColumn3,
            this.dataGridViewImageColumn1});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGridView1.Location = new System.Drawing.Point(5, 62);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 30;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(850, 150);
            this.dataGridView1.TabIndex = 64;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Pedido";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewComboBoxColumn1.HeaderText = "Modelo";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewComboBoxColumn2.HeaderText = "Color";
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewComboBoxColumn3
            // 
            this.dataGridViewComboBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewComboBoxColumn3.HeaderText = "Talla";
            this.dataGridViewComboBoxColumn3.Name = "dataGridViewComboBoxColumn3";
            this.dataGridViewComboBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Eliminar";
            this.dataGridViewImageColumn1.Image = global::MultimodeSales.Properties.Resources.basura24px;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // rbtnAceptar
            // 
            this.rbtnAceptar.BorderColor = System.Drawing.Color.Silver;
            this.rbtnAceptar.ButtonColor = System.Drawing.Color.Red;
            this.rbtnAceptar.Location = new System.Drawing.Point(732, 650);
            this.rbtnAceptar.Name = "rbtnAceptar";
            this.rbtnAceptar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnAceptar.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnAceptar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnAceptar.Size = new System.Drawing.Size(140, 40);
            this.rbtnAceptar.TabIndex = 67;
            this.rbtnAceptar.Text = "Aceptar";
            this.rbtnAceptar.TextColor = System.Drawing.Color.White;
            this.rbtnAceptar.UseVisualStyleBackColor = true;
            // 
            // rbtnCancelar
            // 
            this.rbtnCancelar.BorderColor = System.Drawing.Color.Silver;
            this.rbtnCancelar.ButtonColor = System.Drawing.Color.Red;
            this.rbtnCancelar.Location = new System.Drawing.Point(11, 650);
            this.rbtnCancelar.Name = "rbtnCancelar";
            this.rbtnCancelar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnCancelar.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnCancelar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnCancelar.Size = new System.Drawing.Size(140, 40);
            this.rbtnCancelar.TabIndex = 68;
            this.rbtnCancelar.Text = "Cancelar(Esc)";
            this.rbtnCancelar.TextColor = System.Drawing.Color.White;
            this.rbtnCancelar.UseVisualStyleBackColor = true;
            // 
            // rbtnBuscarFolio
            // 
            this.rbtnBuscarFolio.BorderColor = System.Drawing.Color.Silver;
            this.rbtnBuscarFolio.ButtonColor = System.Drawing.Color.Red;
            this.rbtnBuscarFolio.Location = new System.Drawing.Point(502, 142);
            this.rbtnBuscarFolio.Name = "rbtnBuscarFolio";
            this.rbtnBuscarFolio.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnBuscarFolio.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnBuscarFolio.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnBuscarFolio.Size = new System.Drawing.Size(148, 37);
            this.rbtnBuscarFolio.TabIndex = 65;
            this.rbtnBuscarFolio.Text = "Buscar Folio";
            this.rbtnBuscarFolio.TextColor = System.Drawing.Color.White;
            this.rbtnBuscarFolio.UseVisualStyleBackColor = true;
            // 
            // Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(880, 695);
            this.Controls.Add(this.rbtnBuscarFolio);
            this.Controls.Add(this.rbtnCancelar);
            this.Controls.Add(this.rbtnAceptar);
            this.Controls.Add(this.gBoxCambio);
            this.Controls.Add(this.gBoxCambiar);
            this.Controls.Add(this.checkCambioModelo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.mtDivider);
            this.Controls.Add(this.panelBarras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Devolucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolucion";
            this.panelBarras.ResumeLayout(false);
            this.panelBarras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.gBoxCambiar.ResumeLayout(false);
            this.gBoxCambio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBarras;
        private System.Windows.Forms.Label lbDevolucion;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDMarca;
        private System.Windows.Forms.Button btnAgregarMarca;
        private MaterialSkin.Controls.MaterialDivider mtDivider;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxCliente;
        private System.Windows.Forms.Button button3;
        private MaterialSkin.Controls.MaterialCheckBox checkCambioModelo;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPedido;
        private System.Windows.Forms.DataGridViewComboBoxColumn IDModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMarca;
        private System.Windows.Forms.DataGridViewComboBoxColumn IDColor;
        private System.Windows.Forms.DataGridViewComboBoxColumn IDTalla;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.GroupBox gBoxCambiar;
        private System.Windows.Forms.GroupBox gBoxCambio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private RoundButton.RoundButton roundButton1;
        private RoundButton.RoundButton roundButton2;
        private RoundButton.RoundButton rbtnAceptar;
        private RoundButton.RoundButton rbtnCancelar;
        private RoundButton.RoundButton rbtnBuscarFolio;
    }
}