using ProjetoCursos.models;

Console.WriteLine("Quantos Alunos você pretende cadastrar?");
string a = Console.ReadLine();
int quantidadeAlunos = Convert.ToInt32(a);

Console.WriteLine("Digite o nome do curso:");
Curso cursos = new Curso(Console.ReadLine());
cursos.Alunos = new List<Pessoa>();

for (int i = 0; i < quantidadeAlunos; i++)
{
    Console.Clear();
    Pessoa p = new Pessoa();
    Console.WriteLine($"Digite o nome do seu {i + 1}° aluno:");
    p.Nome = Console.ReadLine();
    Console.WriteLine($"Digite o sobrenome do seu {i + 1}° aluno:");
    p.Sobrenome = Console.ReadLine();
    cursos.AdicionarAluno(p);
}
Console.Clear();
cursos.ListarAlunos();
Console.WriteLine("Deseja cadastrar outro curso? S/N");
string outroCurso = Console.ReadLine();

if(outroCurso == "S" || outroCurso == "s")
{
Console.Clear();
}
else
{
    Console.Clear();
    Console.WriteLine("Obrigado por utilizar nossos serviços");
}

Console.WriteLine("Quantos Alunos você pretende cadastrar?");
string ab = Console.ReadLine();
int quantidadeAlunos1 = Convert.ToInt32(ab);

Console.WriteLine("Digite o nome do seu novo curso:");
Curso Curso1 = new Curso(Console.ReadLine());
Curso1.Alunos = new List<Pessoa>();

for (int i = 0; i < quantidadeAlunos1; i++)
{
    Console.Clear();
    Pessoa p = new Pessoa();
    Console.WriteLine($"Digite o nome do seu {i + 1}° aluno:");
    p.Nome = Console.ReadLine();
    Console.WriteLine($"Digite o sobrenome do seu {i + 1}° aluno:");
    p.Sobrenome = Console.ReadLine();
    Curso1.AdicionarAluno(p);
}
Console.Clear();
Curso1.ListarAlunos();

Console.WriteLine("Deseja visualizar todos os cursos cadastrados?");
string visualização = Console.ReadLine();
if(visualização == "S" || visualização == "s")
{
    Console.Clear();
    cursos.ListarAlunos();
    Console.WriteLine("---------------------------");
    Curso1.ListarAlunos();
}
else
{
    Console.Clear();
    Console.WriteLine("Obrigado por usar nossos seviços");
}



