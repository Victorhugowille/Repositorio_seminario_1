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


