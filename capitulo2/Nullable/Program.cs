#nullable enable
using System;
using System.Collections.Generic;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            var contato = new Contato();
            Console.WriteLine(
                $@"Como é obrigatório ter um valor, o atributo count sempre existe 
                {contato.Enderecos.Count}");
            
            // var endereco = new Endereco
            // endereco.Logradouro = "Rua silva guimarães";
            // endereco.Cidade = "Betim";
            // endereco.Estado = "MG";
        }
    }

    class Contato
    {
        public List<Endereco> Enderecos;
    }

    class Endereco
    {
        public string Logradouro = string.Empty;
        public string Cidade = string.Empty;
        public string Estado = string.Empty;
    }
}
