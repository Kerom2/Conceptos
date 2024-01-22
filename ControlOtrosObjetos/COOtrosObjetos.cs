using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConceptosIniciales.ControlOtrosObjetos
{
    class COOtrosObjetos
    {
        public void bloquearotrosObj(TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4)
        {
            txt1.Enabled = true;
            txt2.Enabled = true;
            txt3.Enabled = true;
            txt4.Enabled = false;
        }

        public void limpiarotrosObj(TextBox txt1, TextBox txt2, TextBox txt3)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
        }

        public void agregar(DataGridView tabla, TextBox txt1, TextBox txt2, TextBox txt3)
        {
            if ((txt1.Text == "") || (txt2.Text == "") || (txt3.Text == ""))
            {
                MessageBox.Show("Faltan datos", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //añade una linea a la tabla dandole al boton agregar
                tabla.Rows.Add(txt1.Text, txt2.Text, txt3.Text);
            }
        }

        public void Totalizar(DataGridView tabla, TextBox texto)
        {
            double total = 0;//acumula los totales}
            // asigna a la variable itotal la acantidad de lineas del grid
            int iTotal = tabla.Rows.Count;

            //cuclo para cirrer el grid, ke restamnis -1  Itotal, porque en esa variabl 
            //está la canridad de lineas del grid y el ciclo inicia a partir de 0
            for (int i = 0; i <= iTotal - 1; i++)
            {
                //aqui va acumulando en la variable total la fila que vale i,
                //la columna (cells)2, porque las columnas 0estan a partir de la 0
                total += Convert.ToDouble(tabla.Rows[i].Cells[2].Value);
            }
            //asigna al campotexto la variable total que es la qe tiene el acumulado de los montos,
            //con el formato de colones, miles y 2 decimales
            texto.Text = String.Format("{0:¢#.##}", total);
        }
            

        public void eliminar(DataGridView tabla, TextBox texto)
        {
            //variable local para que el usuario brinde una respuesta en una ventana o cuadro de dialogo
            DialogResult respuesta;

            //la propiedad rowCount, devuelve la cantidad de filas deñ grid
            if (tabla.RowCount >= 1)
            {
                respuesta = MessageBox.Show("¿esta segure de eliminar la linea?",
                    "advertencia", MessageBoxButtons.YesNo);
                //si la respuest afue positiva, entonces ahi debe de eliminar la linea del grid
                if (respuesta == DialogResult.Yes)
                {
                    //aqui eliminar de ka tabla la fila seleccionada por el usuario y la propiedad index 
                    //es la que devuelve el numero de la fila correspondiente
                    tabla.Rows.RemoveAt(tabla.CurrentRow.Index);
                    Totalizar(tabla, texto);

                    MessageBox.Show("linea ah sido eliminada", "informacion", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("linea no fue eliminada", "advertencia", MessageBoxButtons.OK);
                }
            }
        }
    }//final
}
