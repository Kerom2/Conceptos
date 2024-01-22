using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ConceptosIniciales.ControlObjetos
{
    class CO_ProcesoNumeros
    {
        public void procesoNum(TextBox texto1)
        {
            texto1.Enabled = false;
        }

        public void limpiar (TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4)
        {
            txt1.Text = " ";
            txt2.Text = " ";
            txt3.Text = " ";
            txt4.Text = " ";
        }
    }
}
