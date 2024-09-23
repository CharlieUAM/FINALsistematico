using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace ExamenFinal.clases
{
    internal class operaciones
    {
        public int calcedad(int i )
        {
            int edad1 = 0;
            edad1 = i - DateTime.Now.Year;
            return edad1;

        }
    }
}
