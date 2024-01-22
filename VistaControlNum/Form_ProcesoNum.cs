using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConceptosIniciales.ControlObjetos;
using ConceptosIniciales.ControlNum;
using ConceptosIniciales.VistaPrincipal;

namespace ConceptosIniciales.VistaControlNum

{

    public partial class Form_ProcesoNum : Form
    { CO_ProcesoNumeros co = new CO_ProcesoNumeros();
        procesoNum pn = new procesoNum();
        //definicion de variables globales de la clase
        int n1, n2, n3;
        public Form_ProcesoNum()
        {
            InitializeComponent();
            co.procesoNum(textBox4);
        }

        //bptpn limpiar
        private void button2_Click(object sender, EventArgs e)
        {
            co.limpiar(textBox1, textBox2, textBox3, textBox4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuP f = new MenuP();
            f.Show();
            this.Hide();
        }

        public void procesonum()
        {
            n1 = Convert.ToInt16(textBox1.Text);
            n2 = Convert.ToInt16(textBox2.Text);
            n3 = Convert.ToInt16(textBox3.Text);
        }

        //boton evaluar
        private void button1_Click(object sender, EventArgs e)
        {
            procesonum();
            //asigna al campo texto el elemento menor que determina con la funcion menor
            textBox4.Text = Convert.ToString(pn.menor(n1,n2,n3));

            //imprime en la ventana de message box el mensaje indicado
            MessageBox.Show("Elemento menor es: " + pn.menor(n1, n2, n3));
        }
    }
}
