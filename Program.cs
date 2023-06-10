using ProjetoCursos.models;

bool liberação = true;

do
{
    Console.Write("Quantos Alunos você pretende cadastrar: ");
    string a = Console.ReadLine();
    int quantidadeAlunos = Convert.ToInt32(a);

    Console.Write("Digite o nome do curso: ");
    Curso cursos = new Curso(Console.ReadLine());
    cursos.Alunos = new List<Pessoa>();

    for (int i = 0; i < quantidadeAlunos; i++)
    {
        Console.Clear();
        Console.WriteLine($"Digite o nome completo do seu {i +1}° aluno ");
        cursos.Adicionador(Console.ReadLine());
    }
    Console.Clear();
    cursos.ListarAlunos();
    
    Console.WriteLine("Deseja cadastrar outro curso? S/N");
    string outroCurso = Console.ReadLine();

    if (outroCurso == "s" || outroCurso == "s")
    {
        liberação = true;
    }
    else
    {
        liberação = false;
    }
} while (liberação);