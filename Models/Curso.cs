using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCursos.models
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

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);

        }


        public int ObterQuantidadeDeAlnosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public void RemoverAluno(Pessoa aluno)
        {
             Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"ALUNOS DO CURSO DE {Nome.ToUpper()}:");
            for (int count = 0; count < Alunos.Count; count++)
            {

                string texto = $"N° {count + 1} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
            }
        }


    }

}