using System;
using System.Collections.Generic;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            var contato = new Contato() {
                Nome = "Thiago",
                Telefone = "3199998888"
            };
            
            if (contato.Enderecos.Count > 5)
            {
                Console.WriteLine("Permitido cadastrar até 5 endereços por contato.");
            }
        }
    }

    class Contato
    {
        public string Nome = string.Empty;
        public string Telefone = string.Empty;
        public List<Endereco> Enderecos = new List<Endereco>();
    }

    class Endereco
    {
        public string Logradouro = string.Empty;
        public string Cidade = string.Empty;
        public string Estado = string.Empty;
    }
}
