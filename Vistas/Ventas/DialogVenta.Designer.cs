
namespace MultimodeSales.Vistas.Ventas
{
    partial class DialogVenta
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
            this.btnVender = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbCambio = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.tbLayout = new System.Windows.Forms.TableLayoutPanel();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.tbLayoutCambio = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLayoutTotal = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLayout.SuspendLayout();
            this.tbLayoutCambio.SuspendLayout();
            this.tbLayoutTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.SlateBlue;
            this.btnVender.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnVender.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnVender.Location = new System.Drawing.Point(341, 307);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(162, 36);
            this.btnVender.TabIndex = 61;
            this.btnVender.Text = "Vender(Enter)";
            this.btnVender.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Indigo;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelar.Location = new System.Drawing.Point(12, 307);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(157, 36);
            this.btnCancelar.TabIndex = 62;
            this.btnCancelar.Text = "Cancelar(Esc)";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbCambio
            // 
            this.lbCambio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCambio.AutoSize = true;
            this.lbCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbCambio.Location = new System.Drawing.Point(181, 0);
            this.lbCambio.Name = "lbCambio";
            this.lbCambio.Size = new System.Drawing.Size(261, 72);
            this.lbCambio.TabIndex = 2;
            this.lbCambio.Text = "label2";
            this.lbCambio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbTotal.Location = new System.Drawing.Point(181, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(261, 72);
            this.lbTotal.TabIndex = 0;
            this.lbTotal.Text = "label1";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbLayout
            // 
            this.tbLayout.ColumnCount = 1;
            this.tbLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLayout.Controls.Add(this.txtCantidad, 0, 1);
            this.tbLayout.Controls.Add(this.tbLayoutCambio, 0, 2);
            this.tbLayout.Controls.Add(this.tbLayoutTotal, 0, 0);
            this.tbLayout.Location = new System.Drawing.Point(33, 43);
            this.tbLayout.Name = "tbLayout";
            this.tbLayout.RowCount = 3;
            this.tbLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbLayout.Size = new System.Drawing.Size(451, 236);
            this.tbLayout.TabIndex = 64;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtCantidad.Location = new System.Drawing.Point(3, 81);
            this.txtCantidad.MaxLength = 10;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(445, 53);
            this.txtCantidad.TabIndex = 2;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.WordWrap = false;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            this.txtCantidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyUp);
            // 
            // tbLayoutCambio
            // 
            this.tbLayoutCambio.ColumnCount = 2;
            this.tbLayoutCambio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tbLayoutCambio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tbLayoutCambio.Controls.Add(this.label2, 0, 0);
            this.tbLayoutCambio.Controls.Add(this.lbCambio, 1, 0);
            this.tbLayoutCambio.Location = new System.Drawing.Point(3, 159);
            this.tbLayoutCambio.Name = "tbLayoutCambio";
            this.tbLayoutCambio.RowCount = 1;
            this.tbLayoutCambio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLayoutCambio.Size = new System.Drawing.Size(445, 72);
            this.tbLayoutCambio.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 72);
            this.label2.TabIndex = 66;
            this.label2.Text = "Cambio:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbLayoutTotal
            // 
            this.tbLayoutTotal.ColumnCount = 2;
            this.tbLayoutTotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tbLayoutTotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tbLayoutTotal.Controls.Add(this.lbTotal, 1, 0);
            this.tbLayoutTotal.Controls.Add(this.label1, 0, 0);
            this.tbLayoutTotal.Location = new System.Drawing.Point(3, 3);
            this.tbLayoutTotal.Name = "tbLayoutTotal";
            this.tbLayoutTotal.RowCount = 1;
            this.tbLayoutTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLayoutTotal.Size = new System.Drawing.Size(445, 72);
            this.tbLayoutTotal.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 72);
            this.label1.TabIndex = 65;
            this.label1.Text = "Total:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DialogVenta
            // 
            this.AcceptButton = this.btnVender;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Green;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(515, 357);
            this.Controls.Add(this.tbLayout);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnVender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentaDevolucion";
            this.Load += new System.EventHandler(this.DialogVenta_Load);
            this.tbLayout.ResumeLayout(false);
            this.tbLayout.PerformLayout();
            this.tbLayoutCambio.ResumeLayout(false);
            this.tbLayoutCambio.PerformLayout();
            this.tbLayoutTotal.ResumeLayout(false);
            this.tbLayoutTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbCambio;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TableLayoutPanel tbLayout;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TableLayoutPanel tbLayoutTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tbLayoutCambio;
        private System.Windows.Forms.Label label2;
    }
}