namespace MultimodeSales.Vistas.Excel
{
    partial class ImportarPor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImportarPrecios = new System.Windows.Forms.Button();
            this.btnImportarPedidos = new System.Windows.Forms.Button();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.panelBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(109, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 68);
            this.label1.TabIndex = 2;
            this.label1.Text = "Importar lista de\r\n precios de marcas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(119, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 68);
            this.label2.TabIndex = 3;
            this.label2.Text = "Importar lista de\r\n pedidos final";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnImportarPrecios
            // 
            this.btnImportarPrecios.BackColor = System.Drawing.Color.SlateBlue;
            this.btnImportarPrecios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImportarPrecios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportarPrecios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImportarPrecios.Location = new System.Drawing.Point(94, 150);
            this.btnImportarPrecios.Name = "btnImportarPrecios";
            this.btnImportarPrecios.Size = new System.Drawing.Size(311, 88);
            this.btnImportarPrecios.TabIndex = 23;
            this.btnImportarPrecios.Text = "Importar Excel Precios";
            this.btnImportarPrecios.UseVisualStyleBackColor = false;
            this.btnImportarPrecios.Click += new System.EventHandler(this.btnImportarPrecios_Click_1);
            // 
            // btnImportarPedidos
            // 
            this.btnImportarPedidos.BackColor = System.Drawing.Color.SlateBlue;
            this.btnImportarPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImportarPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportarPedidos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImportarPedidos.Location = new System.Drawing.Point(94, 353);
            this.btnImportarPedidos.Name = "btnImportarPedidos";
            this.btnImportarPedidos.Size = new System.Drawing.Size(311, 88);
            this.btnImportarPedidos.TabIndex = 24;
            this.btnImportarPedidos.Text = "Importar Excel Pedidos";
            this.btnImportarPedidos.UseVisualStyleBackColor = false;
            this.btnImportarPedidos.Click += new System.EventHandler(this.btnImportarPedidos_Click_1);
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.Transparent;
            this.panelBarra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBarra.Controls.Add(this.picClose);
            this.panelBarra.Controls.Add(this.picMinimize);
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(0, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(500, 49);
            this.panelBarra.TabIndex = 25;
            this.panelBarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarra_MouseMove);
            // 
            // picClose
            // 
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::MultimodeSales.Properties.Resources.close48;
            this.picClose.Location = new System.Drawing.Point(449, 0);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(48, 48);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picClose.TabIndex = 22;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picMinimize
            // 
            this.picMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimize.Image = global::MultimodeSales.Properties.Resources.minimize48px;
            this.picMinimize.Location = new System.Drawing.Point(395, 1);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(48, 48);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMinimize.TabIndex = 21;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // ImportarPor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.BackgroundImage = global::MultimodeSales.Properties.Resources.background5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 494);
            this.Controls.Add(this.panelBarra);
            this.Controls.Add(this.btnImportarPedidos);
            this.Controls.Add(this.btnImportarPrecios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ImportarPor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImportarPor";
            this.panelBarra.ResumeLayout(false);
            this.panelBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImportarPrecios;
        private System.Windows.Forms.Button btnImportarPedidos;
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMinimize;
    }
}