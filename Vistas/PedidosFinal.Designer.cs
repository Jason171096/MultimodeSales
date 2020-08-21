namespace MultimodeSales.Vistas
{
    partial class PedidosFinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidosFinal));
            System.Drawing.Drawing2D.ColorBlend colorBlend1 = new System.Drawing.Drawing2D.ColorBlend();
            System.Drawing.Drawing2D.ColorBlend colorBlend2 = new System.Drawing.Drawing2D.ColorBlend();
            this.dgvExcel = new System.Windows.Forms.DataGridView();
            this.lbRuta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCargar = new Zeroit.Framework.ButtonThematic.Controls.ButtonThematic();
            this.btnImportar = new Zeroit.Framework.ButtonThematic.Controls.ButtonThematic();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).BeginInit();
            this.SuspendLayout();
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
            this.dgvExcel.Location = new System.Drawing.Point(33, 83);
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
            this.dgvExcel.Size = new System.Drawing.Size(1143, 507);
            this.dgvExcel.TabIndex = 7;
            // 
            // lbRuta
            // 
            this.lbRuta.AutoSize = true;
            this.lbRuta.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRuta.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbRuta.Location = new System.Drawing.Point(277, 32);
            this.lbRuta.Name = "lbRuta";
            this.lbRuta.Size = new System.Drawing.Size(19, 27);
            this.lbRuta.TabIndex = 16;
            this.lbRuta.Text = ".";
            this.lbRuta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(201, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 27);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ruta:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCargar
            // 
            this.btnCargar.AdobeAlternate = false;
            this.btnCargar.AdvancedSystemGlow = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(210)))));
            this.btnCargar.AllowClickAnimation = true;
            this.btnCargar.AlphaBorders = new System.Drawing.Color[] {
        System.Drawing.Color.Lime,
        System.Drawing.Color.DimGray};
            this.btnCargar.AngelBackground = System.Drawing.Color.Black;
            this.btnCargar.AngelColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(78)))), ((int)(((byte)(108))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(67))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(143))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.Black};
            this.btnCargar.Anomborder = System.Drawing.Color.Black;
            this.btnCargar.AnombuttonBottom = System.Drawing.Color.Gainsboro;
            this.btnCargar.AnombuttonTop = System.Drawing.Color.Beige;
            this.btnCargar.AnomDown = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))))};
            this.btnCargar.AnomHatchColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.Transparent};
            this.btnCargar.AnomNone = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))))};
            this.btnCargar.ArcColour = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnCargar.ArrowBorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.btnCargar.ArrowColour = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.btnCargar.AryanBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))))};
            this.btnCargar.AryanDownstateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))))};
            this.btnCargar.AryanNonestateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))))};
            this.btnCargar.AryanOverstateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))))};
            this.btnCargar.AvatarBorder = System.Drawing.Color.Black;
            this.btnCargar.AvatarButtonColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnCargar.AvatarButtonColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnCargar.AvatarStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            this.btnCargar.Avgbackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(143)))), ((int)(((byte)(124)))));
            this.btnCargar.AvgBorder = System.Drawing.Color.Transparent;
            this.btnCargar.Background = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnCargar.BackgroundColour = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(98)))), ((int)(((byte)(158)))));
            this.btnCargar.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnCargar.BasicBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.btnCargar.BasicColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            this.btnCargar.BasicDisabled = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.btnCargar.BasicHighlights = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.btnCargar.BasicStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            this.btnCargar.BetaBlueDark = false;
            this.btnCargar.BeyondDrawMode = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.BeyondDrawStyle.Basic;
            this.btnCargar.BloodyBorder = System.Drawing.Color.Black;
            this.btnCargar.BloodyButtonColor = System.Drawing.Color.WhiteSmoke;
            this.btnCargar.BlueC1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(123)))), ((int)(((byte)(173)))));
            this.btnCargar.BlueC2 = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(106)))), ((int)(((byte)(163)))));
            this.btnCargar.BorderButtonStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.BorderButtonStyles.Full;
            this.btnCargar.BorderButtonSubText = null;
            this.btnCargar.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnCargar.BorderSize = 1;
            this.btnCargar.BullionImage = null;
            this.btnCargar.ClickMaxOffset = 10;
            this.btnCargar.ClickOffset = 1;
            this.btnCargar.ClickSpeed = 1;
            this.btnCargar.ClsStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.ClsStyles.Blue;
            this.btnCargar.Color = System.Drawing.Color.Empty;
            this.btnCargar.Colors = new Zeroit.Framework.ButtonThematic.ThemeManagers.Bloom[0];
            this.btnCargar.Curve = 20;
            this.btnCargar.CustomAdvantiumBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCargar.CustomAdvantiumBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))))};
            this.btnCargar.CustomAdvantiumDownColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))))};
            this.btnCargar.CustomAdvantiumNoneColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))))};
            this.btnCargar.CustomAdvantiumOffsets = new int[] {
        1,
        0,
        0};
            this.btnCargar.CustomAdvantiumOverColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))))};
            this.btnCargar.CustomAdvSysColorDilution = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCargar.CustomAresioBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(70)))))};
            this.btnCargar.CustomAresioDownColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Transparent};
            this.btnCargar.CustomAresioNoneColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(70))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(40)))))};
            this.btnCargar.CustomAresioOverColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.Transparent};
            this.btnCargar.CustomBasicBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.btnCargar.CustomBasicColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            this.btnCargar.CustomBasicDisabled = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.btnCargar.CustomBasicHighlights = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.btnCargar.CustomBasicOffset = 3;
            this.btnCargar.CustomBasicStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            this.btnCargar.CustomBitDefenderBorder = System.Drawing.Color.Black;
            this.btnCargar.CustomBitDefenderC1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnCargar.CustomBitDefenderC2 = System.Drawing.Color.White;
            this.btnCargar.CustomBitDefenderC3 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnCargar.CustomBitDefenderC4 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCargar.CustomBitDefenderC5 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCargar.CustomBitDefenderC6 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnCargar.CustomBitDefenderFadeColor = System.Drawing.Color.White;
            this.btnCargar.CustomBlackShadesDownColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(38))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(38))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(38))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(31)))), ((int)(((byte)(43))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(65)))), ((int)(((byte)(68))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))))};
            this.btnCargar.CustomBlackShadesNoneColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(38))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.Transparent,
        System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(31)))), ((int)(((byte)(43))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(65)))), ((int)(((byte)(68))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(103)))), ((int)(((byte)(105))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))))};
            this.btnCargar.CustomBlackShadesOverColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(38))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.Transparent,
        System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(31)))), ((int)(((byte)(43))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(65)))), ((int)(((byte)(68))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(103)))), ((int)(((byte)(105))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))), ((int)(((byte)(105))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(33))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))))};
            this.btnCargar.CustomBnWInactiveBorder = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnCargar.CustomBnWOffsetFill = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))))};
            this.btnCargar.CustomBnWRounding = 50;
            this.btnCargar.CustomBoosterColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            this.btnCargar.CustomBoosterGradientAngle = 270F;
            this.btnCargar.CustomBoosterHatchColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            this.btnCargar.CustomBoosterHoverTransparency = 50F;
            this.btnCargar.CustomBoosterInfluenceOuter = false;
            this.btnCargar.CustomBoosterInnerBorder = System.Drawing.Color.Black;
            this.btnCargar.CustomBoosterOffset = 6;
            this.btnCargar.CustomBoosterOuterBorder = System.Drawing.Color.Black;
            this.btnCargar.CustomBwOffset = 10;
            this.btnCargar.CustomClassicBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnCargar.CustomClassicBorder = System.Drawing.Color.Black;
            this.btnCargar.CustomClassicColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255))))),
        System.Drawing.Color.Transparent};
            this.btnCargar.CustomClassicHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnCargar.CustomClassicShadow = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCargar.CustomDeumosBackground = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.btnCargar.CustomDeumosBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.Black};
            this.btnCargar.CustomDeumosCornerColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.btnCargar.CustomDeumosDownStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))))};
            this.btnCargar.CustomDeumosNoneStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.btnCargar.CustomDeumosOverStateColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCargar.CustomExcisionBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.White};
            this.btnCargar.CustomExcisionStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.CustomExcisionStyles.Default;
            this.btnCargar.CustomFocusScales = ((System.Drawing.PointF)(resources.GetObject("btnCargar.CustomFocusScales")));
            colorBlend1.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))))};
            colorBlend1.Positions = new float[] {
        0F,
        0.5F,
        1F};
            this.btnCargar.CustomFusionBlend = colorBlend1;
            this.btnCargar.CustomFusionCornerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCargar.CustomFusionDownBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnCargar.CustomFusionGradColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))))};
            this.btnCargar.CustomFusionNoneBorderColor = System.Drawing.Color.Black;
            this.btnCargar.CustomFusionOverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnCargar.CustomGameBoosterBotGradient = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnCargar.CustomGameBoosterBotGradientClick = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnCargar.CustomGameBoosterBotGradientHover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnCargar.CustomGameBoosterCornerColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnCargar.CustomGameBoosterInnerBorder = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnCargar.CustomGameBoosterInnerBorderClick = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnCargar.CustomGameBoosterInnerBorderHover = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnCargar.CustomGameBoosterOuterBorder = System.Drawing.Color.Black;
            this.btnCargar.CustomGameBoosterOuterBorderClick = System.Drawing.Color.Black;
            this.btnCargar.CustomGameBoosterOuterBorderHover = System.Drawing.Color.Black;
            this.btnCargar.CustomGameBoosterTopGradient = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnCargar.CustomGameBoosterTopGradientClick = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCargar.CustomGameBoosterTopGradientHover = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnCargar.CustomIntelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCargar.CustomIntelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.btnCargar.CustomIntelGlow = 100;
            this.btnCargar.CustomIntelShade = System.Drawing.Color.Black;
            this.btnCargar.CustomizableAdobeBackground = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCargar.CustomizableAdobeBorderOffset = 2;
            this.btnCargar.CustomizableAdobeCoefficient = 15;
            this.btnCargar.CustomizableAdobeColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48))))),
        System.Drawing.Color.White,
        System.Drawing.Color.Black};
            this.btnCargar.CustomizableAdvancedSystemGlow = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(210)))));
            this.btnCargar.CustomizableAdvancedSystemSlope = 5;
            this.btnCargar.CustomizableAdvSysBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnCargar.CustomizableStyle = Zeroit.Framework.ButtonThematic.BaseContainer.CustomizableStyles.Intel;
            this.btnCargar.Customization = "";
            this.btnCargar.Customize = new Zeroit.Framework.ButtonThematic.Controls.ButtonInput(System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(128))))), System.Drawing.Color.Black, 20, 100);
            this.btnCargar.CustomizedBtnActive = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))))};
            this.btnCargar.CustomizedBtnActiveBorder = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))))};
            this.btnCargar.CustomizedBtnInactive = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            this.btnCargar.CustomizedBtnInactiveBorder = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnCargar.CustomizedBtnOffset = 3;
            this.btnCargar.CustomizedBtnOffsetBorder = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))))};
            this.btnCargar.CustomizedBtnOffsetGradient = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))))};
            this.btnCargar.CustomizedBtnPressed = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))))};
            this.btnCargar.CustomizedBtnPressedBorder = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))))};
            this.btnCargar.CustomNamelessBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))),
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.btnCargar.CustomNamelessCorners = System.Drawing.Color.Black;
            this.btnCargar.CustomNamelessDownHighlight = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))))};
            this.btnCargar.CustomNamelessNoneHighlight = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))))};
            this.btnCargar.CustomNamelessOverHighlight = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))))};
            this.btnCargar.CustomNetSealCenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCargar.CustomNetSealPathBorders = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))))};
            this.btnCargar.CustomNetSealSurroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnCargar.CustomOrainsButton = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))))};
            this.btnCargar.CustomOrainsHatch = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Transparent};
            this.btnCargar.CustomOrainsHeader = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCargar.CustomOrainsInnerBorder = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCargar.CustomOrainsOuterBorder = System.Drawing.Color.Black;
            this.btnCargar.CustomReconBackground = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnCargar.CustomReconBorder = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))))};
            this.btnCargar.CustomReconDownStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Transparent};
            this.btnCargar.CustomReconNoneStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))))};
            this.btnCargar.CustomReconOverStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))),
        System.Drawing.Color.Transparent};
            this.btnCargar.CustomRoasterBackgroundStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.Black};
            this.btnCargar.CustomRoasterBorderColor = System.Drawing.Color.Black;
            this.btnCargar.CustomRoasterGradientColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))))};
            this.btnCargar.CustomSpicyBackground = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btnCargar.CustomSpicyBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.btnCargar.CustomSpicyCornerColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnCargar.CustomSpicyDownStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))))};
            this.btnCargar.CustomSpicyHighlight = System.Drawing.Color.White;
            this.btnCargar.CustomSpicyNoneStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))))};
            this.btnCargar.CustomSpicyOverStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))))};
            this.btnCargar.CustomZeusBackground = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnCargar.CustomZeusBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.AliceBlue};
            this.btnCargar.CustomZeusClickLocate = 2;
            this.btnCargar.CustomZeusClickReduce = 5;
            this.btnCargar.CustomZeusGradientColors = new System.Drawing.Color[] {
        System.Drawing.Color.AliceBlue,
        System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.btnCargar.DarkTheme = false;
            this.btnCargar.DestinyBorder = System.Drawing.Color.Black;
            this.btnCargar.DestinyG1 = System.Drawing.Color.Teal;
            this.btnCargar.DestinyG2 = System.Drawing.Color.Black;
            this.btnCargar.DestinyG3 = System.Drawing.Color.Black;
            this.btnCargar.DestinyG4 = System.Drawing.Color.Teal;
            this.btnCargar.DestinyG5 = System.Drawing.Color.Teal;
            this.btnCargar.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(68)))), ((int)(((byte)(126)))));
            this.btnCargar.DownLeftCurve = 10;
            this.btnCargar.DownRightCurve = 10;
            this.btnCargar.DrawMode = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.RenderMode.Gradient;
            this.btnCargar.EffectualStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.EffectualStyles.Blue;
            this.btnCargar.EightBallAnimation = true;
            this.btnCargar.ElegantBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnCargar.ElegantBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(190)))), ((int)(((byte)(146)))));
            this.btnCargar.ElegantPressedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnCargar.ElementBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.btnCargar.EmpireButtonStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.EmpireButtonStyles.Normal;
            this.btnCargar.EnableGlass = true;
            this.btnCargar.ExcisionStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.ExcisionStyles.Default;
            this.btnCargar.FlatUIBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnCargar.FlatUIRounded = false;
            this.btnCargar.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCargar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCargar.GameBoosterBotGradient = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnCargar.GameBoosterBotGradientClick = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnCargar.GameBoosterBotGradientHover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnCargar.GameBoosterCornerColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnCargar.GameBoosterInnerBorder = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnCargar.GameBoosterInnerBorderClick = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnCargar.GameBoosterInnerBorderHover = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnCargar.GameBoosterOuterBorder = System.Drawing.Color.Black;
            this.btnCargar.GameBoosterOuterBorderClick = System.Drawing.Color.Black;
            this.btnCargar.GameBoosterOuterBorderHover = System.Drawing.Color.Black;
            this.btnCargar.GameBoosterTopGradient = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnCargar.GameBoosterTopGradientClick = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCargar.GameBoosterTopGradientHover = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnCargar.GradientAngle = 90F;
            this.btnCargar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnCargar.HatchStyle = System.Drawing.Drawing2D.HatchStyle.LightDownwardDiagonal;
            this.btnCargar.HoverColour = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnCargar.HuraAccentColor = System.Drawing.Color.Empty;
            this.btnCargar.HuraBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCargar.HuraColorScheme = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.HuraColorSchemes.Dark;
            this.btnCargar.Image = null;
            this.btnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCargar.ImageCodeString = resources.GetString("btnCargar.ImageCodeString");
            this.btnCargar.ImageSize = new System.Drawing.Size(0, 0);
            this.btnCargar.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.btnCargar.KnightRounded = false;
            this.btnCargar.Location = new System.Drawing.Point(33, 25);
            this.btnCargar.LoginMaximum = 100;
            this.btnCargar.Loginstyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.LoginStyles.Button;
            this.btnCargar.LoginValue = 0;
            this.btnCargar.LoyalOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btnCargar.metrodiskBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnCargar.MetrodiskRounded = false;
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.NeoBuxStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.NeoBuxStyles.Blue;
            this.btnCargar.NormalColour = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(199)))));
            this.btnCargar.NoRounding = false;
            this.btnCargar.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.None;
            this.btnCargar.PressedColour = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnCargar.ProgressColour = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnCargar.RedemptionStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.RedemptionStyles.Rectangle;
            this.btnCargar.SharpColor2 = false;
            this.btnCargar.ShowText = true;
            this.btnCargar.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(68)))), ((int)(((byte)(126)))));
            this.btnCargar.SimplaColorScheme = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.SimplaColorSchemes.DarkGray;
            this.btnCargar.Size = new System.Drawing.Size(149, 39);
            this.btnCargar.Smoothing = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.btnCargar.TabIndex = 14;
            this.btnCargar.TeenAccentColor = System.Drawing.Color.DodgerBlue;
            this.btnCargar.TeenColorScheme = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.teenColorSchemes.Dark;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.TextAlign = System.Drawing.StringAlignment.Center;
            this.btnCargar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnCargar.TextRendering = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnCargar.Theme = Zeroit.Framework.ButtonThematic.BaseContainer.Themes.Customized;
            this.btnCargar.ThemeStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.ColorTheme.GammaRay;
            this.btnCargar.ThiefAccentColor = System.Drawing.Color.Empty;
            this.btnCargar.Transparent = false;
            this.btnCargar.TwitchRounding = true;
            this.btnCargar.TwitchStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.TwitchStyles.Default;
            this.btnCargar.UpperColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(68)))), ((int)(((byte)(126)))));
            this.btnCargar.UpperLeftCurve = 10;
            this.btnCargar.UpperRightCurve = 10;
            this.btnCargar.XVisualShade = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.xVisualInnerShade.Dark;
            // 
            // btnImportar
            // 
            this.btnImportar.AdobeAlternate = false;
            this.btnImportar.AdvancedSystemGlow = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(210)))));
            this.btnImportar.AllowClickAnimation = true;
            this.btnImportar.AlphaBorders = new System.Drawing.Color[] {
        System.Drawing.Color.Lime,
        System.Drawing.Color.DimGray};
            this.btnImportar.AngelBackground = System.Drawing.Color.Black;
            this.btnImportar.AngelColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(78)))), ((int)(((byte)(108))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(67))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(143))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.Black};
            this.btnImportar.Anomborder = System.Drawing.Color.Black;
            this.btnImportar.AnombuttonBottom = System.Drawing.Color.Gainsboro;
            this.btnImportar.AnombuttonTop = System.Drawing.Color.Beige;
            this.btnImportar.AnomDown = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))))};
            this.btnImportar.AnomHatchColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.Transparent};
            this.btnImportar.AnomNone = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))))};
            this.btnImportar.ArcColour = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnImportar.ArrowBorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.btnImportar.ArrowColour = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.btnImportar.AryanBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))))};
            this.btnImportar.AryanDownstateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))))};
            this.btnImportar.AryanNonestateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))))};
            this.btnImportar.AryanOverstateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))))};
            this.btnImportar.AvatarBorder = System.Drawing.Color.Black;
            this.btnImportar.AvatarButtonColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnImportar.AvatarButtonColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnImportar.AvatarStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            this.btnImportar.Avgbackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(143)))), ((int)(((byte)(124)))));
            this.btnImportar.AvgBorder = System.Drawing.Color.Transparent;
            this.btnImportar.Background = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnImportar.BackgroundColour = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(98)))), ((int)(((byte)(158)))));
            this.btnImportar.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnImportar.BasicBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.btnImportar.BasicColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            this.btnImportar.BasicDisabled = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.btnImportar.BasicHighlights = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.btnImportar.BasicStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            this.btnImportar.BetaBlueDark = false;
            this.btnImportar.BeyondDrawMode = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.BeyondDrawStyle.Basic;
            this.btnImportar.BloodyBorder = System.Drawing.Color.Black;
            this.btnImportar.BloodyButtonColor = System.Drawing.Color.WhiteSmoke;
            this.btnImportar.BlueC1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(123)))), ((int)(((byte)(173)))));
            this.btnImportar.BlueC2 = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(106)))), ((int)(((byte)(163)))));
            this.btnImportar.BorderButtonStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.BorderButtonStyles.Full;
            this.btnImportar.BorderButtonSubText = null;
            this.btnImportar.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnImportar.BorderSize = 1;
            this.btnImportar.BullionImage = null;
            this.btnImportar.ClickMaxOffset = 10;
            this.btnImportar.ClickOffset = 1;
            this.btnImportar.ClickSpeed = 1;
            this.btnImportar.ClsStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.ClsStyles.Blue;
            this.btnImportar.Color = System.Drawing.Color.Empty;
            this.btnImportar.Colors = new Zeroit.Framework.ButtonThematic.ThemeManagers.Bloom[0];
            this.btnImportar.Curve = 20;
            this.btnImportar.CustomAdvantiumBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnImportar.CustomAdvantiumBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))))};
            this.btnImportar.CustomAdvantiumDownColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))))};
            this.btnImportar.CustomAdvantiumNoneColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))))};
            this.btnImportar.CustomAdvantiumOffsets = new int[] {
        1,
        0,
        0};
            this.btnImportar.CustomAdvantiumOverColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))))};
            this.btnImportar.CustomAdvSysColorDilution = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnImportar.CustomAresioBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(70)))))};
            this.btnImportar.CustomAresioDownColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Transparent};
            this.btnImportar.CustomAresioNoneColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(70))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(40)))))};
            this.btnImportar.CustomAresioOverColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.Transparent};
            this.btnImportar.CustomBasicBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.btnImportar.CustomBasicColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            this.btnImportar.CustomBasicDisabled = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.btnImportar.CustomBasicHighlights = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.btnImportar.CustomBasicOffset = 3;
            this.btnImportar.CustomBasicStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            this.btnImportar.CustomBitDefenderBorder = System.Drawing.Color.Black;
            this.btnImportar.CustomBitDefenderC1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnImportar.CustomBitDefenderC2 = System.Drawing.Color.White;
            this.btnImportar.CustomBitDefenderC3 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnImportar.CustomBitDefenderC4 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnImportar.CustomBitDefenderC5 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnImportar.CustomBitDefenderC6 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnImportar.CustomBitDefenderFadeColor = System.Drawing.Color.White;
            this.btnImportar.CustomBlackShadesDownColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(38))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(38))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(38))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(31)))), ((int)(((byte)(43))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(65)))), ((int)(((byte)(68))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))))};
            this.btnImportar.CustomBlackShadesNoneColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(38))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.Transparent,
        System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(31)))), ((int)(((byte)(43))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(65)))), ((int)(((byte)(68))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(103)))), ((int)(((byte)(105))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))))};
            this.btnImportar.CustomBlackShadesOverColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(38))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.Transparent,
        System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(31)))), ((int)(((byte)(43))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(65)))), ((int)(((byte)(68))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(103)))), ((int)(((byte)(105))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))), ((int)(((byte)(105))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(33))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))))};
            this.btnImportar.CustomBnWInactiveBorder = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnImportar.CustomBnWOffsetFill = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))))};
            this.btnImportar.CustomBnWRounding = 50;
            this.btnImportar.CustomBoosterColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            this.btnImportar.CustomBoosterGradientAngle = 270F;
            this.btnImportar.CustomBoosterHatchColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            this.btnImportar.CustomBoosterHoverTransparency = 50F;
            this.btnImportar.CustomBoosterInfluenceOuter = false;
            this.btnImportar.CustomBoosterInnerBorder = System.Drawing.Color.Black;
            this.btnImportar.CustomBoosterOffset = 6;
            this.btnImportar.CustomBoosterOuterBorder = System.Drawing.Color.Black;
            this.btnImportar.CustomBwOffset = 10;
            this.btnImportar.CustomClassicBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnImportar.CustomClassicBorder = System.Drawing.Color.Black;
            this.btnImportar.CustomClassicColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255))))),
        System.Drawing.Color.Transparent};
            this.btnImportar.CustomClassicHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnImportar.CustomClassicShadow = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnImportar.CustomDeumosBackground = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.btnImportar.CustomDeumosBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.Black};
            this.btnImportar.CustomDeumosCornerColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.btnImportar.CustomDeumosDownStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))))};
            this.btnImportar.CustomDeumosNoneStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.btnImportar.CustomDeumosOverStateColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnImportar.CustomExcisionBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.White};
            this.btnImportar.CustomExcisionStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.CustomExcisionStyles.Default;
            this.btnImportar.CustomFocusScales = ((System.Drawing.PointF)(resources.GetObject("btnImportar.CustomFocusScales")));
            colorBlend2.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))))};
            colorBlend2.Positions = new float[] {
        0F,
        0.5F,
        1F};
            this.btnImportar.CustomFusionBlend = colorBlend2;
            this.btnImportar.CustomFusionCornerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnImportar.CustomFusionDownBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnImportar.CustomFusionGradColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))))};
            this.btnImportar.CustomFusionNoneBorderColor = System.Drawing.Color.Black;
            this.btnImportar.CustomFusionOverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnImportar.CustomGameBoosterBotGradient = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnImportar.CustomGameBoosterBotGradientClick = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnImportar.CustomGameBoosterBotGradientHover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnImportar.CustomGameBoosterCornerColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnImportar.CustomGameBoosterInnerBorder = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnImportar.CustomGameBoosterInnerBorderClick = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnImportar.CustomGameBoosterInnerBorderHover = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnImportar.CustomGameBoosterOuterBorder = System.Drawing.Color.Black;
            this.btnImportar.CustomGameBoosterOuterBorderClick = System.Drawing.Color.Black;
            this.btnImportar.CustomGameBoosterOuterBorderHover = System.Drawing.Color.Black;
            this.btnImportar.CustomGameBoosterTopGradient = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnImportar.CustomGameBoosterTopGradientClick = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnImportar.CustomGameBoosterTopGradientHover = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnImportar.CustomIntelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnImportar.CustomIntelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.btnImportar.CustomIntelGlow = 100;
            this.btnImportar.CustomIntelShade = System.Drawing.Color.Black;
            this.btnImportar.CustomizableAdobeBackground = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnImportar.CustomizableAdobeBorderOffset = 2;
            this.btnImportar.CustomizableAdobeCoefficient = 15;
            this.btnImportar.CustomizableAdobeColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48))))),
        System.Drawing.Color.White,
        System.Drawing.Color.Black};
            this.btnImportar.CustomizableAdvancedSystemGlow = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(210)))));
            this.btnImportar.CustomizableAdvancedSystemSlope = 5;
            this.btnImportar.CustomizableAdvSysBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnImportar.CustomizableStyle = Zeroit.Framework.ButtonThematic.BaseContainer.CustomizableStyles.Intel;
            this.btnImportar.Customization = "";
            this.btnImportar.Customize = new Zeroit.Framework.ButtonThematic.Controls.ButtonInput(System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(128))))), System.Drawing.Color.Black, 20, 100);
            this.btnImportar.CustomizedBtnActive = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))))};
            this.btnImportar.CustomizedBtnActiveBorder = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))))};
            this.btnImportar.CustomizedBtnInactive = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            this.btnImportar.CustomizedBtnInactiveBorder = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnImportar.CustomizedBtnOffset = 3;
            this.btnImportar.CustomizedBtnOffsetBorder = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))))};
            this.btnImportar.CustomizedBtnOffsetGradient = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))))};
            this.btnImportar.CustomizedBtnPressed = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))))};
            this.btnImportar.CustomizedBtnPressedBorder = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))))};
            this.btnImportar.CustomNamelessBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))),
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.btnImportar.CustomNamelessCorners = System.Drawing.Color.Black;
            this.btnImportar.CustomNamelessDownHighlight = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))))};
            this.btnImportar.CustomNamelessNoneHighlight = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))))};
            this.btnImportar.CustomNamelessOverHighlight = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))))};
            this.btnImportar.CustomNetSealCenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnImportar.CustomNetSealPathBorders = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))))};
            this.btnImportar.CustomNetSealSurroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnImportar.CustomOrainsButton = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))))};
            this.btnImportar.CustomOrainsHatch = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Transparent};
            this.btnImportar.CustomOrainsHeader = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnImportar.CustomOrainsInnerBorder = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnImportar.CustomOrainsOuterBorder = System.Drawing.Color.Black;
            this.btnImportar.CustomReconBackground = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnImportar.CustomReconBorder = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))))};
            this.btnImportar.CustomReconDownStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Transparent};
            this.btnImportar.CustomReconNoneStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))))};
            this.btnImportar.CustomReconOverStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))),
        System.Drawing.Color.Transparent};
            this.btnImportar.CustomRoasterBackgroundStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.Black};
            this.btnImportar.CustomRoasterBorderColor = System.Drawing.Color.Black;
            this.btnImportar.CustomRoasterGradientColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))))};
            this.btnImportar.CustomSpicyBackground = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btnImportar.CustomSpicyBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.btnImportar.CustomSpicyCornerColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnImportar.CustomSpicyDownStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))))};
            this.btnImportar.CustomSpicyHighlight = System.Drawing.Color.White;
            this.btnImportar.CustomSpicyNoneStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))))};
            this.btnImportar.CustomSpicyOverStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))))};
            this.btnImportar.CustomZeusBackground = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnImportar.CustomZeusBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.AliceBlue};
            this.btnImportar.CustomZeusClickLocate = 2;
            this.btnImportar.CustomZeusClickReduce = 5;
            this.btnImportar.CustomZeusGradientColors = new System.Drawing.Color[] {
        System.Drawing.Color.AliceBlue,
        System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.btnImportar.DarkTheme = false;
            this.btnImportar.DestinyBorder = System.Drawing.Color.Black;
            this.btnImportar.DestinyG1 = System.Drawing.Color.Teal;
            this.btnImportar.DestinyG2 = System.Drawing.Color.Black;
            this.btnImportar.DestinyG3 = System.Drawing.Color.Black;
            this.btnImportar.DestinyG4 = System.Drawing.Color.Teal;
            this.btnImportar.DestinyG5 = System.Drawing.Color.Teal;
            this.btnImportar.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(68)))), ((int)(((byte)(126)))));
            this.btnImportar.DownLeftCurve = 10;
            this.btnImportar.DownRightCurve = 10;
            this.btnImportar.DrawMode = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.RenderMode.Gradient;
            this.btnImportar.EffectualStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.EffectualStyles.Blue;
            this.btnImportar.EightBallAnimation = true;
            this.btnImportar.ElegantBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnImportar.ElegantBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(190)))), ((int)(((byte)(146)))));
            this.btnImportar.ElegantPressedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnImportar.ElementBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.btnImportar.EmpireButtonStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.EmpireButtonStyles.Normal;
            this.btnImportar.EnableGlass = true;
            this.btnImportar.ExcisionStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.ExcisionStyles.Default;
            this.btnImportar.FlatUIBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnImportar.FlatUIRounded = false;
            this.btnImportar.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnImportar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImportar.GameBoosterBotGradient = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnImportar.GameBoosterBotGradientClick = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnImportar.GameBoosterBotGradientHover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnImportar.GameBoosterCornerColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnImportar.GameBoosterInnerBorder = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnImportar.GameBoosterInnerBorderClick = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnImportar.GameBoosterInnerBorderHover = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnImportar.GameBoosterOuterBorder = System.Drawing.Color.Black;
            this.btnImportar.GameBoosterOuterBorderClick = System.Drawing.Color.Black;
            this.btnImportar.GameBoosterOuterBorderHover = System.Drawing.Color.Black;
            this.btnImportar.GameBoosterTopGradient = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnImportar.GameBoosterTopGradientClick = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnImportar.GameBoosterTopGradientHover = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnImportar.GradientAngle = 90F;
            this.btnImportar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnImportar.HatchStyle = System.Drawing.Drawing2D.HatchStyle.LightDownwardDiagonal;
            this.btnImportar.HoverColour = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnImportar.HuraAccentColor = System.Drawing.Color.Empty;
            this.btnImportar.HuraBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnImportar.HuraColorScheme = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.HuraColorSchemes.Dark;
            this.btnImportar.Image = null;
            this.btnImportar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImportar.ImageCodeString = resources.GetString("btnImportar.ImageCodeString");
            this.btnImportar.ImageSize = new System.Drawing.Size(0, 0);
            this.btnImportar.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.btnImportar.KnightRounded = false;
            this.btnImportar.Location = new System.Drawing.Point(971, 600);
            this.btnImportar.LoginMaximum = 100;
            this.btnImportar.Loginstyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.LoginStyles.Button;
            this.btnImportar.LoginValue = 0;
            this.btnImportar.LoyalOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btnImportar.metrodiskBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnImportar.MetrodiskRounded = false;
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.NeoBuxStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.NeoBuxStyles.Blue;
            this.btnImportar.NormalColour = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(199)))));
            this.btnImportar.NoRounding = false;
            this.btnImportar.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.None;
            this.btnImportar.PressedColour = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnImportar.ProgressColour = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnImportar.RedemptionStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.RedemptionStyles.Rectangle;
            this.btnImportar.SharpColor2 = false;
            this.btnImportar.ShowText = true;
            this.btnImportar.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(68)))), ((int)(((byte)(126)))));
            this.btnImportar.SimplaColorScheme = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.SimplaColorSchemes.DarkGray;
            this.btnImportar.Size = new System.Drawing.Size(205, 38);
            this.btnImportar.Smoothing = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.btnImportar.TabIndex = 17;
            this.btnImportar.TeenAccentColor = System.Drawing.Color.DodgerBlue;
            this.btnImportar.TeenColorScheme = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.teenColorSchemes.Dark;
            this.btnImportar.Text = "Importar";
            this.btnImportar.TextAlign = System.Drawing.StringAlignment.Center;
            this.btnImportar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnImportar.TextRendering = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnImportar.Theme = Zeroit.Framework.ButtonThematic.BaseContainer.Themes.Customized;
            this.btnImportar.ThemeStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.ColorTheme.GammaRay;
            this.btnImportar.ThiefAccentColor = System.Drawing.Color.Empty;
            this.btnImportar.Transparent = false;
            this.btnImportar.TwitchRounding = true;
            this.btnImportar.TwitchStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.TwitchStyles.Default;
            this.btnImportar.UpperColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(68)))), ((int)(((byte)(126)))));
            this.btnImportar.UpperLeftCurve = 10;
            this.btnImportar.UpperRightCurve = 10;
            this.btnImportar.XVisualShade = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.xVisualInnerShade.Dark;
            // 
            // PedidosFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1219, 650);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.lbRuta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dgvExcel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PedidosFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PedidosFinal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExcel;
        private System.Windows.Forms.Label lbRuta;
        private System.Windows.Forms.Label label3;
        private Zeroit.Framework.ButtonThematic.Controls.ButtonThematic btnCargar;
        private Zeroit.Framework.ButtonThematic.Controls.ButtonThematic btnImportar;
    }
}