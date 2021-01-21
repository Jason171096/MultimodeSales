
namespace MultimodeSales.Vistas
{
    partial class Folio
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
            this.panelBarras = new System.Windows.Forms.Panel();
            this.lbFolio = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.dtgFolio = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnCliente = new System.Windows.Forms.RadioButton();
            this.rbtnIDFolio = new System.Windows.Forms.RadioButton();
            this.rbtnFecha = new System.Windows.Forms.RadioButton();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.txtIDFolio = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.panelBarras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFolio)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarras
            // 
            this.panelBarras.BackColor = System.Drawing.Color.Purple;
            this.panelBarras.BackgroundImage = global::MultimodeSales.Properties.Resources.background5;
            this.panelBarras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBarras.Controls.Add(this.lbFolio);
            this.panelBarras.Controls.Add(this.picClose);
            this.panelBarras.Controls.Add(this.picMinimize);
            this.panelBarras.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarras.Location = new System.Drawing.Point(0, 0);
            this.panelBarras.Name = "panelBarras";
            this.panelBarras.Size = new System.Drawing.Size(616, 46);
            this.panelBarras.TabIndex = 30;
            // 
            // lbFolio
            // 
            this.lbFolio.AutoSize = true;
            this.lbFolio.BackColor = System.Drawing.Color.Transparent;
            this.lbFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFolio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbFolio.Location = new System.Drawing.Point(6, 9);
            this.lbFolio.Name = "lbFolio";
            this.lbFolio.Size = new System.Drawing.Size(68, 29);
            this.lbFolio.TabIndex = 36;
            this.lbFolio.Text = "Folio";
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::MultimodeSales.Properties.Resources.close48;
            this.picClose.Location = new System.Drawing.Point(556, 0);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(48, 48);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picClose.TabIndex = 24;
            this.picClose.TabStop = false;
            // 
            // picMinimize
            // 
            this.picMinimize.BackColor = System.Drawing.Color.Transparent;
            this.picMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimize.Image = global::MultimodeSales.Properties.Resources.minimize48px;
            this.picMinimize.Location = new System.Drawing.Point(506, 0);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(48, 48);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMinimize.TabIndex = 23;
            this.picMinimize.TabStop = false;
            // 
            // dtgFolio
            // 
            this.dtgFolio.BackgroundColor = System.Drawing.Color.DimGray;
            this.dtgFolio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFolio.Location = new System.Drawing.Point(11, 196);
            this.dtgFolio.Name = "dtgFolio";
            this.dtgFolio.Size = new System.Drawing.Size(594, 370);
            this.dtgFolio.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.txtIDFolio);
            this.groupBox1.Controls.Add(this.txtIDCliente);
            this.groupBox1.Controls.Add(this.rbtnIDFolio);
            this.groupBox1.Controls.Add(this.rbtnCliente);
            this.groupBox1.Controls.Add(this.rbtnFecha);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox1.Location = new System.Drawing.Point(11, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 138);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // rbtnCliente
            // 
            this.rbtnCliente.AutoSize = true;
            this.rbtnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rbtnCliente.Location = new System.Drawing.Point(46, 31);
            this.rbtnCliente.Name = "rbtnCliente";
            this.rbtnCliente.Size = new System.Drawing.Size(113, 28);
            this.rbtnCliente.TabIndex = 0;
            this.rbtnCliente.TabStop = true;
            this.rbtnCliente.Text = "ID Cliente:";
            this.rbtnCliente.UseVisualStyleBackColor = true;
            // 
            // rbtnIDFolio
            // 
            this.rbtnIDFolio.AutoSize = true;
            this.rbtnIDFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rbtnIDFolio.Location = new System.Drawing.Point(46, 65);
            this.rbtnIDFolio.Name = "rbtnIDFolio";
            this.rbtnIDFolio.Size = new System.Drawing.Size(97, 28);
            this.rbtnIDFolio.TabIndex = 1;
            this.rbtnIDFolio.TabStop = true;
            this.rbtnIDFolio.Text = "ID Folio:";
            this.rbtnIDFolio.UseVisualStyleBackColor = true;
            // 
            // rbtnFecha
            // 
            this.rbtnFecha.AutoSize = true;
            this.rbtnFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rbtnFecha.Location = new System.Drawing.Point(46, 99);
            this.rbtnFecha.Name = "rbtnFecha";
            this.rbtnFecha.Size = new System.Drawing.Size(87, 28);
            this.rbtnFecha.TabIndex = 2;
            this.rbtnFecha.TabStop = true;
            this.rbtnFecha.Text = "Fecha:";
            this.rbtnFecha.UseVisualStyleBackColor = true;
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtIDCliente.Location = new System.Drawing.Point(160, 31);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(355, 29);
            this.txtIDCliente.TabIndex = 3;
            // 
            // txtIDFolio
            // 
            this.txtIDFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtIDFolio.Location = new System.Drawing.Point(160, 66);
            this.txtIDFolio.Name = "txtIDFolio";
            this.txtIDFolio.Size = new System.Drawing.Size(355, 29);
            this.txtIDFolio.TabIndex = 4;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(160, 99);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(166, 29);
            this.dtpFecha.TabIndex = 43;
            // 
            // Folio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(616, 578);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgFolio);
            this.Controls.Add(this.panelBarras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Folio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folios";
            this.panelBarras.ResumeLayout(false);
            this.panelBarras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFolio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarras;
        private System.Windows.Forms.Label lbFolio;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.DataGridView dtgFolio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnFecha;
        private System.Windows.Forms.RadioButton rbtnIDFolio;
        private System.Windows.Forms.RadioButton rbtnCliente;
        private System.Windows.Forms.TextBox txtIDFolio;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}