using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelDIO.models
{
    public class Reserva
    {

        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(){}

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospede)
        {
          
           if (Suite.Capacidade == hospede.Count())
           {
                Hospedes = hospede;
           }else
           {
                throw new Exception("A capacidade é menor que o número de hóspedes recebido.");
           }
        }

        public void CadastrarSuites(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospede()
        {
            int valor = Hospedes.Count();
            return valor;       
        }

        public decimal CalcularValorDiaria()
        {
            decimal valorTotal = 0;

            valorTotal += DiasReservados * Suite.ValorDiaria;      
            if(DiasReservados >= 10)
            {
                decimal dezpor = valorTotal * 0.10m; 
                valorTotal -=  dezpor;
            }

            return valorTotal;
        } 



    }
}