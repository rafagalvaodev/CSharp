using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialReculsivo
{
    internal class Factorial
    {
        public int calculaFatorial(int numero)
        {   
           
            if(numero <= 0)
            {
                return 1; 
            }
            return numero * calculaFatorial(numero - 1);
        } 
    }
}
