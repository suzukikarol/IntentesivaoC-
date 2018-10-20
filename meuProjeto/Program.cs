using meuProjeto.Dominio;
using System;

namespace meuProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //criando m,ulher
            Mulher Ale = new Mulher("Alessandra Soares", "Programadora");

            //colocando valores no objeto Ale
            Ale.BebeMaisQueHomem = true;
            Ale.DataNascimento = new DateTime(1999, 05, 17);
            Ale.EstaDeTpm = true;
            Ale.EstaGravida = true;
            Ale.Idade = 19;
            //Ale.Nome = "Alessandra Soares"; ai voce nao precisa colocar esse aqui
            //Ale.Profissao = "Programadora";ai voce nao precisa colocar esse aqui

            string nomeEIdade = Ale.NomeEIdade();

            Console.WriteLine(nomeEIdade);

            //variadas formas de saida de texto com concatenação de informações
            //Console.WriteLine("Olá, meu nome é:  !"+Ale.Nome);
            //Console.WriteLine($"Eu tenho {Ale.Idade} anos");
            Console.WriteLine(string.Format("Minha profissão é {0}", Ale.Profissao));

            
            //para o console fechar a tela
            Console.ReadKey();
            

        }
    }
}
