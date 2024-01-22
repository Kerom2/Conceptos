using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConceptosIniciales.ControlOtrosObjetos;

namespace ConceptosIniciales.VistaOtrosObjetos
{

    public partial class Facturador : Form
    {
        COOtrosObjetos co = new COOtrosObjetos();
        public Facturador()
        {
            InitializeComponent();
            co.bloquearotrosObj(textBox1, textBox2, textBox3, textBox4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            co.agregar(dataGridView1, textBox1, textBox2, textBox3);
            co.Totalizar(dataGridView1, textBox4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            co.limpiarotrosObj(textBox1, textBox2, textBox3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            co.eliminar(dataGridView1, textBox4);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //define posi y le asigna la cantidad de filas del grid
            int posi = dataGridView1.Rows.Count;

            if (posi != 0)
            {
                //asugna a cadad campo texto el contenido de cada columna (cells) en cada una de ass filas
                //de la tabla , convertido a String porque lo va a asignar a un campo texto
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            }
            else
            {
                MessageBox.Show("no hay datos en el grid", "advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
