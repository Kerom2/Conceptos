using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConceptosIniciales.ControlNum
{
    class procesoNum
    {
        public int menor(int n1, int n2, int n3)
        {
            if ((n1 <n2 )&& ( n1 < n3)){
                return n1;
            }else
                if ((n2 < n1) && (n2 < n3))
            {
                return n2;
            }else 
                if ((n3 < n1) && (n3 < n2))
            {
                return n3;
            } else
            {
                return 0;
            }
        }
    }
}
