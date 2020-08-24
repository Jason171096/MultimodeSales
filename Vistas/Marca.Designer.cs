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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Marca));
            System.Drawing.Drawing2D.ColorBlend colorBlend1 = new System.Drawing.Drawing2D.ColorBlend();
            System.Drawing.Drawing2D.ColorBlend colorBlend2 = new System.Drawing.Drawing2D.ColorBlend();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroMarca = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAgregarMarca = new Zeroit.Framework.ButtonThematic.Controls.ButtonThematic();
            this.btnEditarMarca = new Zeroit.Framework.ButtonThematic.Controls.ButtonThematic();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMarcas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMarcas.ColumnHeadersHeight = 50;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMarcas.EnableHeadersVisualStyles = false;
            this.dgvMarcas.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvMarcas.Location = new System.Drawing.Point(597, 40);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMarcas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMarcas.RowHeadersVisible = false;
            this.dgvMarcas.RowHeadersWidth = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.dgvMarcas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMarcas.RowTemplate.Height = 30;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(240, 439);
            this.dgvMarcas.TabIndex = 7;
            this.dgvMarcas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarcas_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre:";
            // 
            // txtNombreMarca
            // 
            this.txtNombreMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMarca.Location = new System.Drawing.Point(282, 151);
            this.txtNombreMarca.Name = "txtNombreMarca";
            this.txtNombreMarca.Size = new System.Drawing.Size(268, 35);
            this.txtNombreMarca.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Numero Marca:";
            // 
            // txtNumeroMarca
            // 
            this.txtNumeroMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroMarca.Location = new System.Drawing.Point(282, 100);
            this.txtNumeroMarca.Name = "txtNumeroMarca";
            this.txtNumeroMarca.Size = new System.Drawing.Size(268, 35);
            this.txtNumeroMarca.TabIndex = 8;
            this.txtNumeroMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroMarca_KeyPress);
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
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.AdobeAlternate = false;
            this.btnAgregarMarca.AdvancedSystemGlow = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(210)))));
            this.btnAgregarMarca.AllowClickAnimation = true;
            this.btnAgregarMarca.AlphaBorders = new System.Drawing.Color[] {
        System.Drawing.Color.Lime,
        System.Drawing.Color.DimGray};
            this.btnAgregarMarca.AngelBackground = System.Drawing.Color.Black;
            this.btnAgregarMarca.AngelColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(78)))), ((int)(((byte)(108))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(67))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(143))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.Black};
            this.btnAgregarMarca.Anomborder = System.Drawing.Color.Black;
            this.btnAgregarMarca.AnombuttonBottom = System.Drawing.Color.Gainsboro;
            this.btnAgregarMarca.AnombuttonTop = System.Drawing.Color.Beige;
            this.btnAgregarMarca.AnomDown = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))))};
            this.btnAgregarMarca.AnomHatchColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.Transparent};
            this.btnAgregarMarca.AnomNone = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))))};
            this.btnAgregarMarca.ArcColour = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnAgregarMarca.ArrowBorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.btnAgregarMarca.ArrowColour = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.btnAgregarMarca.AryanBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))))};
            this.btnAgregarMarca.AryanDownstateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))))};
            this.btnAgregarMarca.AryanNonestateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))))};
            this.btnAgregarMarca.AryanOverstateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))))};
            this.btnAgregarMarca.AvatarBorder = System.Drawing.Color.Black;
            this.btnAgregarMarca.AvatarButtonColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnAgregarMarca.AvatarButtonColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnAgregarMarca.AvatarStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            this.btnAgregarMarca.Avgbackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(143)))), ((int)(((byte)(124)))));
            this.btnAgregarMarca.AvgBorder = System.Drawing.Color.Transparent;
            this.btnAgregarMarca.Background = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnAgregarMarca.BackgroundColour = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(98)))), ((int)(((byte)(158)))));
            this.btnAgregarMarca.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnAgregarMarca.BasicBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.btnAgregarMarca.BasicColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            this.btnAgregarMarca.BasicDisabled = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.btnAgregarMarca.BasicHighlights = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.btnAgregarMarca.BasicStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            this.btnAgregarMarca.BetaBlueDark = false;
            this.btnAgregarMarca.BeyondDrawMode = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.BeyondDrawStyle.Basic;
            this.btnAgregarMarca.BloodyBorder = System.Drawing.Color.Black;
            this.btnAgregarMarca.BloodyButtonColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarMarca.BlueC1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(123)))), ((int)(((byte)(173)))));
            this.btnAgregarMarca.BlueC2 = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(106)))), ((int)(((byte)(163)))));
            this.btnAgregarMarca.BorderButtonStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.BorderButtonStyles.Full;
            this.btnAgregarMarca.BorderButtonSubText = null;
            this.btnAgregarMarca.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnAgregarMarca.BorderSize = 1;
            this.btnAgregarMarca.BullionImage = null;
            this.btnAgregarMarca.ClickMaxOffset = 10;
            this.btnAgregarMarca.ClickOffset = 1;
            this.btnAgregarMarca.ClickSpeed = 1;
            this.btnAgregarMarca.ClsStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.ClsStyles.Blue;
            this.btnAgregarMarca.Color = System.Drawing.Color.Empty;
            this.btnAgregarMarca.Colors = new Zeroit.Framework.ButtonThematic.ThemeManagers.Bloom[0];
            this.btnAgregarMarca.Curve = 20;
            this.btnAgregarMarca.CustomAdvantiumBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAgregarMarca.CustomAdvantiumBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))))};
            this.btnAgregarMarca.CustomAdvantiumDownColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))))};
            this.btnAgregarMarca.CustomAdvantiumNoneColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))))};
            this.btnAgregarMarca.CustomAdvantiumOffsets = new int[] {
        1,
        0,
        0};
            this.btnAgregarMarca.CustomAdvantiumOverColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))))};
            this.btnAgregarMarca.CustomAdvSysColorDilution = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAgregarMarca.CustomAresioBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(70)))))};
            this.btnAgregarMarca.CustomAresioDownColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Transparent};
            this.btnAgregarMarca.CustomAresioNoneColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(70))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(40)))))};
            this.btnAgregarMarca.CustomAresioOverColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.Transparent};
            this.btnAgregarMarca.CustomBasicBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.btnAgregarMarca.CustomBasicColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            this.btnAgregarMarca.CustomBasicDisabled = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.btnAgregarMarca.CustomBasicHighlights = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.btnAgregarMarca.CustomBasicOffset = 3;
            this.btnAgregarMarca.CustomBasicStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            this.btnAgregarMarca.CustomBitDefenderBorder = System.Drawing.Color.Black;
            this.btnAgregarMarca.CustomBitDefenderC1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnAgregarMarca.CustomBitDefenderC2 = System.Drawing.Color.White;
            this.btnAgregarMarca.CustomBitDefenderC3 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnAgregarMarca.CustomBitDefenderC4 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAgregarMarca.CustomBitDefenderC5 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAgregarMarca.CustomBitDefenderC6 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAgregarMarca.CustomBitDefenderFadeColor = System.Drawing.Color.White;
            this.btnAgregarMarca.CustomBlackShadesDownColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(38))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(38))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(38))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(31)))), ((int)(((byte)(43))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(65)))), ((int)(((byte)(68))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))))};
            this.btnAgregarMarca.CustomBlackShadesNoneColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(38))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.Transparent,
        System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(31)))), ((int)(((byte)(43))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(65)))), ((int)(((byte)(68))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(103)))), ((int)(((byte)(105))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))))};
            this.btnAgregarMarca.CustomBlackShadesOverColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(38))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.Transparent,
        System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(31)))), ((int)(((byte)(43))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(65)))), ((int)(((byte)(68))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(103)))), ((int)(((byte)(105))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))), ((int)(((byte)(105))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(33))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))))};
            this.btnAgregarMarca.CustomBnWInactiveBorder = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnAgregarMarca.CustomBnWOffsetFill = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))))};
            this.btnAgregarMarca.CustomBnWRounding = 50;
            this.btnAgregarMarca.CustomBoosterColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            this.btnAgregarMarca.CustomBoosterGradientAngle = 270F;
            this.btnAgregarMarca.CustomBoosterHatchColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            this.btnAgregarMarca.CustomBoosterHoverTransparency = 50F;
            this.btnAgregarMarca.CustomBoosterInfluenceOuter = false;
            this.btnAgregarMarca.CustomBoosterInnerBorder = System.Drawing.Color.Black;
            this.btnAgregarMarca.CustomBoosterOffset = 6;
            this.btnAgregarMarca.CustomBoosterOuterBorder = System.Drawing.Color.Black;
            this.btnAgregarMarca.CustomBwOffset = 10;
            this.btnAgregarMarca.CustomClassicBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnAgregarMarca.CustomClassicBorder = System.Drawing.Color.Black;
            this.btnAgregarMarca.CustomClassicColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255))))),
        System.Drawing.Color.Transparent};
            this.btnAgregarMarca.CustomClassicHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnAgregarMarca.CustomClassicShadow = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAgregarMarca.CustomDeumosBackground = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.btnAgregarMarca.CustomDeumosBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.Black};
            this.btnAgregarMarca.CustomDeumosCornerColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.btnAgregarMarca.CustomDeumosDownStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))))};
            this.btnAgregarMarca.CustomDeumosNoneStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.btnAgregarMarca.CustomDeumosOverStateColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAgregarMarca.CustomExcisionBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.White};
            this.btnAgregarMarca.CustomExcisionStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.CustomExcisionStyles.Default;
            this.btnAgregarMarca.CustomFocusScales = ((System.Drawing.PointF)(resources.GetObject("btnAgregarMarca.CustomFocusScales")));
            colorBlend1.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))))};
            colorBlend1.Positions = new float[] {
        0F,
        0.5F,
        1F};
            this.btnAgregarMarca.CustomFusionBlend = colorBlend1;
            this.btnAgregarMarca.CustomFusionCornerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAgregarMarca.CustomFusionDownBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnAgregarMarca.CustomFusionGradColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))))};
            this.btnAgregarMarca.CustomFusionNoneBorderColor = System.Drawing.Color.Black;
            this.btnAgregarMarca.CustomFusionOverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnAgregarMarca.CustomGameBoosterBotGradient = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnAgregarMarca.CustomGameBoosterBotGradientClick = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnAgregarMarca.CustomGameBoosterBotGradientHover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnAgregarMarca.CustomGameBoosterCornerColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAgregarMarca.CustomGameBoosterInnerBorder = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnAgregarMarca.CustomGameBoosterInnerBorderClick = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnAgregarMarca.CustomGameBoosterInnerBorderHover = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnAgregarMarca.CustomGameBoosterOuterBorder = System.Drawing.Color.Black;
            this.btnAgregarMarca.CustomGameBoosterOuterBorderClick = System.Drawing.Color.Black;
            this.btnAgregarMarca.CustomGameBoosterOuterBorderHover = System.Drawing.Color.Black;
            this.btnAgregarMarca.CustomGameBoosterTopGradient = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnAgregarMarca.CustomGameBoosterTopGradientClick = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAgregarMarca.CustomGameBoosterTopGradientHover = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnAgregarMarca.CustomIntelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAgregarMarca.CustomIntelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.btnAgregarMarca.CustomIntelGlow = 100;
            this.btnAgregarMarca.CustomIntelShade = System.Drawing.Color.Black;
            this.btnAgregarMarca.CustomizableAdobeBackground = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnAgregarMarca.CustomizableAdobeBorderOffset = 2;
            this.btnAgregarMarca.CustomizableAdobeCoefficient = 15;
            this.btnAgregarMarca.CustomizableAdobeColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48))))),
        System.Drawing.Color.White,
        System.Drawing.Color.Black};
            this.btnAgregarMarca.CustomizableAdvancedSystemGlow = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(210)))));
            this.btnAgregarMarca.CustomizableAdvancedSystemSlope = 5;
            this.btnAgregarMarca.CustomizableAdvSysBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnAgregarMarca.CustomizableStyle = Zeroit.Framework.ButtonThematic.BaseContainer.CustomizableStyles.Intel;
            this.btnAgregarMarca.Customization = "";
            this.btnAgregarMarca.Customize = new Zeroit.Framework.ButtonThematic.Controls.ButtonInput(System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(128))))), System.Drawing.Color.Black, 20, 100);
            this.btnAgregarMarca.CustomizedBtnActive = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))))};
            this.btnAgregarMarca.CustomizedBtnActiveBorder = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))))};
            this.btnAgregarMarca.CustomizedBtnInactive = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            this.btnAgregarMarca.CustomizedBtnInactiveBorder = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnAgregarMarca.CustomizedBtnOffset = 3;
            this.btnAgregarMarca.CustomizedBtnOffsetBorder = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))))};
            this.btnAgregarMarca.CustomizedBtnOffsetGradient = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))))};
            this.btnAgregarMarca.CustomizedBtnPressed = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))))};
            this.btnAgregarMarca.CustomizedBtnPressedBorder = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))))};
            this.btnAgregarMarca.CustomNamelessBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))),
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.btnAgregarMarca.CustomNamelessCorners = System.Drawing.Color.Black;
            this.btnAgregarMarca.CustomNamelessDownHighlight = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))))};
            this.btnAgregarMarca.CustomNamelessNoneHighlight = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))))};
            this.btnAgregarMarca.CustomNamelessOverHighlight = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))))};
            this.btnAgregarMarca.CustomNetSealCenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAgregarMarca.CustomNetSealPathBorders = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))))};
            this.btnAgregarMarca.CustomNetSealSurroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnAgregarMarca.CustomOrainsButton = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))))};
            this.btnAgregarMarca.CustomOrainsHatch = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Transparent};
            this.btnAgregarMarca.CustomOrainsHeader = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAgregarMarca.CustomOrainsInnerBorder = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAgregarMarca.CustomOrainsOuterBorder = System.Drawing.Color.Black;
            this.btnAgregarMarca.CustomReconBackground = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnAgregarMarca.CustomReconBorder = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))))};
            this.btnAgregarMarca.CustomReconDownStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Transparent};
            this.btnAgregarMarca.CustomReconNoneStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))))};
            this.btnAgregarMarca.CustomReconOverStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))),
        System.Drawing.Color.Transparent};
            this.btnAgregarMarca.CustomRoasterBackgroundStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.Black};
            this.btnAgregarMarca.CustomRoasterBorderColor = System.Drawing.Color.Black;
            this.btnAgregarMarca.CustomRoasterGradientColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))))};
            this.btnAgregarMarca.CustomSpicyBackground = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btnAgregarMarca.CustomSpicyBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.btnAgregarMarca.CustomSpicyCornerColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnAgregarMarca.CustomSpicyDownStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))))};
            this.btnAgregarMarca.CustomSpicyHighlight = System.Drawing.Color.White;
            this.btnAgregarMarca.CustomSpicyNoneStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))))};
            this.btnAgregarMarca.CustomSpicyOverStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))))};
            this.btnAgregarMarca.CustomZeusBackground = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnAgregarMarca.CustomZeusBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.AliceBlue};
            this.btnAgregarMarca.CustomZeusClickLocate = 2;
            this.btnAgregarMarca.CustomZeusClickReduce = 5;
            this.btnAgregarMarca.CustomZeusGradientColors = new System.Drawing.Color[] {
        System.Drawing.Color.AliceBlue,
        System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.btnAgregarMarca.DarkTheme = false;
            this.btnAgregarMarca.DestinyBorder = System.Drawing.Color.Black;
            this.btnAgregarMarca.DestinyG1 = System.Drawing.Color.Teal;
            this.btnAgregarMarca.DestinyG2 = System.Drawing.Color.Black;
            this.btnAgregarMarca.DestinyG3 = System.Drawing.Color.Black;
            this.btnAgregarMarca.DestinyG4 = System.Drawing.Color.Teal;
            this.btnAgregarMarca.DestinyG5 = System.Drawing.Color.Teal;
            this.btnAgregarMarca.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(68)))), ((int)(((byte)(126)))));
            this.btnAgregarMarca.DownLeftCurve = 10;
            this.btnAgregarMarca.DownRightCurve = 10;
            this.btnAgregarMarca.DrawMode = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.RenderMode.Gradient;
            this.btnAgregarMarca.EffectualStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.EffectualStyles.Blue;
            this.btnAgregarMarca.EightBallAnimation = true;
            this.btnAgregarMarca.ElegantBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnAgregarMarca.ElegantBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(190)))), ((int)(((byte)(146)))));
            this.btnAgregarMarca.ElegantPressedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnAgregarMarca.ElementBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.btnAgregarMarca.EmpireButtonStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.EmpireButtonStyles.Normal;
            this.btnAgregarMarca.EnableGlass = true;
            this.btnAgregarMarca.ExcisionStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.ExcisionStyles.Default;
            this.btnAgregarMarca.FlatUIBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnAgregarMarca.FlatUIRounded = false;
            this.btnAgregarMarca.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMarca.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAgregarMarca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarMarca.GameBoosterBotGradient = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnAgregarMarca.GameBoosterBotGradientClick = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnAgregarMarca.GameBoosterBotGradientHover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnAgregarMarca.GameBoosterCornerColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAgregarMarca.GameBoosterInnerBorder = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnAgregarMarca.GameBoosterInnerBorderClick = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnAgregarMarca.GameBoosterInnerBorderHover = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnAgregarMarca.GameBoosterOuterBorder = System.Drawing.Color.Black;
            this.btnAgregarMarca.GameBoosterOuterBorderClick = System.Drawing.Color.Black;
            this.btnAgregarMarca.GameBoosterOuterBorderHover = System.Drawing.Color.Black;
            this.btnAgregarMarca.GameBoosterTopGradient = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnAgregarMarca.GameBoosterTopGradientClick = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAgregarMarca.GameBoosterTopGradientHover = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnAgregarMarca.GradientAngle = 90F;
            this.btnAgregarMarca.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnAgregarMarca.HatchStyle = System.Drawing.Drawing2D.HatchStyle.LightDownwardDiagonal;
            this.btnAgregarMarca.HoverColour = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnAgregarMarca.HuraAccentColor = System.Drawing.Color.Empty;
            this.btnAgregarMarca.HuraBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAgregarMarca.HuraColorScheme = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.HuraColorSchemes.Dark;
            this.btnAgregarMarca.Image = null;
            this.btnAgregarMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarMarca.ImageCodeString = resources.GetString("btnAgregarMarca.ImageCodeString");
            this.btnAgregarMarca.ImageSize = new System.Drawing.Size(0, 0);
            this.btnAgregarMarca.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.btnAgregarMarca.KnightRounded = false;
            this.btnAgregarMarca.Location = new System.Drawing.Point(102, 274);
            this.btnAgregarMarca.LoginMaximum = 100;
            this.btnAgregarMarca.Loginstyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.LoginStyles.Button;
            this.btnAgregarMarca.LoginValue = 0;
            this.btnAgregarMarca.LoyalOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btnAgregarMarca.metrodiskBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnAgregarMarca.MetrodiskRounded = false;
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.NeoBuxStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.NeoBuxStyles.Blue;
            this.btnAgregarMarca.NormalColour = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(199)))));
            this.btnAgregarMarca.NoRounding = false;
            this.btnAgregarMarca.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.None;
            this.btnAgregarMarca.PressedColour = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnAgregarMarca.ProgressColour = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnAgregarMarca.RedemptionStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.RedemptionStyles.Rectangle;
            this.btnAgregarMarca.SharpColor2 = false;
            this.btnAgregarMarca.ShowText = true;
            this.btnAgregarMarca.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(68)))), ((int)(((byte)(126)))));
            this.btnAgregarMarca.SimplaColorScheme = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.SimplaColorSchemes.DarkGray;
            this.btnAgregarMarca.Size = new System.Drawing.Size(200, 78);
            this.btnAgregarMarca.Smoothing = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.btnAgregarMarca.TabIndex = 19;
            this.btnAgregarMarca.TeenAccentColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregarMarca.TeenColorScheme = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.teenColorSchemes.Dark;
            this.btnAgregarMarca.Text = "Agregar Marca";
            this.btnAgregarMarca.TextAlign = System.Drawing.StringAlignment.Center;
            this.btnAgregarMarca.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAgregarMarca.TextRendering = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnAgregarMarca.Theme = Zeroit.Framework.ButtonThematic.BaseContainer.Themes.Customized;
            this.btnAgregarMarca.ThemeStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.ColorTheme.GammaRay;
            this.btnAgregarMarca.ThiefAccentColor = System.Drawing.Color.Empty;
            this.btnAgregarMarca.Transparent = false;
            this.btnAgregarMarca.TwitchRounding = true;
            this.btnAgregarMarca.TwitchStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.TwitchStyles.Default;
            this.btnAgregarMarca.UpperColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(68)))), ((int)(((byte)(126)))));
            this.btnAgregarMarca.UpperLeftCurve = 10;
            this.btnAgregarMarca.UpperRightCurve = 10;
            this.btnAgregarMarca.XVisualShade = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.xVisualInnerShade.Dark;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click_1);
            // 
            // btnEditarMarca
            // 
            this.btnEditarMarca.AdobeAlternate = false;
            this.btnEditarMarca.AdvancedSystemGlow = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(210)))));
            this.btnEditarMarca.AllowClickAnimation = true;
            this.btnEditarMarca.AlphaBorders = new System.Drawing.Color[] {
        System.Drawing.Color.Lime,
        System.Drawing.Color.DimGray};
            this.btnEditarMarca.AngelBackground = System.Drawing.Color.Black;
            this.btnEditarMarca.AngelColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(78)))), ((int)(((byte)(108))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(67))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(143))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.Black};
            this.btnEditarMarca.Anomborder = System.Drawing.Color.Black;
            this.btnEditarMarca.AnombuttonBottom = System.Drawing.Color.Gainsboro;
            this.btnEditarMarca.AnombuttonTop = System.Drawing.Color.Beige;
            this.btnEditarMarca.AnomDown = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))))};
            this.btnEditarMarca.AnomHatchColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.Transparent};
            this.btnEditarMarca.AnomNone = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))))};
            this.btnEditarMarca.ArcColour = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnEditarMarca.ArrowBorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.btnEditarMarca.ArrowColour = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.btnEditarMarca.AryanBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))))};
            this.btnEditarMarca.AryanDownstateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))))};
            this.btnEditarMarca.AryanNonestateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))))};
            this.btnEditarMarca.AryanOverstateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))))};
            this.btnEditarMarca.AvatarBorder = System.Drawing.Color.Black;
            this.btnEditarMarca.AvatarButtonColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnEditarMarca.AvatarButtonColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnEditarMarca.AvatarStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            this.btnEditarMarca.Avgbackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(143)))), ((int)(((byte)(124)))));
            this.btnEditarMarca.AvgBorder = System.Drawing.Color.Transparent;
            this.btnEditarMarca.Background = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnEditarMarca.BackgroundColour = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(98)))), ((int)(((byte)(158)))));
            this.btnEditarMarca.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnEditarMarca.BasicBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.btnEditarMarca.BasicColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            this.btnEditarMarca.BasicDisabled = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.btnEditarMarca.BasicHighlights = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.btnEditarMarca.BasicStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            this.btnEditarMarca.BetaBlueDark = false;
            this.btnEditarMarca.BeyondDrawMode = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.BeyondDrawStyle.Basic;
            this.btnEditarMarca.BloodyBorder = System.Drawing.Color.Black;
            this.btnEditarMarca.BloodyButtonColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditarMarca.BlueC1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(123)))), ((int)(((byte)(173)))));
            this.btnEditarMarca.BlueC2 = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(106)))), ((int)(((byte)(163)))));
            this.btnEditarMarca.BorderButtonStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.BorderButtonStyles.Full;
            this.btnEditarMarca.BorderButtonSubText = null;
            this.btnEditarMarca.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnEditarMarca.BorderSize = 1;
            this.btnEditarMarca.BullionImage = null;
            this.btnEditarMarca.ClickMaxOffset = 10;
            this.btnEditarMarca.ClickOffset = 1;
            this.btnEditarMarca.ClickSpeed = 1;
            this.btnEditarMarca.ClsStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.ClsStyles.Blue;
            this.btnEditarMarca.Color = System.Drawing.Color.Empty;
            this.btnEditarMarca.Colors = new Zeroit.Framework.ButtonThematic.ThemeManagers.Bloom[0];
            this.btnEditarMarca.Curve = 20;
            this.btnEditarMarca.CustomAdvantiumBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEditarMarca.CustomAdvantiumBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))))};
            this.btnEditarMarca.CustomAdvantiumDownColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))))};
            this.btnEditarMarca.CustomAdvantiumNoneColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))))};
            this.btnEditarMarca.CustomAdvantiumOffsets = new int[] {
        1,
        0,
        0};
            this.btnEditarMarca.CustomAdvantiumOverColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))))};
            this.btnEditarMarca.CustomAdvSysColorDilution = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditarMarca.CustomAresioBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(70)))))};
            this.btnEditarMarca.CustomAresioDownColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Transparent};
            this.btnEditarMarca.CustomAresioNoneColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(70))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(40)))))};
            this.btnEditarMarca.CustomAresioOverColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.Transparent};
            this.btnEditarMarca.CustomBasicBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.btnEditarMarca.CustomBasicColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            this.btnEditarMarca.CustomBasicDisabled = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.btnEditarMarca.CustomBasicHighlights = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.btnEditarMarca.CustomBasicOffset = 3;
            this.btnEditarMarca.CustomBasicStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            this.btnEditarMarca.CustomBitDefenderBorder = System.Drawing.Color.Black;
            this.btnEditarMarca.CustomBitDefenderC1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnEditarMarca.CustomBitDefenderC2 = System.Drawing.Color.White;
            this.btnEditarMarca.CustomBitDefenderC3 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnEditarMarca.CustomBitDefenderC4 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnEditarMarca.CustomBitDefenderC5 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnEditarMarca.CustomBitDefenderC6 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnEditarMarca.CustomBitDefenderFadeColor = System.Drawing.Color.White;
            this.btnEditarMarca.CustomBlackShadesDownColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(38))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(38))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(38))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(31)))), ((int)(((byte)(43))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(65)))), ((int)(((byte)(68))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))))};
            this.btnEditarMarca.CustomBlackShadesNoneColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(38))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.Transparent,
        System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(31)))), ((int)(((byte)(43))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(65)))), ((int)(((byte)(68))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(103)))), ((int)(((byte)(105))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))))};
            this.btnEditarMarca.CustomBlackShadesOverColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(38))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.Transparent,
        System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(31)))), ((int)(((byte)(43))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(65)))), ((int)(((byte)(68))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(103)))), ((int)(((byte)(105))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))), ((int)(((byte)(105))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(33))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))))};
            this.btnEditarMarca.CustomBnWInactiveBorder = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnEditarMarca.CustomBnWOffsetFill = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))))};
            this.btnEditarMarca.CustomBnWRounding = 50;
            this.btnEditarMarca.CustomBoosterColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            this.btnEditarMarca.CustomBoosterGradientAngle = 270F;
            this.btnEditarMarca.CustomBoosterHatchColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            this.btnEditarMarca.CustomBoosterHoverTransparency = 50F;
            this.btnEditarMarca.CustomBoosterInfluenceOuter = false;
            this.btnEditarMarca.CustomBoosterInnerBorder = System.Drawing.Color.Black;
            this.btnEditarMarca.CustomBoosterOffset = 6;
            this.btnEditarMarca.CustomBoosterOuterBorder = System.Drawing.Color.Black;
            this.btnEditarMarca.CustomBwOffset = 10;
            this.btnEditarMarca.CustomClassicBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnEditarMarca.CustomClassicBorder = System.Drawing.Color.Black;
            this.btnEditarMarca.CustomClassicColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255))))),
        System.Drawing.Color.Transparent};
            this.btnEditarMarca.CustomClassicHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnEditarMarca.CustomClassicShadow = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditarMarca.CustomDeumosBackground = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.btnEditarMarca.CustomDeumosBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.Black};
            this.btnEditarMarca.CustomDeumosCornerColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.btnEditarMarca.CustomDeumosDownStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))))};
            this.btnEditarMarca.CustomDeumosNoneStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.btnEditarMarca.CustomDeumosOverStateColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEditarMarca.CustomExcisionBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.White};
            this.btnEditarMarca.CustomExcisionStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.CustomExcisionStyles.Default;
            this.btnEditarMarca.CustomFocusScales = ((System.Drawing.PointF)(resources.GetObject("btnEditarMarca.CustomFocusScales")));
            colorBlend2.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))))};
            colorBlend2.Positions = new float[] {
        0F,
        0.5F,
        1F};
            this.btnEditarMarca.CustomFusionBlend = colorBlend2;
            this.btnEditarMarca.CustomFusionCornerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEditarMarca.CustomFusionDownBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnEditarMarca.CustomFusionGradColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))))};
            this.btnEditarMarca.CustomFusionNoneBorderColor = System.Drawing.Color.Black;
            this.btnEditarMarca.CustomFusionOverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnEditarMarca.CustomGameBoosterBotGradient = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnEditarMarca.CustomGameBoosterBotGradientClick = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnEditarMarca.CustomGameBoosterBotGradientHover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnEditarMarca.CustomGameBoosterCornerColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnEditarMarca.CustomGameBoosterInnerBorder = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnEditarMarca.CustomGameBoosterInnerBorderClick = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnEditarMarca.CustomGameBoosterInnerBorderHover = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnEditarMarca.CustomGameBoosterOuterBorder = System.Drawing.Color.Black;
            this.btnEditarMarca.CustomGameBoosterOuterBorderClick = System.Drawing.Color.Black;
            this.btnEditarMarca.CustomGameBoosterOuterBorderHover = System.Drawing.Color.Black;
            this.btnEditarMarca.CustomGameBoosterTopGradient = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnEditarMarca.CustomGameBoosterTopGradientClick = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnEditarMarca.CustomGameBoosterTopGradientHover = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnEditarMarca.CustomIntelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEditarMarca.CustomIntelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.btnEditarMarca.CustomIntelGlow = 100;
            this.btnEditarMarca.CustomIntelShade = System.Drawing.Color.Black;
            this.btnEditarMarca.CustomizableAdobeBackground = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnEditarMarca.CustomizableAdobeBorderOffset = 2;
            this.btnEditarMarca.CustomizableAdobeCoefficient = 15;
            this.btnEditarMarca.CustomizableAdobeColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48))))),
        System.Drawing.Color.White,
        System.Drawing.Color.Black};
            this.btnEditarMarca.CustomizableAdvancedSystemGlow = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(210)))));
            this.btnEditarMarca.CustomizableAdvancedSystemSlope = 5;
            this.btnEditarMarca.CustomizableAdvSysBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnEditarMarca.CustomizableStyle = Zeroit.Framework.ButtonThematic.BaseContainer.CustomizableStyles.Intel;
            this.btnEditarMarca.Customization = "";
            this.btnEditarMarca.Customize = new Zeroit.Framework.ButtonThematic.Controls.ButtonInput(System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(128))))), System.Drawing.Color.Black, 20, 100);
            this.btnEditarMarca.CustomizedBtnActive = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))))};
            this.btnEditarMarca.CustomizedBtnActiveBorder = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))))};
            this.btnEditarMarca.CustomizedBtnInactive = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            this.btnEditarMarca.CustomizedBtnInactiveBorder = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnEditarMarca.CustomizedBtnOffset = 3;
            this.btnEditarMarca.CustomizedBtnOffsetBorder = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))))};
            this.btnEditarMarca.CustomizedBtnOffsetGradient = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))))};
            this.btnEditarMarca.CustomizedBtnPressed = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))))};
            this.btnEditarMarca.CustomizedBtnPressedBorder = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))))};
            this.btnEditarMarca.CustomNamelessBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))),
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.btnEditarMarca.CustomNamelessCorners = System.Drawing.Color.Black;
            this.btnEditarMarca.CustomNamelessDownHighlight = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))))};
            this.btnEditarMarca.CustomNamelessNoneHighlight = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))))};
            this.btnEditarMarca.CustomNamelessOverHighlight = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))))};
            this.btnEditarMarca.CustomNetSealCenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnEditarMarca.CustomNetSealPathBorders = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))))};
            this.btnEditarMarca.CustomNetSealSurroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnEditarMarca.CustomOrainsButton = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))))};
            this.btnEditarMarca.CustomOrainsHatch = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Transparent};
            this.btnEditarMarca.CustomOrainsHeader = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEditarMarca.CustomOrainsInnerBorder = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEditarMarca.CustomOrainsOuterBorder = System.Drawing.Color.Black;
            this.btnEditarMarca.CustomReconBackground = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnEditarMarca.CustomReconBorder = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))))};
            this.btnEditarMarca.CustomReconDownStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Transparent};
            this.btnEditarMarca.CustomReconNoneStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))))};
            this.btnEditarMarca.CustomReconOverStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))),
        System.Drawing.Color.Transparent};
            this.btnEditarMarca.CustomRoasterBackgroundStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.Black};
            this.btnEditarMarca.CustomRoasterBorderColor = System.Drawing.Color.Black;
            this.btnEditarMarca.CustomRoasterGradientColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))))};
            this.btnEditarMarca.CustomSpicyBackground = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btnEditarMarca.CustomSpicyBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.btnEditarMarca.CustomSpicyCornerColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnEditarMarca.CustomSpicyDownStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))))};
            this.btnEditarMarca.CustomSpicyHighlight = System.Drawing.Color.White;
            this.btnEditarMarca.CustomSpicyNoneStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))))};
            this.btnEditarMarca.CustomSpicyOverStateColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))))};
            this.btnEditarMarca.CustomZeusBackground = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnEditarMarca.CustomZeusBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.AliceBlue};
            this.btnEditarMarca.CustomZeusClickLocate = 2;
            this.btnEditarMarca.CustomZeusClickReduce = 5;
            this.btnEditarMarca.CustomZeusGradientColors = new System.Drawing.Color[] {
        System.Drawing.Color.AliceBlue,
        System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.btnEditarMarca.DarkTheme = false;
            this.btnEditarMarca.DestinyBorder = System.Drawing.Color.Black;
            this.btnEditarMarca.DestinyG1 = System.Drawing.Color.Teal;
            this.btnEditarMarca.DestinyG2 = System.Drawing.Color.Black;
            this.btnEditarMarca.DestinyG3 = System.Drawing.Color.Black;
            this.btnEditarMarca.DestinyG4 = System.Drawing.Color.Teal;
            this.btnEditarMarca.DestinyG5 = System.Drawing.Color.Teal;
            this.btnEditarMarca.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(68)))), ((int)(((byte)(126)))));
            this.btnEditarMarca.DownLeftCurve = 10;
            this.btnEditarMarca.DownRightCurve = 10;
            this.btnEditarMarca.DrawMode = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.RenderMode.Gradient;
            this.btnEditarMarca.EffectualStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.EffectualStyles.Blue;
            this.btnEditarMarca.EightBallAnimation = true;
            this.btnEditarMarca.ElegantBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnEditarMarca.ElegantBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(190)))), ((int)(((byte)(146)))));
            this.btnEditarMarca.ElegantPressedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnEditarMarca.ElementBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.btnEditarMarca.EmpireButtonStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.EmpireButtonStyles.Normal;
            this.btnEditarMarca.EnableGlass = true;
            this.btnEditarMarca.ExcisionStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.ExcisionStyles.Default;
            this.btnEditarMarca.FlatUIBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnEditarMarca.FlatUIRounded = false;
            this.btnEditarMarca.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarMarca.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEditarMarca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarMarca.GameBoosterBotGradient = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnEditarMarca.GameBoosterBotGradientClick = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnEditarMarca.GameBoosterBotGradientHover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnEditarMarca.GameBoosterCornerColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnEditarMarca.GameBoosterInnerBorder = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnEditarMarca.GameBoosterInnerBorderClick = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnEditarMarca.GameBoosterInnerBorderHover = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnEditarMarca.GameBoosterOuterBorder = System.Drawing.Color.Black;
            this.btnEditarMarca.GameBoosterOuterBorderClick = System.Drawing.Color.Black;
            this.btnEditarMarca.GameBoosterOuterBorderHover = System.Drawing.Color.Black;
            this.btnEditarMarca.GameBoosterTopGradient = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnEditarMarca.GameBoosterTopGradientClick = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnEditarMarca.GameBoosterTopGradientHover = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnEditarMarca.GradientAngle = 90F;
            this.btnEditarMarca.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnEditarMarca.HatchStyle = System.Drawing.Drawing2D.HatchStyle.LightDownwardDiagonal;
            this.btnEditarMarca.HoverColour = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnEditarMarca.HuraAccentColor = System.Drawing.Color.Empty;
            this.btnEditarMarca.HuraBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEditarMarca.HuraColorScheme = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.HuraColorSchemes.Dark;
            this.btnEditarMarca.Image = null;
            this.btnEditarMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditarMarca.ImageCodeString = resources.GetString("btnEditarMarca.ImageCodeString");
            this.btnEditarMarca.ImageSize = new System.Drawing.Size(0, 0);
            this.btnEditarMarca.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.btnEditarMarca.KnightRounded = false;
            this.btnEditarMarca.Location = new System.Drawing.Point(344, 274);
            this.btnEditarMarca.LoginMaximum = 100;
            this.btnEditarMarca.Loginstyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.LoginStyles.Button;
            this.btnEditarMarca.LoginValue = 0;
            this.btnEditarMarca.LoyalOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btnEditarMarca.metrodiskBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnEditarMarca.MetrodiskRounded = false;
            this.btnEditarMarca.Name = "btnEditarMarca";
            this.btnEditarMarca.NeoBuxStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.NeoBuxStyles.Blue;
            this.btnEditarMarca.NormalColour = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(199)))));
            this.btnEditarMarca.NoRounding = false;
            this.btnEditarMarca.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.None;
            this.btnEditarMarca.PressedColour = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnEditarMarca.ProgressColour = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnEditarMarca.RedemptionStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.RedemptionStyles.Rectangle;
            this.btnEditarMarca.SharpColor2 = false;
            this.btnEditarMarca.ShowText = true;
            this.btnEditarMarca.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(68)))), ((int)(((byte)(126)))));
            this.btnEditarMarca.SimplaColorScheme = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.SimplaColorSchemes.DarkGray;
            this.btnEditarMarca.Size = new System.Drawing.Size(200, 78);
            this.btnEditarMarca.Smoothing = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.btnEditarMarca.TabIndex = 20;
            this.btnEditarMarca.TeenAccentColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarMarca.TeenColorScheme = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.teenColorSchemes.Dark;
            this.btnEditarMarca.Text = "Editar Marca";
            this.btnEditarMarca.TextAlign = System.Drawing.StringAlignment.Center;
            this.btnEditarMarca.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnEditarMarca.TextRendering = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnEditarMarca.Theme = Zeroit.Framework.ButtonThematic.BaseContainer.Themes.Customized;
            this.btnEditarMarca.ThemeStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.ColorTheme.GammaRay;
            this.btnEditarMarca.ThiefAccentColor = System.Drawing.Color.Empty;
            this.btnEditarMarca.Transparent = false;
            this.btnEditarMarca.TwitchRounding = true;
            this.btnEditarMarca.TwitchStyle = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.TwitchStyles.Default;
            this.btnEditarMarca.UpperColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(68)))), ((int)(((byte)(126)))));
            this.btnEditarMarca.UpperLeftCurve = 10;
            this.btnEditarMarca.UpperRightCurve = 10;
            this.btnEditarMarca.XVisualShade = Zeroit.Framework.ButtonThematic.Controls.ButtonThematic.xVisualInnerShade.Dark;
            this.btnEditarMarca.Click += new System.EventHandler(this.btnEditarMarca_Click);
            // 
            // Marca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(849, 491);
            this.Controls.Add(this.btnEditarMarca);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Zeroit.Framework.ButtonThematic.Controls.ButtonThematic btnAgregarMarca;
        private Zeroit.Framework.ButtonThematic.Controls.ButtonThematic btnEditarMarca;
    }
}