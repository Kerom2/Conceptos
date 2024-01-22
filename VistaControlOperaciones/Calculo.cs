using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConceptosIniciales.ControlOperaciones;
using ConceptosIniciales.ControlObjetos;
using ConceptosIniciales.VistaPrincipal;



namespace ConceptosIniciales.VistaControlOperaciones
{
    public partial class Calculo : Form    
    {
        CO_ProcesoOperaciones co = new CO_ProcesoOperaciones();
        ProcesOperaciones cop = new ProcesOperaciones();

        //define variables globales
        int num1, num2;

        public Calculo()
        {
            InitializeComponent();
            co.bloquearObj(textBox1,textBox2,textBox3);
        }

        public void conv_Num()
        {
            num1 = Convert.ToInt16(textBox1.Text);
            num2 = Convert.ToInt16(textBox2.Text);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calculo_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                MessageBox.Show("Faltan datos por completar", "Resultado");
                textBox1.Focus();
            }
            else
            {
                conv_Num();
                textBox3.Text = "" + cop.resta(num1, num2);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MenuP f = new MenuP();
            f.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";


        }

        private void button3_Click(object sender, EventArgs e)
        {

            if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                MessageBox.Show("Faltan datos por completar", "Resultado");
                textBox1.Focus();
            }
            else
            {
                conv_Num();
                textBox3.Text = "" + cop.mult(num1, num2);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                MessageBox.Show("Faltan datos por completar", "Resultado");
                textBox1.Focus();
            }
            else
            {
                conv_Num();
                textBox3.Text = "" + cop.div(num1, num2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                MessageBox.Show("Faltan datos por completar", "Resultado");
                textBox1.Focus();
            }
            else
            {
                conv_Num();
                textBox3.Text = "" + cop.suma(num1, num2);
            }
        }
    }
}
