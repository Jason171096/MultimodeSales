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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 68);
            this.label1.TabIndex = 2;
            this.label1.Text = "Importar lista de\r\n precios de marcas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 240);
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
            this.btnImportarPrecios.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnImportarPrecios.Location = new System.Drawing.Point(89, 119);
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
            this.btnImportarPedidos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnImportarPedidos.Location = new System.Drawing.Point(89, 322);
            this.btnImportarPedidos.Name = "btnImportarPedidos";
            this.btnImportarPedidos.Size = new System.Drawing.Size(311, 88);
            this.btnImportarPedidos.TabIndex = 24;
            this.btnImportarPedidos.Text = "Importar Excel Pedidos";
            this.btnImportarPedidos.UseVisualStyleBackColor = false;
            this.btnImportarPedidos.Click += new System.EventHandler(this.btnImportarPedidos_Click_1);
            // 
            // ImportarPor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(500, 452);
            this.Controls.Add(this.btnImportarPedidos);
            this.Controls.Add(this.btnImportarPrecios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ImportarPor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImportarPor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImportarPrecios;
        private System.Windows.Forms.Button btnImportarPedidos;
    }
}