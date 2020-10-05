namespace MultimodeSales
{
    partial class Formulario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbHora = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.panelCliente = new System.Windows.Forms.Panel();
            this.panelImportExcel = new System.Windows.Forms.Panel();
            this.lbCliente = new System.Windows.Forms.Label();
            this.lbImportExcel = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.panelMarca = new System.Windows.Forms.Panel();
            this.lbPedidosFinal = new System.Windows.Forms.Label();
            this.panelPedidosFinal = new System.Windows.Forms.Panel();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.lbModelos = new System.Windows.Forms.Label();
            this.panelModelos = new System.Windows.Forms.Panel();
            this.picModelos = new System.Windows.Forms.PictureBox();
            this.picBuscar = new System.Windows.Forms.PictureBox();
            this.picPedidosFinal = new System.Windows.Forms.PictureBox();
            this.picMarca = new System.Windows.Forms.PictureBox();
            this.picImportExcel = new System.Windows.Forms.PictureBox();
            this.picCliente = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picModelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPedidosFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImportExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.MediumPurple;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 596);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Purple;
            this.panel2.Controls.Add(this.lbHora);
            this.panel2.Controls.Add(this.lbFecha);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(171, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1094, 37);
            this.panel2.TabIndex = 2;
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbHora.Location = new System.Drawing.Point(902, 9);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(63, 20);
            this.lbHora.TabIndex = 1;
            this.lbHora.Text = "tiempo";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbFecha.Location = new System.Drawing.Point(6, 9);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(63, 20);
            this.lbFecha.TabIndex = 0;
            this.lbFecha.Text = "tiempo";
            // 
            // panelCliente
            // 
            this.panelCliente.BackColor = System.Drawing.Color.Purple;
            this.panelCliente.Location = new System.Drawing.Point(416, 210);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Size = new System.Drawing.Size(171, 10);
            this.panelCliente.TabIndex = 3;
            // 
            // panelImportExcel
            // 
            this.panelImportExcel.BackColor = System.Drawing.Color.Purple;
            this.panelImportExcel.Location = new System.Drawing.Point(203, 210);
            this.panelImportExcel.Name = "panelImportExcel";
            this.panelImportExcel.Size = new System.Drawing.Size(171, 10);
            this.panelImportExcel.TabIndex = 4;
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCliente.Location = new System.Drawing.Point(464, 223);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(75, 24);
            this.lbCliente.TabIndex = 7;
            this.lbCliente.Text = "Cliente";
            // 
            // lbImportExcel
            // 
            this.lbImportExcel.AutoSize = true;
            this.lbImportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImportExcel.Location = new System.Drawing.Point(217, 223);
            this.lbImportExcel.Name = "lbImportExcel";
            this.lbImportExcel.Size = new System.Drawing.Size(145, 24);
            this.lbImportExcel.TabIndex = 8;
            this.lbImportExcel.Text = "Importar Excel";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarca.Location = new System.Drawing.Point(690, 223);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(67, 24);
            this.lbMarca.TabIndex = 11;
            this.lbMarca.Text = "Marca";
            // 
            // panelMarca
            // 
            this.panelMarca.BackColor = System.Drawing.Color.Purple;
            this.panelMarca.Location = new System.Drawing.Point(636, 210);
            this.panelMarca.Name = "panelMarca";
            this.panelMarca.Size = new System.Drawing.Size(171, 10);
            this.panelMarca.TabIndex = 9;
            // 
            // lbPedidosFinal
            // 
            this.lbPedidosFinal.AutoSize = true;
            this.lbPedidosFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPedidosFinal.Location = new System.Drawing.Point(1091, 223);
            this.lbPedidosFinal.Name = "lbPedidosFinal";
            this.lbPedidosFinal.Size = new System.Drawing.Size(138, 24);
            this.lbPedidosFinal.TabIndex = 14;
            this.lbPedidosFinal.Text = "Pedidos Final";
            // 
            // panelPedidosFinal
            // 
            this.panelPedidosFinal.BackColor = System.Drawing.Color.Purple;
            this.panelPedidosFinal.Location = new System.Drawing.Point(1077, 210);
            this.panelPedidosFinal.Name = "panelPedidosFinal";
            this.panelPedidosFinal.Size = new System.Drawing.Size(171, 10);
            this.panelPedidosFinal.TabIndex = 12;
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscar.Location = new System.Drawing.Point(251, 466);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(74, 24);
            this.lbBuscar.TabIndex = 17;
            this.lbBuscar.Text = "Buscar";
            // 
            // panelBuscar
            // 
            this.panelBuscar.BackColor = System.Drawing.Color.Purple;
            this.panelBuscar.Location = new System.Drawing.Point(205, 453);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(171, 10);
            this.panelBuscar.TabIndex = 15;
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // lbModelos
            // 
            this.lbModelos.AutoSize = true;
            this.lbModelos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModelos.Location = new System.Drawing.Point(904, 223);
            this.lbModelos.Name = "lbModelos";
            this.lbModelos.Size = new System.Drawing.Size(90, 24);
            this.lbModelos.TabIndex = 20;
            this.lbModelos.Text = "Modelos";
            // 
            // panelModelos
            // 
            this.panelModelos.BackColor = System.Drawing.Color.Purple;
            this.panelModelos.Location = new System.Drawing.Point(862, 210);
            this.panelModelos.Name = "panelModelos";
            this.panelModelos.Size = new System.Drawing.Size(171, 10);
            this.panelModelos.TabIndex = 18;
            // 
            // picModelos
            // 
            this.picModelos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picModelos.Image = global::MultimodeSales.Properties.Resources.shoes128px;
            this.picModelos.Location = new System.Drawing.Point(864, 59);
            this.picModelos.Name = "picModelos";
            this.picModelos.Size = new System.Drawing.Size(169, 161);
            this.picModelos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picModelos.TabIndex = 19;
            this.picModelos.TabStop = false;
            this.picModelos.Click += new System.EventHandler(this.picModelos_Click);
            this.picModelos.MouseEnter += new System.EventHandler(this.picModelos_MouseEnter);
            this.picModelos.MouseLeave += new System.EventHandler(this.picModelos_MouseLeave);
            // 
            // picBuscar
            // 
            this.picBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBuscar.Image = global::MultimodeSales.Properties.Resources.search128px;
            this.picBuscar.Location = new System.Drawing.Point(205, 302);
            this.picBuscar.Name = "picBuscar";
            this.picBuscar.Size = new System.Drawing.Size(169, 161);
            this.picBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBuscar.TabIndex = 16;
            this.picBuscar.TabStop = false;
            this.picBuscar.Click += new System.EventHandler(this.picBuscar_Click);
            this.picBuscar.MouseEnter += new System.EventHandler(this.picBuscar_MouseEnter);
            this.picBuscar.MouseLeave += new System.EventHandler(this.picBuscar_MouseLeave);
            // 
            // picPedidosFinal
            // 
            this.picPedidosFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPedidosFinal.Image = global::MultimodeSales.Properties.Resources.request128px;
            this.picPedidosFinal.Location = new System.Drawing.Point(1077, 59);
            this.picPedidosFinal.Name = "picPedidosFinal";
            this.picPedidosFinal.Size = new System.Drawing.Size(169, 161);
            this.picPedidosFinal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPedidosFinal.TabIndex = 13;
            this.picPedidosFinal.TabStop = false;
            this.picPedidosFinal.Click += new System.EventHandler(this.picPedidosFinal_Click);
            this.picPedidosFinal.MouseEnter += new System.EventHandler(this.picPedidosFinal_MouseEnter);
            this.picPedidosFinal.MouseLeave += new System.EventHandler(this.picPedidosFinal_MouseLeave);
            // 
            // picMarca
            // 
            this.picMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMarca.Image = global::MultimodeSales.Properties.Resources.catalog128px;
            this.picMarca.Location = new System.Drawing.Point(636, 59);
            this.picMarca.Name = "picMarca";
            this.picMarca.Size = new System.Drawing.Size(169, 161);
            this.picMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picMarca.TabIndex = 10;
            this.picMarca.TabStop = false;
            this.picMarca.Click += new System.EventHandler(this.picMarca_Click);
            this.picMarca.MouseEnter += new System.EventHandler(this.picMarca_MouseEnter);
            this.picMarca.MouseLeave += new System.EventHandler(this.picMarca_MouseLeave);
            // 
            // picImportExcel
            // 
            this.picImportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picImportExcel.Image = global::MultimodeSales.Properties.Resources.csv128px;
            this.picImportExcel.Location = new System.Drawing.Point(203, 59);
            this.picImportExcel.Name = "picImportExcel";
            this.picImportExcel.Size = new System.Drawing.Size(169, 161);
            this.picImportExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picImportExcel.TabIndex = 6;
            this.picImportExcel.TabStop = false;
            this.picImportExcel.Click += new System.EventHandler(this.picImportExcel_Click);
            this.picImportExcel.MouseEnter += new System.EventHandler(this.picImportExcel_MouseEnter);
            this.picImportExcel.MouseLeave += new System.EventHandler(this.picImportExcel_MouseLeave);
            // 
            // picCliente
            // 
            this.picCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCliente.Image = global::MultimodeSales.Properties.Resources.client128px;
            this.picCliente.Location = new System.Drawing.Point(416, 59);
            this.picCliente.Name = "picCliente";
            this.picCliente.Size = new System.Drawing.Size(171, 161);
            this.picCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCliente.TabIndex = 4;
            this.picCliente.TabStop = false;
            this.picCliente.Click += new System.EventHandler(this.picCliente_Click);
            this.picCliente.MouseEnter += new System.EventHandler(this.picCliente_MouseEnter);
            this.picCliente.MouseLeave += new System.EventHandler(this.picCliente_MouseLeave);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1265, 596);
            this.Controls.Add(this.lbModelos);
            this.Controls.Add(this.panelModelos);
            this.Controls.Add(this.picModelos);
            this.Controls.Add(this.lbBuscar);
            this.Controls.Add(this.panelBuscar);
            this.Controls.Add(this.picBuscar);
            this.Controls.Add(this.lbPedidosFinal);
            this.Controls.Add(this.panelPedidosFinal);
            this.Controls.Add(this.picPedidosFinal);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.panelMarca);
            this.Controls.Add(this.picMarca);
            this.Controls.Add(this.lbImportExcel);
            this.Controls.Add(this.lbCliente);
            this.Controls.Add(this.panelImportExcel);
            this.Controls.Add(this.picImportExcel);
            this.Controls.Add(this.panelCliente);
            this.Controls.Add(this.picCliente);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picModelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPedidosFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImportExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelCliente;
        private System.Windows.Forms.PictureBox picCliente;
        private System.Windows.Forms.PictureBox picImportExcel;
        private System.Windows.Forms.Panel panelImportExcel;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Label lbImportExcel;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Panel panelMarca;
        private System.Windows.Forms.PictureBox picMarca;
        private System.Windows.Forms.Label lbPedidosFinal;
        private System.Windows.Forms.Panel panelPedidosFinal;
        private System.Windows.Forms.PictureBox picPedidosFinal;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.PictureBox picBuscar;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label lbModelos;
        private System.Windows.Forms.Panel panelModelos;
        private System.Windows.Forms.PictureBox picModelos;
    }
}

