using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace MultimodeSales.Programacion.Utilerias
{
    public static class CRoundButton
    {
        public static void FormattedRoundButton(RoundButton.RoundButton button)
        {
            button.BackColor = Color.Transparent;
            button.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            button.FlatStyle = FlatStyle.Flat;
            button.BorderColor = Color.DarkBlue;
            button.ButtonColor = Color.Indigo;
            button.OnHoverBorderColor = Color.Indigo;
            button.OnHoverButtonColor = Color.DarkOrchid;
            button.OnHoverTextColor = Color.GhostWhite;
            button.TextColor = Color.GhostWhite;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button.Cursor = Cursors.Hand;
        }
    }
}
