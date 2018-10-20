using System;
using System.Collections.Generic;
using System.Text;

namespace meuProjeto.Dominio
{
    class Mulher: Pessoa
    {
        //precisa preencher dados, determinar que o objeto tenha esses dados já preenchidos, os parametros corretos
        public Mulher(string nome, string profissao) : base(nome, profissao)//base ta falando da classe pai
            //estou passando para o construtor do meu pai o que esta escrito aqui
        {
            Genero = 'f';

            //Nome = nome; é quando não tem a palavra base em cima
            //Profissao = profissao;
            //propriedade da classe = nome do tipo que vc esta passando
        }


        //public bool EstaGravida { get; set; }
        public bool EstaDeTpm { get; set; }
        public bool BebeMaisQueHomem { get; set; }

        public string NomeEIdade()
        {
            return $"O nome dessa pessoa é {Nome} e a idade é {Idade} ";
        }

        public bool estaGravida;

        public bool EstaGravida
        {
            get { return estaGravida; }
            set {
                if (EstaDeTpm)
                    estaGravida = false;
                else
                    estaGravida = true;
            } //esse true é o value que a pessoa vai colocar na propriedade.
        }

    }
}
