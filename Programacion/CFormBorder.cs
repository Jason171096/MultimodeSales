using System;
using System.Runtime.InteropServices;

namespace MultimodeSales.Programacion
{
    class CFormBorder
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern  IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        //Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
    }
}
