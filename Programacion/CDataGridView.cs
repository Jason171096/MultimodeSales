using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultimodeSales.Programacion
{
    class CDataGridView
    {
        public void FormattingDataGridView(DataGridView dataGrid)
        {
            dataGrid.GridColor = Color.DarkSlateBlue;
            dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue;
            dataGrid.RowsDefaultCellStyle.BackColor = Color.Indigo;
            dataGrid.RowsDefaultCellStyle.SelectionBackColor = Color.MidnightBlue;
        }
    }
}
