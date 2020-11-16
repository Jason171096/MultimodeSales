namespace MultimodeSales.Vistas
{
    partial class TallasyColores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBarras = new System.Windows.Forms.Panel();
            this.lbColoresyTallas = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.dgvTallas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelarTalla = new System.Windows.Forms.Button();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.btnEliminarTalla = new System.Windows.Forms.Button();
            this.btnEditarTalla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarTalla = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancelarColor = new System.Windows.Forms.Button();
            this.btnEliminarColor = new System.Windows.Forms.Button();
            this.btnEditarColor = new System.Windows.Forms.Button();
            this.btnAgregarColor = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvColores = new System.Windows.Forms.DataGridView();
            this.panelBarras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTallas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColores)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarras
            // 
            this.panelBarras.BackColor = System.Drawing.Color.Purple;
            this.panelBarras.BackgroundImage = global::MultimodeSales.Properties.Resources.background5;
            this.panelBarras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBarras.Controls.Add(this.lbColoresyTallas);
            this.panelBarras.Controls.Add(this.picClose);
            this.panelBarras.Controls.Add(this.picMinimize);
            this.panelBarras.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarras.Location = new System.Drawing.Point(0, 0);
            this.panelBarras.Name = "panelBarras";
            this.panelBarras.Size = new System.Drawing.Size(749, 46);
            this.panelBarras.TabIndex = 30;
            this.panelBarras.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarras_MouseMove);
            // 
            // lbColoresyTallas
            // 
            this.lbColoresyTallas.AutoSize = true;
            this.lbColoresyTallas.BackColor = System.Drawing.Color.Transparent;
            this.lbColoresyTallas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColoresyTallas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbColoresyTallas.Location = new System.Drawing.Point(6, 9);
            this.lbColoresyTallas.Name = "lbColoresyTallas";
            this.lbColoresyTallas.Size = new System.Drawing.Size(187, 29);
            this.lbColoresyTallas.TabIndex = 36;
            this.lbColoresyTallas.Text = "Tallas y Colores";
            this.lbColoresyTallas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbColoresyTallas_MouseMove);
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::MultimodeSales.Properties.Resources.close48;
            this.picClose.Location = new System.Drawing.Point(689, 0);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(48, 48);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picClose.TabIndex = 24;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picMinimize
            // 
            this.picMinimize.BackColor = System.Drawing.Color.Transparent;
            this.picMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimize.Image = global::MultimodeSales.Properties.Resources.minimize48px;
            this.picMinimize.Location = new System.Drawing.Point(639, 0);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(48, 48);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMinimize.TabIndex = 23;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // dgvTallas
            // 
            this.dgvTallas.AllowUserToAddRows = false;
            this.dgvTallas.AllowUserToDeleteRows = false;
            this.dgvTallas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTallas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTallas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTallas.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvTallas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTallas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTallas.ColumnHeadersHeight = 50;
            this.dgvTallas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTallas.EnableHeadersVisualStyles = false;
            this.dgvTallas.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvTallas.Location = new System.Drawing.Point(358, 22);
            this.dgvTallas.Name = "dgvTallas";
            this.dgvTallas.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTallas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTallas.RowHeadersVisible = false;
            this.dgvTallas.RowHeadersWidth = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.dgvTallas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTallas.RowTemplate.Height = 30;
            this.dgvTallas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTallas.Size = new System.Drawing.Size(362, 211);
            this.dgvTallas.TabIndex = 34;
            this.dgvTallas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTallas_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelarTalla);
            this.groupBox1.Controls.Add(this.txtTalla);
            this.groupBox1.Controls.Add(this.btnEliminarTalla);
            this.groupBox1.Controls.Add(this.dgvTallas);
            this.groupBox1.Controls.Add(this.btnEditarTalla);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAgregarTalla);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox1.Location = new System.Drawing.Point(11, 365);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 239);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tallas";
            // 
            // btnCancelarTalla
            // 
            this.btnCancelarTalla.BackColor = System.Drawing.Color.Indigo;
            this.btnCancelarTalla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarTalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnCancelarTalla.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelarTalla.Location = new System.Drawing.Point(188, 156);
            this.btnCancelarTalla.Name = "btnCancelarTalla";
            this.btnCancelarTalla.Size = new System.Drawing.Size(163, 37);
            this.btnCancelarTalla.TabIndex = 47;
            this.btnCancelarTalla.Text = "Cancelar";
            this.btnCancelarTalla.UseVisualStyleBackColor = false;
            this.btnCancelarTalla.Visible = false;
            this.btnCancelarTalla.Click += new System.EventHandler(this.btnCancelarTalla_Click);
            // 
            // txtTalla
            // 
            this.txtTalla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtTalla.Location = new System.Drawing.Point(114, 56);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(216, 29);
            this.txtTalla.TabIndex = 42;
            // 
            // btnEliminarTalla
            // 
            this.btnEliminarTalla.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminarTalla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarTalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnEliminarTalla.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEliminarTalla.Location = new System.Drawing.Point(25, 156);
            this.btnEliminarTalla.Name = "btnEliminarTalla";
            this.btnEliminarTalla.Size = new System.Drawing.Size(157, 37);
            this.btnEliminarTalla.TabIndex = 46;
            this.btnEliminarTalla.Text = "Eliminar";
            this.btnEliminarTalla.UseVisualStyleBackColor = false;
            this.btnEliminarTalla.Click += new System.EventHandler(this.btnEliminarTalla_Click);
            // 
            // btnEditarTalla
            // 
            this.btnEditarTalla.BackColor = System.Drawing.Color.SlateBlue;
            this.btnEditarTalla.Enabled = false;
            this.btnEditarTalla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarTalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnEditarTalla.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEditarTalla.Location = new System.Drawing.Point(188, 113);
            this.btnEditarTalla.Name = "btnEditarTalla";
            this.btnEditarTalla.Size = new System.Drawing.Size(163, 37);
            this.btnEditarTalla.TabIndex = 45;
            this.btnEditarTalla.Text = "Editar";
            this.btnEditarTalla.UseVisualStyleBackColor = false;
            this.btnEditarTalla.Click += new System.EventHandler(this.btnEditarTalla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(24, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 43;
            this.label3.Text = "Número:";
            // 
            // btnAgregarTalla
            // 
            this.btnAgregarTalla.BackColor = System.Drawing.Color.SlateBlue;
            this.btnAgregarTalla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarTalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnAgregarTalla.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgregarTalla.Location = new System.Drawing.Point(25, 113);
            this.btnAgregarTalla.Name = "btnAgregarTalla";
            this.btnAgregarTalla.Size = new System.Drawing.Size(157, 37);
            this.btnAgregarTalla.TabIndex = 44;
            this.btnAgregarTalla.Text = "Agregar";
            this.btnAgregarTalla.UseVisualStyleBackColor = false;
            this.btnAgregarTalla.Click += new System.EventHandler(this.btnAgregarTalla_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancelarColor);
            this.groupBox2.Controls.Add(this.btnEliminarColor);
            this.groupBox2.Controls.Add(this.btnEditarColor);
            this.groupBox2.Controls.Add(this.btnAgregarColor);
            this.groupBox2.Controls.Add(this.txtColor);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dgvColores);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox2.Location = new System.Drawing.Point(11, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(726, 305);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colores";
            // 
            // btnCancelarColor
            // 
            this.btnCancelarColor.BackColor = System.Drawing.Color.Indigo;
            this.btnCancelarColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnCancelarColor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelarColor.Location = new System.Drawing.Point(197, 153);
            this.btnCancelarColor.Name = "btnCancelarColor";
            this.btnCancelarColor.Size = new System.Drawing.Size(156, 37);
            this.btnCancelarColor.TabIndex = 43;
            this.btnCancelarColor.Text = "Cancelar";
            this.btnCancelarColor.UseVisualStyleBackColor = false;
            this.btnCancelarColor.Visible = false;
            this.btnCancelarColor.Click += new System.EventHandler(this.btnCancelarColor_Click);
            // 
            // btnEliminarColor
            // 
            this.btnEliminarColor.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminarColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnEliminarColor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEliminarColor.Location = new System.Drawing.Point(34, 153);
            this.btnEliminarColor.Name = "btnEliminarColor";
            this.btnEliminarColor.Size = new System.Drawing.Size(157, 37);
            this.btnEliminarColor.TabIndex = 42;
            this.btnEliminarColor.Text = "Eliminar";
            this.btnEliminarColor.UseVisualStyleBackColor = false;
            this.btnEliminarColor.Click += new System.EventHandler(this.btnEliminarColor_Click);
            // 
            // btnEditarColor
            // 
            this.btnEditarColor.BackColor = System.Drawing.Color.SlateBlue;
            this.btnEditarColor.Enabled = false;
            this.btnEditarColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnEditarColor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEditarColor.Location = new System.Drawing.Point(197, 110);
            this.btnEditarColor.Name = "btnEditarColor";
            this.btnEditarColor.Size = new System.Drawing.Size(156, 37);
            this.btnEditarColor.TabIndex = 41;
            this.btnEditarColor.Text = "Editar";
            this.btnEditarColor.UseVisualStyleBackColor = false;
            this.btnEditarColor.Click += new System.EventHandler(this.btnEditarColor_Click);
            // 
            // btnAgregarColor
            // 
            this.btnAgregarColor.BackColor = System.Drawing.Color.SlateBlue;
            this.btnAgregarColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnAgregarColor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgregarColor.Location = new System.Drawing.Point(34, 110);
            this.btnAgregarColor.Name = "btnAgregarColor";
            this.btnAgregarColor.Size = new System.Drawing.Size(157, 37);
            this.btnAgregarColor.TabIndex = 40;
            this.btnAgregarColor.Text = "Agregar";
            this.btnAgregarColor.UseVisualStyleBackColor = false;
            this.btnAgregarColor.Click += new System.EventHandler(this.btnAgregarColor_Click);
            // 
            // txtColor
            // 
            this.txtColor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtColor.Location = new System.Drawing.Point(115, 54);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(216, 29);
            this.txtColor.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(25, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nombre:";
            // 
            // dgvColores
            // 
            this.dgvColores.AllowUserToAddRows = false;
            this.dgvColores.AllowUserToDeleteRows = false;
            this.dgvColores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvColores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvColores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvColores.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvColores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvColores.ColumnHeadersHeight = 50;
            this.dgvColores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvColores.EnableHeadersVisualStyles = false;
            this.dgvColores.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvColores.Location = new System.Drawing.Point(359, 22);
            this.dgvColores.Name = "dgvColores";
            this.dgvColores.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColores.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvColores.RowHeadersVisible = false;
            this.dgvColores.RowHeadersWidth = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.dgvColores.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvColores.RowTemplate.Height = 30;
            this.dgvColores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColores.Size = new System.Drawing.Size(361, 277);
            this.dgvColores.TabIndex = 34;
            this.dgvColores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvColores_CellDoubleClick);
            // 
            // TallasyColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(749, 619);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelBarras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TallasyColores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TallasyColores";
            this.panelBarras.ResumeLayout(false);
            this.panelBarras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTallas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarras;
        private System.Windows.Forms.Label lbColoresyTallas;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.DataGridView dgvTallas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvColores;
        private System.Windows.Forms.TextBox txtTalla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelarTalla;
        private System.Windows.Forms.Button btnEliminarTalla;
        private System.Windows.Forms.Button btnEditarTalla;
        private System.Windows.Forms.Button btnAgregarTalla;
        private System.Windows.Forms.Button btnCancelarColor;
        private System.Windows.Forms.Button btnEliminarColor;
        private System.Windows.Forms.Button btnEditarColor;
        private System.Windows.Forms.Button btnAgregarColor;
    }
}