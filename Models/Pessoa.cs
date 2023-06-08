using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCursos.models
{
    public class Pessoa
    {
        public Pessoa() { }

        public Pessoa(string nome)
        {
            Nome = nome;
           
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

        
        

        public string NomeCompleto => $"{Nome}".ToUpper();

       
    }
}