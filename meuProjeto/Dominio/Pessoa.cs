using System;
using System.Collections.Generic;
using System.Text;

namespace meuProjeto.Dominio
{
    class Pessoa
    {

        public Pessoa(string nome, string profissao)
        {
            Nome = nome;
            Profissao = profissao;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Profissao { get; set; }
        public char Genero { get; set; }
    }
}
