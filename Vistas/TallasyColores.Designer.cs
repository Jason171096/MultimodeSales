﻿namespace MultimodeSales.Vistas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBarras = new System.Windows.Forms.Panel();
            this.lbColoresyTallas = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.dgvTallas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnEliminarTalla = new RoundButton.RoundButton();
            this.rbtnCancelarTalla = new RoundButton.RoundButton();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.rbtnEditarTalla = new RoundButton.RoundButton();
            this.rbtnAgregarTalla = new RoundButton.RoundButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnEliminarColor = new RoundButton.RoundButton();
            this.rbtnCancelarColor = new RoundButton.RoundButton();
            this.rbtnEditarColor = new RoundButton.RoundButton();
            this.rbtnAgregarColor = new RoundButton.RoundButton();
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
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTallas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvTallas.ColumnHeadersHeight = 50;
            this.dgvTallas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTallas.EnableHeadersVisualStyles = false;
            this.dgvTallas.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvTallas.Location = new System.Drawing.Point(358, 22);
            this.dgvTallas.Name = "dgvTallas";
            this.dgvTallas.ReadOnly = true;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTallas.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvTallas.RowHeadersVisible = false;
            this.dgvTallas.RowHeadersWidth = 30;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.dgvTallas.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvTallas.RowTemplate.Height = 30;
            this.dgvTallas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTallas.Size = new System.Drawing.Size(362, 211);
            this.dgvTallas.TabIndex = 34;
            this.dgvTallas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTallas_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnEliminarTalla);
            this.groupBox1.Controls.Add(this.rbtnCancelarTalla);
            this.groupBox1.Controls.Add(this.txtTalla);
            this.groupBox1.Controls.Add(this.rbtnEditarTalla);
            this.groupBox1.Controls.Add(this.rbtnAgregarTalla);
            this.groupBox1.Controls.Add(this.dgvTallas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox1.Location = new System.Drawing.Point(11, 365);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 239);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tallas";
            // 
            // rbtnEliminarTalla
            // 
            this.rbtnEliminarTalla.BorderColor = System.Drawing.Color.Silver;
            this.rbtnEliminarTalla.ButtonColor = System.Drawing.Color.Red;
            this.rbtnEliminarTalla.Location = new System.Drawing.Point(20, 156);
            this.rbtnEliminarTalla.Name = "rbtnEliminarTalla";
            this.rbtnEliminarTalla.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnEliminarTalla.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnEliminarTalla.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnEliminarTalla.Size = new System.Drawing.Size(160, 37);
            this.rbtnEliminarTalla.TabIndex = 51;
            this.rbtnEliminarTalla.Text = "Eliminar";
            this.rbtnEliminarTalla.TextColor = System.Drawing.Color.White;
            this.rbtnEliminarTalla.UseVisualStyleBackColor = true;
            this.rbtnEliminarTalla.Click += new System.EventHandler(this.rbtnEliminarTalla_Click);
            // 
            // rbtnCancelarTalla
            // 
            this.rbtnCancelarTalla.BorderColor = System.Drawing.Color.Silver;
            this.rbtnCancelarTalla.ButtonColor = System.Drawing.Color.Red;
            this.rbtnCancelarTalla.Location = new System.Drawing.Point(186, 156);
            this.rbtnCancelarTalla.Name = "rbtnCancelarTalla";
            this.rbtnCancelarTalla.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnCancelarTalla.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnCancelarTalla.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnCancelarTalla.Size = new System.Drawing.Size(160, 37);
            this.rbtnCancelarTalla.TabIndex = 50;
            this.rbtnCancelarTalla.Text = "Cancelar";
            this.rbtnCancelarTalla.TextColor = System.Drawing.Color.White;
            this.rbtnCancelarTalla.UseVisualStyleBackColor = true;
            this.rbtnCancelarTalla.Click += new System.EventHandler(this.rbtnCancelarTalla_Click);
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
            // rbtnEditarTalla
            // 
            this.rbtnEditarTalla.BorderColor = System.Drawing.Color.Silver;
            this.rbtnEditarTalla.ButtonColor = System.Drawing.Color.Red;
            this.rbtnEditarTalla.Location = new System.Drawing.Point(186, 113);
            this.rbtnEditarTalla.Name = "rbtnEditarTalla";
            this.rbtnEditarTalla.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnEditarTalla.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnEditarTalla.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnEditarTalla.Size = new System.Drawing.Size(160, 37);
            this.rbtnEditarTalla.TabIndex = 49;
            this.rbtnEditarTalla.Text = "Editar";
            this.rbtnEditarTalla.TextColor = System.Drawing.Color.White;
            this.rbtnEditarTalla.UseVisualStyleBackColor = true;
            this.rbtnEditarTalla.Click += new System.EventHandler(this.rbtnEditarTalla_Click);
            // 
            // rbtnAgregarTalla
            // 
            this.rbtnAgregarTalla.BorderColor = System.Drawing.Color.Silver;
            this.rbtnAgregarTalla.ButtonColor = System.Drawing.Color.Red;
            this.rbtnAgregarTalla.Location = new System.Drawing.Point(22, 113);
            this.rbtnAgregarTalla.Name = "rbtnAgregarTalla";
            this.rbtnAgregarTalla.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnAgregarTalla.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnAgregarTalla.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnAgregarTalla.Size = new System.Drawing.Size(160, 37);
            this.rbtnAgregarTalla.TabIndex = 48;
            this.rbtnAgregarTalla.Text = "Agregar";
            this.rbtnAgregarTalla.TextColor = System.Drawing.Color.White;
            this.rbtnAgregarTalla.UseVisualStyleBackColor = true;
            this.rbtnAgregarTalla.Click += new System.EventHandler(this.rbtnAgregarTalla_Click);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnEliminarColor);
            this.groupBox2.Controls.Add(this.rbtnCancelarColor);
            this.groupBox2.Controls.Add(this.rbtnEditarColor);
            this.groupBox2.Controls.Add(this.rbtnAgregarColor);
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
            // rbtnEliminarColor
            // 
            this.rbtnEliminarColor.BorderColor = System.Drawing.Color.Silver;
            this.rbtnEliminarColor.ButtonColor = System.Drawing.Color.Red;
            this.rbtnEliminarColor.Location = new System.Drawing.Point(28, 173);
            this.rbtnEliminarColor.Name = "rbtnEliminarColor";
            this.rbtnEliminarColor.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnEliminarColor.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnEliminarColor.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnEliminarColor.Size = new System.Drawing.Size(160, 37);
            this.rbtnEliminarColor.TabIndex = 47;
            this.rbtnEliminarColor.Text = "Eliminar";
            this.rbtnEliminarColor.TextColor = System.Drawing.Color.White;
            this.rbtnEliminarColor.UseVisualStyleBackColor = true;
            this.rbtnEliminarColor.Click += new System.EventHandler(this.rbtnEliminarColor_Click);
            // 
            // rbtnCancelarColor
            // 
            this.rbtnCancelarColor.BorderColor = System.Drawing.Color.Silver;
            this.rbtnCancelarColor.ButtonColor = System.Drawing.Color.Red;
            this.rbtnCancelarColor.Location = new System.Drawing.Point(195, 173);
            this.rbtnCancelarColor.Name = "rbtnCancelarColor";
            this.rbtnCancelarColor.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnCancelarColor.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnCancelarColor.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnCancelarColor.Size = new System.Drawing.Size(160, 37);
            this.rbtnCancelarColor.TabIndex = 46;
            this.rbtnCancelarColor.Text = "Cancelar";
            this.rbtnCancelarColor.TextColor = System.Drawing.Color.White;
            this.rbtnCancelarColor.UseVisualStyleBackColor = true;
            this.rbtnCancelarColor.Click += new System.EventHandler(this.rbtnCancelarColor_Click);
            // 
            // rbtnEditarColor
            // 
            this.rbtnEditarColor.BorderColor = System.Drawing.Color.Silver;
            this.rbtnEditarColor.ButtonColor = System.Drawing.Color.Red;
            this.rbtnEditarColor.Location = new System.Drawing.Point(195, 130);
            this.rbtnEditarColor.Name = "rbtnEditarColor";
            this.rbtnEditarColor.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnEditarColor.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnEditarColor.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnEditarColor.Size = new System.Drawing.Size(160, 37);
            this.rbtnEditarColor.TabIndex = 45;
            this.rbtnEditarColor.Text = "Editar";
            this.rbtnEditarColor.TextColor = System.Drawing.Color.White;
            this.rbtnEditarColor.UseVisualStyleBackColor = true;
            this.rbtnEditarColor.Click += new System.EventHandler(this.rbtnEditarColor_Click);
            // 
            // rbtnAgregarColor
            // 
            this.rbtnAgregarColor.BorderColor = System.Drawing.Color.Silver;
            this.rbtnAgregarColor.ButtonColor = System.Drawing.Color.Red;
            this.rbtnAgregarColor.Location = new System.Drawing.Point(29, 130);
            this.rbtnAgregarColor.Name = "rbtnAgregarColor";
            this.rbtnAgregarColor.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnAgregarColor.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.rbtnAgregarColor.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnAgregarColor.Size = new System.Drawing.Size(160, 37);
            this.rbtnAgregarColor.TabIndex = 44;
            this.rbtnAgregarColor.Text = "Agregar";
            this.rbtnAgregarColor.TextColor = System.Drawing.Color.White;
            this.rbtnAgregarColor.UseVisualStyleBackColor = true;
            this.rbtnAgregarColor.Click += new System.EventHandler(this.rbtnAgregarColor_Click);
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
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvColores.ColumnHeadersHeight = 50;
            this.dgvColores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvColores.EnableHeadersVisualStyles = false;
            this.dgvColores.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvColores.Location = new System.Drawing.Point(359, 22);
            this.dgvColores.Name = "dgvColores";
            this.dgvColores.ReadOnly = true;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColores.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvColores.RowHeadersVisible = false;
            this.dgvColores.RowHeadersWidth = 30;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.dgvColores.RowsDefaultCellStyle = dataGridViewCellStyle24;
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
        private RoundButton.RoundButton rbtnAgregarColor;
        private RoundButton.RoundButton rbtnEliminarColor;
        private RoundButton.RoundButton rbtnCancelarColor;
        private RoundButton.RoundButton rbtnEditarColor;
        private RoundButton.RoundButton rbtnEliminarTalla;
        private RoundButton.RoundButton rbtnCancelarTalla;
        private RoundButton.RoundButton rbtnEditarTalla;
        private RoundButton.RoundButton rbtnAgregarTalla;
    }
}