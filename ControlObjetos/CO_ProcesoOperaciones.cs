using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConceptosIniciales.ControlObjetos
{
    class CO_ProcesoOperaciones
    {
        public void bloquearObj(TextBox txt1, TextBox txt2, TextBox txt3)
        {
            txt1.Enabled = true;
            txt2.Enabled = true;
            txt3.Enabled = false;
        }
    }
}
