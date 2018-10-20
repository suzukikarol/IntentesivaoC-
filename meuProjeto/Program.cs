using meuProjeto.Dominio;
using System;

namespace meuProjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            Mulher Ale = new Mulher();//criando m,ulher

            //colocando valores no objeto Ale
            Ale.BebeMaisQueHomem = true;
            Ale.DataNascimento = new DateTime(1999, 05, 17);
            Ale.EstaDeTpm = false;
            Ale.EstaGravida = true;
            Ale.Idade = 19;
            Ale.Nome = "Alessandra Soares";
            Ale.Profissao = "Programadora";

            //variadas formas de saida de texto com concatenação de informações
            Console.WriteLine("Olá, meu nome é:  !"+Ale.Nome);
            Console.WriteLine($"Eu tenho {Ale.Idade} anos");
            Console.WriteLine(string.Format("Minha profissão é {0}", Ale.Profissao));

            Console.ReadKey();//para o console fechar a tela
            
        }
    }
}
