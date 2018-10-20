using System;
using System.Collections.Generic;
using System.Text;

namespace meuProjeto.Dominio
{
    class Mulher: Pessoa
    {

        public Mulher()
        {
            Genero = 'f';
        }
        public bool EstaGravida { get; set; }
        public bool EstaDeTpm { get; set; }
        public bool BebeMaisQueHomem { get; set; }
    }
}
