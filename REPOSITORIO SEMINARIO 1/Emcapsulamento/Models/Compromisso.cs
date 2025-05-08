// Arquivo: /Models/Compromisso.cs
using System;
using System.Collections.Generic;

namespace Projeto.Models
{
    public class Compromisso
    {
        // Atributos privados
        private DateTime data;
        private List<DateTime> horarios = new List<DateTime>();

        // Método para registrar a data, com validação
        public void RegistrarData(string textoData)
        {
            // Verifica se a data fornecida é válida
            if (!DateTime.TryParse(textoData, out data))
            {
                throw new ArgumentException("Data inválida. Use o formato correto (ex: 05/05/2025).");
            }

            // Garante que a data não seja no passado
            if (data < DateTime.Today)
            {
                throw new ArgumentException("A data não pode estar no passado.");
            }

            Console.WriteLine("Data registrada com sucesso: " + data.ToShortDateString());
        }

        // Método para registrar horário (outro exemplo de validação)
        public void RegistrarHorario(DateTime horario)
        {
            // Verifica se o horário está dentro de um intervalo permitido (ex: horário comercial)
            if (horario.Hour < 8 || horario.Hour >= 18)
            {
                throw new ArgumentException("O horário deve estar dentro do horário comercial (08:00 - 18:00).");
            }

            horarios.Add(horario);
            Console.WriteLine("Horário registrado com sucesso: " + horario.ToShortTimeString());
        }

        // Método para validar todos os compromissos registrados
        public void ValidarCompromissos()
        {
            List<string> erros = new List<string>();

            // Exemplo: verificar se há compromissos em horários inválidos
            foreach (var horario in horarios)
            {
                if (horario.Hour < 8 || horario.Hour >= 18)
                {
                    erros.Add($"Horário inválido: {horario.ToShortTimeString()}.");
                }
            }

            if (erros.Count > 0)
            {
                // Lança exceção com todos os erros
                throw new ArgumentException(string.Join(Environment.NewLine, erros));
            }

            Console.WriteLine("Todos os compromissos são válidos.");
        }
    }
}
