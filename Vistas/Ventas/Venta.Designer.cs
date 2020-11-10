namespace MultimodeSales.Vistas.Ventas
{
    partial class Venta
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.panelVentas = new System.Windows.Forms.Panel();
            this.lbVentas = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosFinal)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
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
            this.dgvPedidosFinal.Location = new System.Drawing.Point(11, 161);
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
            this.dgvPedidosFinal.Size = new System.Drawing.Size(943, 322);
            this.dgvPedidosFinal.TabIndex = 31;
            this.dgvPedidosFinal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPedidosFinal_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cboxCliente);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox2.Location = new System.Drawing.Point(11, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(646, 103);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clientes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 29);
            this.label4.TabIndex = 41;
            this.label4.Text = "Cliente:";
            // 
            // cboxCliente
            // 
            this.cboxCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cboxCliente.FormattingEnabled = true;
            this.cboxCliente.Location = new System.Drawing.Point(123, 40);
            this.cboxCliente.Name = "cboxCliente";
            this.cboxCliente.Size = new System.Drawing.Size(513, 37);
            this.cboxCliente.TabIndex = 53;
            this.cboxCliente.SelectedIndexChanged += new System.EventHandler(this.cboxCliente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 57;
            this.label1.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 29);
            this.label2.TabIndex = 58;
            this.label2.Text = "Cantidad:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTotal);
            this.groupBox1.Controls.Add(this.lbCantidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox1.Location = new System.Drawing.Point(12, 489);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 140);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venta";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(162, 80);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(58, 29);
            this.lbTotal.TabIndex = 60;
            this.lbTotal.Text = "$0.0";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.Location = new System.Drawing.Point(184, 41);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(26, 29);
            this.lbCantidad.TabIndex = 59;
            this.lbCantidad.Text = "0";
            // 
            // btnTerminar
            // 
            this.btnTerminar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnTerminar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTerminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTerminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnTerminar.Location = new System.Drawing.Point(766, 523);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(188, 45);
            this.btnTerminar.TabIndex = 60;
            this.btnTerminar.Text = "Vender";
            this.btnTerminar.UseVisualStyleBackColor = false;
            // 
            // panelVentas
            // 
            this.panelVentas.BackColor = System.Drawing.Color.Purple;
            this.panelVentas.BackgroundImage = global::MultimodeSales.Properties.Resources.background5;
            this.panelVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelVentas.Controls.Add(this.lbVentas);
            this.panelVentas.Controls.Add(this.picClose);
            this.panelVentas.Controls.Add(this.picMinimize);
            this.panelVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVentas.Location = new System.Drawing.Point(0, 0);
            this.panelVentas.Name = "panelVentas";
            this.panelVentas.Size = new System.Drawing.Size(966, 46);
            this.panelVentas.TabIndex = 30;
            this.panelVentas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelVentas_MouseMove);
            // 
            // lbVentas
            // 
            this.lbVentas.AutoSize = true;
            this.lbVentas.BackColor = System.Drawing.Color.Transparent;
            this.lbVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVentas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbVentas.Location = new System.Drawing.Point(6, 9);
            this.lbVentas.Name = "lbVentas";
            this.lbVentas.Size = new System.Drawing.Size(86, 29);
            this.lbVentas.TabIndex = 36;
            this.lbVentas.Text = "Ventas";
            this.lbVentas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbVentas_MouseMove);
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::MultimodeSales.Properties.Resources.close48;
            this.picClose.Location = new System.Drawing.Point(906, 0);
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
            this.picMinimize.Location = new System.Drawing.Point(856, 0);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(48, 48);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMinimize.TabIndex = 23;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(966, 654);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvPedidosFinal);
            this.Controls.Add(this.panelVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosFinal)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelVentas.ResumeLayout(false);
            this.panelVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelVentas;
        private System.Windows.Forms.Label lbVentas;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.DataGridView dgvPedidosFinal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Button btnTerminar;
    }
}