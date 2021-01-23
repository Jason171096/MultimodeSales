
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
            this.rbtnFolioVentas = new RoundButton.RoundButton();
            this.rbtnFolioDevoluciones = new RoundButton.RoundButton();
            this.SuspendLayout();
            // 
            // rbtnFolioVentas
            // 
            this.rbtnFolioVentas.BorderColor = System.Drawing.Color.Silver;
            this.rbtnFolioVentas.ButtonColor = System.Drawing.Color.Red;
            this.rbtnFolioVentas.Location = new System.Drawing.Point(12, 77);
            this.rbtnFolioVentas.Name = "rbtnFolioVentas";
            this.rbtnFolioVentas.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnFolioVentas.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnFolioVentas.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnFolioVentas.Size = new System.Drawing.Size(285, 111);
            this.rbtnFolioVentas.TabIndex = 66;
            this.rbtnFolioVentas.Text = "Folio Ventas";
            this.rbtnFolioVentas.TextColor = System.Drawing.Color.White;
            this.rbtnFolioVentas.UseVisualStyleBackColor = true;
            this.rbtnFolioVentas.Click += new System.EventHandler(this.rbtnFolioVentas_Click);
            // 
            // rbtnFolioDevoluciones
            // 
            this.rbtnFolioDevoluciones.BorderColor = System.Drawing.Color.Silver;
            this.rbtnFolioDevoluciones.ButtonColor = System.Drawing.Color.Red;
            this.rbtnFolioDevoluciones.Location = new System.Drawing.Point(12, 194);
            this.rbtnFolioDevoluciones.Name = "rbtnFolioDevoluciones";
            this.rbtnFolioDevoluciones.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnFolioDevoluciones.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnFolioDevoluciones.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnFolioDevoluciones.Size = new System.Drawing.Size(285, 111);
            this.rbtnFolioDevoluciones.TabIndex = 67;
            this.rbtnFolioDevoluciones.Text = "Folio Devoluciones";
            this.rbtnFolioDevoluciones.TextColor = System.Drawing.Color.White;
            this.rbtnFolioDevoluciones.UseVisualStyleBackColor = true;
            this.rbtnFolioDevoluciones.Click += new System.EventHandler(this.rbtnFolioDevoluciones_Click);
            // 
            // TipoFolio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.BackgroundImage = global::MultimodeSales.Properties.Resources.background4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(317, 326);
            this.Controls.Add(this.rbtnFolioDevoluciones);
            this.Controls.Add(this.rbtnFolioVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TipoFolio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TipoFolio";
            this.ResumeLayout(false);

        }

        #endregion

        private RoundButton.RoundButton rbtnFolioVentas;
        private RoundButton.RoundButton rbtnFolioDevoluciones;
    }
}