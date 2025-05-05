
using System;
using Projeto.Models; // Importando a classe Compromisso

namespace Projeto
{
    class Program
    {
        static void Main()
        {
            try
            {
                // Criando um objeto Compromisso
                Compromisso compromisso = new Compromisso();

                // Tentando registrar uma data válida
                compromisso.RegistrarData("05/05/2025");

                // Tentando registrar horários válidos
                compromisso.RegistrarHorario(new DateTime(2025, 5, 5, 10, 0, 0)); // 10:00
                compromisso.RegistrarHorario(new DateTime(2025, 5, 5, 20, 0, 0)); // 20:00 - Inválido

                // Validar compromissos
                compromisso.ValidarCompromissos();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }
}
