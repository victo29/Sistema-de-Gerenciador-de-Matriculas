using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaGerenciador.models
{
    public class Curso
    {
        public Curso() { }
        public Curso(string nome)
        {
            Nome = nome;
        }

        

        public string Nome { get; set; }

        public List<Pessoa> Alunos { get; set; }
        


  
        public void ListarAlunos()
        {
            Console.WriteLine($"ALUNOS DO CURSO DE {Nome.ToUpper()}:");
            for (int count = 0; count < Alunos.Count; count++)
            {

                string texto = $"N° {count + 1} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
            }
        }

        public void Adicionador( string nome)
        {
            
                Pessoa p = new Pessoa();
                p.Nome = nome;
                Alunos.Add(p);
            
        }



    }

}