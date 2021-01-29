using MultimodeSales.Programacion;
using MultimodeSales.Programacion.Folios;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace MultimodeSales.Vistas
{
    public partial class Folio : Form
    {
        CFolio cFolio = new CFolio();
        private int MX;
        private int MY;
        public Folio(bool pFolio)
        {
            InitializeComponent();
            CDataGridView.FormattedDataGridView(dgvFolio);
            Region = Region.FromHrgn(CFormBorder.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            if(pFolio)
            {
                lbFolio.Text = "Folios Ventas";
                cargarFoliosVentas();
            }
            else
            {
                lbFolio.Text = "Folios Devoluciones";
            }
        }

        private void cargarFoliosVentas()
        {
            dgvFolio.DataSource = null;
            DataTable dtVentas = cFolio.verFoliosVentas();
            dgvFolio.DataSource = dtVentas;
            DarFormatoTabla();
        }

        private void DarFormatoTabla()
        {
            dgvFolio.Columns[0].Visible = false;//IDVenta
            dgvFolio.Columns[1].HeaderText = "ID Folio";//IDFolio
            dgvFolio.Columns[1].Width = 100;
            dgvFolio.Columns[2].HeaderText = "ID Cliente";//IDCliente
            dgvFolio.Columns[2].Width = 100;
            dgvFolio.Columns[3].Width = 300;//Fecha
            dgvFolio.Columns[4].Width = 200;//Total
        }

        #region Barra Superior
        private void picMinimize_Click(object sender, System.EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void picClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        private void panelBarras_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }

        private void lbFolio_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }
        private new void MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                MX = e.X;
                MY = e.Y;
            }
            else
            {
                Left = Left + (e.X - MX);
                Top = Top + (e.Y - MY);
            }
        }
        #endregion
    }
}
