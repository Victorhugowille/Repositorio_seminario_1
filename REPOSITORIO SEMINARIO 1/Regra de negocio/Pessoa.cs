using System;
// verifica se a Pessoa tem mais de 18 anos
namespace RegrasDeNegocio
{
    public class Pessoa
    {
        public string Nome { get; }
        public int Idade { get; }

        public Pessoa(string nome, int idade)
        {
            if (idade < 18)
                throw new ArgumentException("É necessário ter 18 anos ou mais.");

            Nome = nome;
            Idade = idade;
        }
    }
}
