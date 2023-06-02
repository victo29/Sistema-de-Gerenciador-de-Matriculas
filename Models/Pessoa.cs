using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCursos.models
{
    public class Pessoa
    {
        public Pessoa() { }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome;
        public string Nome
        {
            get => _nome.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }

        private string _sobrenome;
        public string Sobrenome
        {
            get => _sobrenome.ToUpper();
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O sobrenome não pode ser vazio");

                }
                _sobrenome = value;
            }
        }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

       
    }
}