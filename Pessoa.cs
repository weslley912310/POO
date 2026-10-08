using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios
{
    public class Pessoa
    {

        public string nome;
        public int idade;

        public void ExibirInformacoes()
        {
            Console.WriteLine($"ola meu nome e {nome} e eu tenho {idade} anos");
            
        }

    }
}

