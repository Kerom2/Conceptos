using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosIniciales.ControlCiclos
{
    class ProcesoCislos
    {
        //funcion que recibe un nuemnero enteri y devuelve el factorial del numero
        public int factorial(int n)
        {
            int resul = 1;
            if ((n == 0) || (n == 1))
            {
                resul = 1;
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    resul *= i;

                }
            }
            return resul;
        }
    }
}
