using System;

namespace RegrasDeNegocio
{
    class Program
    {
        static void Main()
        {
            // Criando uma pessoa
            try
            {
                //tenta usa um construtor pra criar o obj pessoa
                Pessoa pessoa = new Pessoa("João", 17);
                Console.WriteLine($"Pessoa criada: {pessoa.Nome}, {pessoa.Idade} anos");
            }
            catch (ArgumentException ex)
            {
                //se nao criou o obj pessoa, mostra a mensagem de erro
                Console.WriteLine("Erro ao criar pessoa: " + ex.Message);
            }

            // Verificando horário de acesso
            // usa um construtor pra criar o obj Acesso
            Acesso acesso = new Acesso();
            DateTime agora = DateTime.Now;

            if (acesso.HorarioPermitido(agora))
            {
                Console.WriteLine($"Acesso permitido às {agora:HH:mm}");
            }
            else
            {
                Console.WriteLine($"Acesso negado às {agora:HH:mm}. Fora do horário comercial.");
            }
        }
    }
}

