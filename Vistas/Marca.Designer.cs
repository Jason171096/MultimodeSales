namespace MultimodeSales.Vistas
{
    partial class Marca
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroMarca = new System.Windows.Forms.TextBox();
            this.btnAgregarMarca = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEditarMarca = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.AllowUserToAddRows = false;
            this.dgvMarcas.AllowUserToDeleteRows = false;
            this.dgvMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMarcas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMarcas.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvMarcas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMarcas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMarcas.ColumnHeadersHeight = 50;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMarcas.EnableHeadersVisualStyles = false;
            this.dgvMarcas.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvMarcas.Location = new System.Drawing.Point(597, 40);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMarcas.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMarcas.RowHeadersVisible = false;
            this.dgvMarcas.RowHeadersWidth = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.dgvMarcas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMarcas.RowTemplate.Height = 30;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(240, 439);
            this.dgvMarcas.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre:";
            // 
            // txtNombreMarca
            // 
            this.txtNombreMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMarca.Location = new System.Drawing.Point(292, 116);
            this.txtNombreMarca.Name = "txtNombreMarca";
            this.txtNombreMarca.Size = new System.Drawing.Size(268, 35);
            this.txtNombreMarca.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Numero Marca:";
            // 
            // txtNumeroMarca
            // 
            this.txtNumeroMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroMarca.Location = new System.Drawing.Point(292, 65);
            this.txtNumeroMarca.Name = "txtNumeroMarca";
            this.txtNumeroMarca.Size = new System.Drawing.Size(268, 35);
            this.txtNumeroMarca.TabIndex = 8;
            this.txtNumeroMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroMarca_KeyPress);
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.AutoSize = true;
            this.btnAgregarMarca.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarMarca.Depth = 0;
            this.btnAgregarMarca.Icon = null;
            this.btnAgregarMarca.Location = new System.Drawing.Point(164, 277);
            this.btnAgregarMarca.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Primary = true;
            this.btnAgregarMarca.Size = new System.Drawing.Size(134, 36);
            this.btnAgregarMarca.TabIndex = 14;
            this.btnAgregarMarca.Text = "Agregar Marca";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // btnEditarMarca
            // 
            this.btnEditarMarca.AutoSize = true;
            this.btnEditarMarca.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditarMarca.Depth = 0;
            this.btnEditarMarca.Icon = null;
            this.btnEditarMarca.Location = new System.Drawing.Point(357, 277);
            this.btnEditarMarca.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarMarca.Name = "btnEditarMarca";
            this.btnEditarMarca.Primary = true;
            this.btnEditarMarca.Size = new System.Drawing.Size(119, 36);
            this.btnEditarMarca.TabIndex = 16;
            this.btnEditarMarca.Text = "Editar Marca";
            this.btnEditarMarca.UseVisualStyleBackColor = true;
            this.btnEditarMarca.Click += new System.EventHandler(this.btnEditarMarca_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.MediumPurple;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 491);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Purple;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(50, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 21);
            this.panel2.TabIndex = 18;
            // 
            // Marca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(849, 491);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEditarMarca);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumeroMarca);
            this.Controls.Add(this.dgvMarcas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Marca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marca";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroMarca;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregarMarca;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditarMarca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}