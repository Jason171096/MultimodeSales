﻿namespace MultimodeSales.Vistas.Excel
{
    partial class ImportarPedidosFinal
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
            this.lbRuta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvExcel = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.dgvExcel2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRuta
            // 
            this.lbRuta.AutoSize = true;
            this.lbRuta.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRuta.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbRuta.Location = new System.Drawing.Point(275, 41);
            this.lbRuta.Name = "lbRuta";
            this.lbRuta.Size = new System.Drawing.Size(19, 27);
            this.lbRuta.TabIndex = 17;
            this.lbRuta.Text = ".";
            this.lbRuta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(199, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 27);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ruta:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvExcel
            // 
            this.dgvExcel.AllowUserToAddRows = false;
            this.dgvExcel.AllowUserToDeleteRows = false;
            this.dgvExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExcel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvExcel.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvExcel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExcel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExcel.ColumnHeadersHeight = 50;
            this.dgvExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvExcel.EnableHeadersVisualStyles = false;
            this.dgvExcel.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvExcel.Location = new System.Drawing.Point(20, 79);
            this.dgvExcel.Name = "dgvExcel";
            this.dgvExcel.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExcel.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExcel.RowHeadersVisible = false;
            this.dgvExcel.RowHeadersWidth = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.dgvExcel.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExcel.RowTemplate.Height = 30;
            this.dgvExcel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExcel.Size = new System.Drawing.Size(1094, 467);
            this.dgvExcel.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(212, 565);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 81);
            this.label2.TabIndex = 19;
            this.label2.Text = "Importa la \r\nlista a la\r\nBase de Datos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnImportar.Location = new System.Drawing.Point(395, 574);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(212, 46);
            this.btnImportar.TabIndex = 27;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = false;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCargar.Location = new System.Drawing.Point(25, 38);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(151, 34);
            this.btnCargar.TabIndex = 26;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // dgvExcel2
            // 
            this.dgvExcel2.AllowUserToAddRows = false;
            this.dgvExcel2.AllowUserToDeleteRows = false;
            this.dgvExcel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExcel2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvExcel2.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvExcel2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExcel2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvExcel2.ColumnHeadersHeight = 50;
            this.dgvExcel2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvExcel2.EnableHeadersVisualStyles = false;
            this.dgvExcel2.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvExcel2.Location = new System.Drawing.Point(12, 94);
            this.dgvExcel2.Name = "dgvExcel2";
            this.dgvExcel2.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExcel2.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvExcel2.RowHeadersVisible = false;
            this.dgvExcel2.RowHeadersWidth = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.dgvExcel2.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvExcel2.RowTemplate.Height = 30;
            this.dgvExcel2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExcel2.Size = new System.Drawing.Size(595, 442);
            this.dgvExcel2.TabIndex = 28;
            // 
            // ImportarPedidosFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(619, 659);
            this.Controls.Add(this.dgvExcel2);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbRuta);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ImportarPedidosFinal";
            this.Text = "ImportarPedidosFinal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRuta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvExcel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DataGridView dgvExcel2;
    }
}