namespace ReservaSalas.Models
{
    public class Reserva
    {
        public string Sala { get; private set; }
        public DateTime DataHora { get; private set; }

        public Reserva(string sala, DateTime dataHora)
        {
            if (string.IsNullOrWhiteSpace(sala))
                throw new ArgumentException("O nome da sala não pode ser vazio.");

            if (dataHora <= DateTime.Now)
                throw new ArgumentException("A reserva deve ser feita para uma data e hora futuras.");

            Sala = sala;
            DataHora = dataHora;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Reserva confirmada para a sala '{Sala}' em {DataHora:dd/MM/yyyy HH:mm}");
        }
    }
}
