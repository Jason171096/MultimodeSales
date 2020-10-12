﻿namespace MultimodeSales.Vistas
{
    partial class Pedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBarras = new System.Windows.Forms.Panel();
            this.lbPedido = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.btnAgregarModelo = new System.Windows.Forms.Button();
            this.btnAgregarColorTalla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboxCliente = new System.Windows.Forms.ComboBox();
            this.IDModelo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IDColor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IDTalla = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panelBarras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarras
            // 
            this.panelBarras.BackColor = System.Drawing.Color.Purple;
            this.panelBarras.BackgroundImage = global::MultimodeSales.Properties.Resources.background5;
            this.panelBarras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBarras.Controls.Add(this.lbPedido);
            this.panelBarras.Controls.Add(this.picClose);
            this.panelBarras.Controls.Add(this.picMinimize);
            this.panelBarras.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarras.Location = new System.Drawing.Point(0, 0);
            this.panelBarras.Name = "panelBarras";
            this.panelBarras.Size = new System.Drawing.Size(955, 46);
            this.panelBarras.TabIndex = 31;
            this.panelBarras.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarras_MouseMove);
            // 
            // lbPedido
            // 
            this.lbPedido.AutoSize = true;
            this.lbPedido.BackColor = System.Drawing.Color.Transparent;
            this.lbPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPedido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbPedido.Location = new System.Drawing.Point(6, 9);
            this.lbPedido.Name = "lbPedido";
            this.lbPedido.Size = new System.Drawing.Size(91, 29);
            this.lbPedido.TabIndex = 36;
            this.lbPedido.Text = "Pedido";
            this.lbPedido.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbPedido_MouseMove);
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::MultimodeSales.Properties.Resources.close48;
            this.picClose.Location = new System.Drawing.Point(895, 0);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(48, 48);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picClose.TabIndex = 24;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picMinimize
            // 
            this.picMinimize.BackColor = System.Drawing.Color.Transparent;
            this.picMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimize.Image = global::MultimodeSales.Properties.Resources.minimize48px;
            this.picMinimize.Location = new System.Drawing.Point(845, 0);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(48, 48);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMinimize.TabIndex = 23;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // dgvPedido
            // 
            this.dgvPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPedido.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvPedido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvPedido.ColumnHeadersHeight = 50;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDModelo,
            this.IDColor,
            this.IDTalla});
            this.dgvPedido.EnableHeadersVisualStyles = false;
            this.dgvPedido.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvPedido.Location = new System.Drawing.Point(12, 247);
            this.dgvPedido.Name = "dgvPedido";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvPedido.RowHeadersVisible = false;
            this.dgvPedido.RowHeadersWidth = 30;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.dgvPedido.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvPedido.RowTemplate.Height = 30;
            this.dgvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPedido.Size = new System.Drawing.Size(931, 314);
            this.dgvPedido.TabIndex = 32;
            // 
            // btnAgregarModelo
            // 
            this.btnAgregarModelo.BackColor = System.Drawing.Color.SlateBlue;
            this.btnAgregarModelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarModelo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgregarModelo.Location = new System.Drawing.Point(783, 115);
            this.btnAgregarModelo.Name = "btnAgregarModelo";
            this.btnAgregarModelo.Size = new System.Drawing.Size(160, 60);
            this.btnAgregarModelo.TabIndex = 33;
            this.btnAgregarModelo.Text = "Agregar Modelo";
            this.btnAgregarModelo.UseVisualStyleBackColor = false;
            this.btnAgregarModelo.Click += new System.EventHandler(this.btnAgregarModelo_Click);
            // 
            // btnAgregarColorTalla
            // 
            this.btnAgregarColorTalla.BackColor = System.Drawing.Color.SlateBlue;
            this.btnAgregarColorTalla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarColorTalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnAgregarColorTalla.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgregarColorTalla.Location = new System.Drawing.Point(783, 181);
            this.btnAgregarColorTalla.Name = "btnAgregarColorTalla";
            this.btnAgregarColorTalla.Size = new System.Drawing.Size(160, 60);
            this.btnAgregarColorTalla.TabIndex = 34;
            this.btnAgregarColorTalla.Text = "Agregar Color o Talla";
            this.btnAgregarColorTalla.UseVisualStyleBackColor = false;
            this.btnAgregarColorTalla.Click += new System.EventHandler(this.btnAgregarColorTalla_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 29);
            this.label4.TabIndex = 41;
            this.label4.Text = "Cliente:";
            // 
            // btnTerminar
            // 
            this.btnTerminar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnTerminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTerminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnTerminar.Location = new System.Drawing.Point(753, 575);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(190, 45);
            this.btnTerminar.TabIndex = 42;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = false;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Indigo;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelar.Location = new System.Drawing.Point(12, 575);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(190, 45);
            this.btnCancelar.TabIndex = 52;
            this.btnCancelar.Text = "Cancelar(Esc)";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboxCliente
            // 
            this.cboxCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cboxCliente.FormattingEnabled = true;
            this.cboxCliente.Location = new System.Drawing.Point(113, 192);
            this.cboxCliente.Name = "cboxCliente";
            this.cboxCliente.Size = new System.Drawing.Size(513, 37);
            this.cboxCliente.TabIndex = 53;
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
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(955, 632);
            this.Controls.Add(this.cboxCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAgregarColorTalla);
            this.Controls.Add(this.btnAgregarModelo);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.panelBarras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.panelBarras.ResumeLayout(false);
            this.panelBarras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBarras;
        private System.Windows.Forms.Label lbPedido;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Button btnAgregarModelo;
        private System.Windows.Forms.Button btnAgregarColorTalla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboxCliente;
        private System.Windows.Forms.DataGridViewComboBoxColumn IDModelo;
        private System.Windows.Forms.DataGridViewComboBoxColumn IDColor;
        private System.Windows.Forms.DataGridViewComboBoxColumn IDTalla;
    }
}