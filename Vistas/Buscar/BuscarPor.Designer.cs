namespace MultimodeSales.Vistas.Buscar
{
    partial class BuscarPor
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
            this.btnImportarPedidos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImportarPedidos
            // 
            this.btnImportarPedidos.BackColor = System.Drawing.Color.SlateBlue;
            this.btnImportarPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImportarPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportarPedidos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnImportarPedidos.Location = new System.Drawing.Point(70, 65);
            this.btnImportarPedidos.Name = "btnImportarPedidos";
            this.btnImportarPedidos.Size = new System.Drawing.Size(311, 88);
            this.btnImportarPedidos.TabIndex = 25;
            this.btnImportarPedidos.Text = "Buscar Pedido";
            this.btnImportarPedidos.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(70, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(311, 88);
            this.button1.TabIndex = 26;
            this.button1.Text = "Buscar Modelo";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(70, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(311, 88);
            this.button2.TabIndex = 27;
            this.button2.Text = "Buscar ";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // BuscarPor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(458, 601);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnImportarPedidos);
            this.Name = "BuscarPor";
            this.Text = "BuscarPor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImportarPedidos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}