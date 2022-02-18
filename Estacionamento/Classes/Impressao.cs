using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;

namespace Estacionamento.Classes
{
    public class Impressao
    {
        public void Recibo(string placa, int numeroVaga, DateTime dataHoraEntrada, DateTime? dataHoraSaida)
        {
            string nomeArquivo = "Recibo_" + numeroVaga + ".txt";
            StreamWriter sw = new StreamWriter(nomeArquivo);
            if (dataHoraSaida == null)
                sw.WriteLine("  *** Recibo de entrada ***  ");
            else
                sw.WriteLine("   *** Recibo de saida ***   ");

            sw.WriteLine("-----------------------------");
            sw.WriteLine("  Placa: " + placa);
            sw.WriteLine("   Vaga: " + numeroVaga);
            sw.WriteLine("Entrada: " + dataHoraEntrada.ToString());
            if (dataHoraSaida != null)
            {
                sw.WriteLine("  Saida: " + dataHoraSaida.ToString());
                TimeSpan ts;
                ts = DateTime.Parse(dataHoraSaida.ToString()) - dataHoraEntrada;
                int minutos = ts.Minutes;                                    

                decimal valorMinuto = 0;
                decimal.TryParse(ConfigurationManager.AppSettings["ValorMinuto"].ToString(), out valorMinuto);
                decimal valorPagar = minutos * valorMinuto;

                sw.WriteLine("-----------------------------");
                sw.WriteLine("Total de minutos: " + minutos);
                sw.WriteLine(" Valor do minuto: " + valorMinuto);
                sw.WriteLine("   Valor a pagar: " + valorPagar);
            }
            sw.WriteLine("-----------------------------");
            sw.Flush();
            sw.Close();
            System.Diagnostics.Process.Start(nomeArquivo);
        }
    }
}
