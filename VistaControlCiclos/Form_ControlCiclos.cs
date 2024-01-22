using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConceptosIniciales.ControlCiclos;
using ConceptosIniciales.VistaPrincipal;

namespace ConceptosIniciales.VistaControlCiclos
{
    public partial class Form_ControlCiclos : Form
    {
        ProcesoCislos pc = new ProcesoCislos();
        int num;

        public void convertirnum()
        {
            num = Convert.ToInt16(textBox1.Text); 
        }
        public Form_ControlCiclos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //boton evaluar
        private void button1_Click(object sender, EventArgs e)
        {

             if (textBox1.Text == "")
            {
                MessageBox.Show("faltan datos por completar", "resultado");
            }
            else
            {
                convertirnum();
                textBox2.Text = "" + pc.factorial(num);
            }
        }
        //boton limpiar
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuP f = new MenuP();
            f.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
