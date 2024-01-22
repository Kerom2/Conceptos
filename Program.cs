using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConceptosIniciales.VistaControlNum;
using ConceptosIniciales.VistaControlOperaciones;
using ConceptosIniciales.VistaOtrosObjetos;
using ConceptosIniciales.VistaPrincipal;

namespace ConceptosIniciales
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuP());
        }
    }
}
