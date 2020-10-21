using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultimodeSales.Programacion
{
    class FormatoPrecio
    {
        public string SimbolodePeso(string value)
        {
            return string.Format("{0:C}", value);
        }
    }
}
