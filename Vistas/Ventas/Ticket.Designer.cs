
namespace MultimodeSales.Vistas.Ventas
{
    partial class Ticket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticket));
            this.barraSuperior = new Barra.BarraSuperior();
            this.SuspendLayout();
            // 
            // barraSuperior
            // 
            this.barraSuperior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barraSuperior.BackgroundImage")));
            this.barraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraSuperior.Location = new System.Drawing.Point(0, 0);
            this.barraSuperior.Name = "barraSuperior";
            this.barraSuperior.Size = new System.Drawing.Size(1016, 51);
            this.barraSuperior.TabIndex = 0;
            this.barraSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.barraSuperior_MouseMove);
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1016, 571);
            this.Controls.Add(this.barraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ticket";
            this.Text = "Ticket";
            this.ResumeLayout(false);

        }

        #endregion

        private Barra.BarraSuperior barraSuperior;
    }
}