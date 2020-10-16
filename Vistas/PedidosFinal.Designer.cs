﻿namespace MultimodeSales.Vistas
{
    partial class PedidosFinal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPedidosFinal = new System.Windows.Forms.DataGridView();
            this.txtNumeroMarca = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rbtnFecha = new System.Windows.Forms.RadioButton();
            this.rbtnNumPedido = new System.Windows.Forms.RadioButton();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.panelBarras = new System.Windows.Forms.Panel();
            this.lbPedidoFinal = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosFinal)).BeginInit();
            this.panelBarras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPedidosFinal
            // 
            this.dgvPedidosFinal.AllowUserToAddRows = false;
            this.dgvPedidosFinal.AllowUserToDeleteRows = false;
            this.dgvPedidosFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedidosFinal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPedidosFinal.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvPedidosFinal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidosFinal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedidosFinal.ColumnHeadersHeight = 50;
            this.dgvPedidosFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPedidosFinal.EnableHeadersVisualStyles = false;
            this.dgvPedidosFinal.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvPedidosFinal.Location = new System.Drawing.Point(11, 375);
            this.dgvPedidosFinal.Name = "dgvPedidosFinal";
            this.dgvPedidosFinal.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidosFinal.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPedidosFinal.RowHeadersVisible = false;
            this.dgvPedidosFinal.RowHeadersWidth = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.dgvPedidosFinal.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPedidosFinal.RowTemplate.Height = 30;
            this.dgvPedidosFinal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidosFinal.Size = new System.Drawing.Size(1247, 371);
            this.dgvPedidosFinal.TabIndex = 7;
            this.dgvPedidosFinal.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvPedidosFinal_EditingControlShowing);
            this.dgvPedidosFinal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPedidosFinal_KeyDown);
            // 
            // txtNumeroMarca
            // 
            this.txtNumeroMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroMarca.Location = new System.Drawing.Point(201, 54);
            this.txtNumeroMarca.Name = "txtNumeroMarca";
            this.txtNumeroMarca.Size = new System.Drawing.Size(268, 31);
            this.txtNumeroMarca.TabIndex = 28;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(201, 92);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(142, 26);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBuscar.Location = new System.Drawing.Point(400, 102);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(153, 36);
            this.btnBuscar.TabIndex = 26;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // rbtnFecha
            // 
            this.rbtnFecha.AutoSize = true;
            this.rbtnFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnFecha.Location = new System.Drawing.Point(20, 89);
            this.rbtnFecha.Name = "rbtnFecha";
            this.rbtnFecha.Size = new System.Drawing.Size(72, 24);
            this.rbtnFecha.TabIndex = 12;
            this.rbtnFecha.TabStop = true;
            this.rbtnFecha.Text = "Fecha";
            this.rbtnFecha.UseVisualStyleBackColor = true;
            // 
            // rbtnNumPedido
            // 
            this.rbtnNumPedido.AutoSize = true;
            this.rbtnNumPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNumPedido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnNumPedido.Location = new System.Drawing.Point(20, 59);
            this.rbtnNumPedido.Name = "rbtnNumPedido";
            this.rbtnNumPedido.Size = new System.Drawing.Size(158, 24);
            this.rbtnNumPedido.TabIndex = 10;
            this.rbtnNumPedido.TabStop = true;
            this.rbtnNumPedido.Text = "Numero de Pedido";
            this.rbtnNumPedido.UseVisualStyleBackColor = true;
            // 
            // btnTerminar
            // 
            this.btnTerminar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnTerminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTerminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnTerminar.Location = new System.Drawing.Point(945, 186);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(251, 48);
            this.btnTerminar.TabIndex = 25;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = false;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // panelBarras
            // 
            this.panelBarras.BackColor = System.Drawing.Color.Purple;
            this.panelBarras.BackgroundImage = global::MultimodeSales.Properties.Resources.background5;
            this.panelBarras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBarras.Controls.Add(this.lbPedidoFinal);
            this.panelBarras.Controls.Add(this.picClose);
            this.panelBarras.Controls.Add(this.picMinimize);
            this.panelBarras.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarras.Location = new System.Drawing.Point(0, 0);
            this.panelBarras.Name = "panelBarras";
            this.panelBarras.Size = new System.Drawing.Size(1271, 46);
            this.panelBarras.TabIndex = 32;
            this.panelBarras.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarras_MouseMove);
            // 
            // lbPedidoFinal
            // 
            this.lbPedidoFinal.AutoSize = true;
            this.lbPedidoFinal.BackColor = System.Drawing.Color.Transparent;
            this.lbPedidoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPedidoFinal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbPedidoFinal.Location = new System.Drawing.Point(6, 9);
            this.lbPedidoFinal.Name = "lbPedidoFinal";
            this.lbPedidoFinal.Size = new System.Drawing.Size(162, 29);
            this.lbPedidoFinal.TabIndex = 36;
            this.lbPedidoFinal.Text = "Pedidos Final";
            this.lbPedidoFinal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbPedidoFinal_MouseMove);
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::MultimodeSales.Properties.Resources.close48;
            this.picClose.Location = new System.Drawing.Point(1211, 0);
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
            this.picMinimize.Location = new System.Drawing.Point(1161, 0);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(48, 48);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMinimize.TabIndex = 23;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnNumPedido);
            this.groupBox1.Controls.Add(this.rbtnFecha);
            this.groupBox1.Controls.Add(this.txtNumeroMarca);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 193);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(945, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 48);
            this.button1.TabIndex = 34;
            this.button1.Text = "Terminar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // PedidosFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1271, 769);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelBarras);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.dgvPedidosFinal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "PedidosFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PedidosFinal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosFinal)).EndInit();
            this.panelBarras.ResumeLayout(false);
            this.panelBarras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidosFinal;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RadioButton rbtnFecha;
        private System.Windows.Forms.RadioButton rbtnNumPedido;
        private System.Windows.Forms.TextBox txtNumeroMarca;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Panel panelBarras;
        private System.Windows.Forms.Label lbPedidoFinal;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}