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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelCliente = new System.Windows.Forms.Panel();
            this.panelImportExcel = new System.Windows.Forms.Panel();
            this.lbCliente = new System.Windows.Forms.Label();
            this.lbImportExcel = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.panelMarca = new System.Windows.Forms.Panel();
            this.picMarca = new System.Windows.Forms.PictureBox();
            this.picImportExcel = new System.Windows.Forms.PictureBox();
            this.picCliente = new System.Windows.Forms.PictureBox();
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
            this.panel1.Size = new System.Drawing.Size(151, 596);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Purple;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(151, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 37);
            this.panel2.TabIndex = 2;
            // 
            // panelCliente
            // 
            this.panelCliente.BackColor = System.Drawing.Color.Purple;
            this.panelCliente.Location = new System.Drawing.Point(187, 210);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Size = new System.Drawing.Size(171, 10);
            this.panelCliente.TabIndex = 3;
            // 
            // panelImportExcel
            // 
            this.panelImportExcel.BackColor = System.Drawing.Color.Purple;
            this.panelImportExcel.Location = new System.Drawing.Point(410, 210);
            this.panelImportExcel.Name = "panelImportExcel";
            this.panelImportExcel.Size = new System.Drawing.Size(171, 10);
            this.panelImportExcel.TabIndex = 4;
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCliente.Location = new System.Drawing.Point(235, 223);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(75, 24);
            this.lbCliente.TabIndex = 7;
            this.lbCliente.Text = "Cliente";
            // 
            // lbImportExcel
            // 
            this.lbImportExcel.AutoSize = true;
            this.lbImportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImportExcel.Location = new System.Drawing.Point(424, 223);
            this.lbImportExcel.Name = "lbImportExcel";
            this.lbImportExcel.Size = new System.Drawing.Size(145, 24);
            this.lbImportExcel.TabIndex = 8;
            this.lbImportExcel.Text = "Importar Excel";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarca.Location = new System.Drawing.Point(678, 223);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(67, 24);
            this.lbMarca.TabIndex = 11;
            this.lbMarca.Text = "Marca";
            // 
            // panelMarca
            // 
            this.panelMarca.BackColor = System.Drawing.Color.Purple;
            this.panelMarca.Location = new System.Drawing.Point(624, 210);
            this.panelMarca.Name = "panelMarca";
            this.panelMarca.Size = new System.Drawing.Size(171, 10);
            this.panelMarca.TabIndex = 9;
            // 
            // picMarca
            // 
            this.picMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMarca.Image = global::MultimodeSales.Properties.Resources.catalog128px;
            this.picMarca.Location = new System.Drawing.Point(624, 59);
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
            this.picImportExcel.Location = new System.Drawing.Point(410, 59);
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
            this.picCliente.Location = new System.Drawing.Point(187, 59);
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
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1153, 596);
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
            this.Name = "Formulario";
            this.Text = "Form1";
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
    }
}

