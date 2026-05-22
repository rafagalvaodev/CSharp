using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codigo
{
    public class Calculadora
    {
        private List<string> Historico;

        public Calculadora()
        {
            Historico = new List<string>();
        }
        public int Somar(int num1, int num2 )
        {
            int resultado = num1 + num2;
            Historico.Insert(0 , "Resp " + Convert.ToString(resultado));
            return resultado;
        } 

        public int Subtrair(int num1, int num2 )
        {   
            int resultado = num1 - num2; 
            Historico.Insert(0 , "Resp" + Convert.ToString(resultado));
            return resultado;
        }

        public int Dividir(int num1, int num2 )
        {
            
            if(num1 == 0 || num2 == 0)
            {
                Console.WriteLine("A divisão por zero é impossível");
            }
            int resultado = num1 / num2;
            Historico.Insert(0 , "Resp" + Convert.ToString(resultado));
            return resultado;

        }

        public int Mutiplicar(int num1, int num2 )
        {
            int resultado = num1 * num2;
            Historico.Insert(0 , "Resp" + Convert.ToString(resultado));
            return resultado;
        }

        public List<string> ListaHistorico()
        {
            
            Historico.RemoveRange(3, Historico.Count-3); 
            return Historico ;
        }

    }
}