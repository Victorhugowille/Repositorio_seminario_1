using System;
using ReservaSalas.Models;

namespace ReservaSalas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Informe a sala: ");
                string sala = Console.ReadLine();

                Console.Write("Informe a data e hora da reserva (ex: 2025-05-10 14:00): ");
                DateTime dataHora = DateTime.Parse(Console.ReadLine());

                // Cria a reserva (o construtor faz a validação!)
                Reserva reserva = new Reserva(sala, dataHora);
                reserva.ExibirDetalhes();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao criar reserva: " + ex.Message);
            }
        }
    }
}
