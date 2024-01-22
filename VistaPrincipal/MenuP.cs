using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConceptosIniciales.VistaControlOperaciones;
using ConceptosIniciales.VistaControlNum;
using ConceptosIniciales.VistaControlCiclos;

namespace ConceptosIniciales.VistaPrincipal
{
    public partial class MenuP : Form
    {
        public MenuP()
        {
            InitializeComponent();
        }

        private void MenuP_Load(object sender, EventArgs e)
        {

        }

        private void controlNumeroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void facturadorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        //opcoion proceso numeros
        private void procesoNumerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ProcesoNum f = new Form_ProcesoNum();
            f.Show();
            this.Hide();
        }

        private void procesoOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculo f = new Calculo ();
            f.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void facturadorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           

        }

        private void kjjkToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void procesoFactorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ControlCiclos f = new Form_ControlCiclos();
            f.Show();
            this.Hide();
        }
    }
}
