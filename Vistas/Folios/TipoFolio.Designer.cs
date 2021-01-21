
namespace MultimodeSales.Vistas.Folios
{
    partial class TipoFolio
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
            this.btnFolioVenta = new System.Windows.Forms.Button();
            this.btnFolioDevoluciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFolioVenta
            // 
            this.btnFolioVenta.BackColor = System.Drawing.Color.SlateBlue;
            this.btnFolioVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFolioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.btnFolioVenta.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnFolioVenta.Location = new System.Drawing.Point(12, 77);
            this.btnFolioVenta.Name = "btnFolioVenta";
            this.btnFolioVenta.Size = new System.Drawing.Size(285, 111);
            this.btnFolioVenta.TabIndex = 64;
            this.btnFolioVenta.Text = "Folio Ventas";
            this.btnFolioVenta.UseVisualStyleBackColor = false;
            this.btnFolioVenta.Click += new System.EventHandler(this.btnFolioVenta_Click);
            // 
            // btnFolioDevoluciones
            // 
            this.btnFolioDevoluciones.BackColor = System.Drawing.Color.SlateBlue;
            this.btnFolioDevoluciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFolioDevoluciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.btnFolioDevoluciones.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnFolioDevoluciones.Location = new System.Drawing.Point(12, 194);
            this.btnFolioDevoluciones.Name = "btnFolioDevoluciones";
            this.btnFolioDevoluciones.Size = new System.Drawing.Size(285, 111);
            this.btnFolioDevoluciones.TabIndex = 65;
            this.btnFolioDevoluciones.Text = "Folio Devoluciones";
            this.btnFolioDevoluciones.UseVisualStyleBackColor = false;
            this.btnFolioDevoluciones.Click += new System.EventHandler(this.btnFolioDevoluciones_Click);
            // 
            // TipoFolio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.BackgroundImage = global::MultimodeSales.Properties.Resources.background4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(317, 326);
            this.Controls.Add(this.btnFolioDevoluciones);
            this.Controls.Add(this.btnFolioVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TipoFolio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TipoFolio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFolioVenta;
        private System.Windows.Forms.Button btnFolioDevoluciones;
    }
}