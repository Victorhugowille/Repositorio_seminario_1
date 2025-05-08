using System;

namespace Exemplo
{
    public class Tarefa
    {
        public string Nome { get; set; }
        public DateTime CriadaEm { get; }
        public string Status { get; private set; }

        public Tarefa(string nome)
        {
            Nome = nome;
            CriadaEm = DateTime.Now;
            Status = "Pendente";
        }

        public void Concluir()
        {
            Status = "Concluída";
        }
    }

    class Program
    {
        static void Main()
        {
            Tarefa tarefa = new Tarefa("Estudar C#");
            Console.WriteLine($"Status: {tarefa.Status}");
            tarefa.Concluir();
            Console.WriteLine($"Status após conclusão: {tarefa.Status}");
        }
    }
}
