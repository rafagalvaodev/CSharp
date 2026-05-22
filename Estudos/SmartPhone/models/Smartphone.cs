using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartPhone.models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected int Memoria { get; set; }
        
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void ligar()
        {
            Console.WriteLine("Ligando");
        } 
        public void ligar(string numero)
        {
            Console.WriteLine($"Ligando para {numero}");
        } 
        public void RecebendoLigação()
        {
            Console.WriteLine("Recebendo ligação");
        }
        public void RecebendoLigação(string numero)
        {
            Console.WriteLine($"Recebendo ligação do número {numero}");
        }

        public abstract void InstalarAplicativo(string aplicativo);
    }
}