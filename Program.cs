using SistemaGerenciador.models;

Curso Ref;
Curso1 curso1 = new Curso1();
Curso2 curso2 = new Curso2();

bool liberacao = true;
int valor = 0;

do
{
    Console.Write("Quantos Alunos você pretende cadastrar: ");
    string a = Console.ReadLine();
    int quantidadeAlunos = Convert.ToInt32(a);
    valor++;



    if (valor == 2)
    {
        Ref = curso2;
    }
    else
    {
        Ref = curso1;
    }

    Console.Write("Digite o nome do curso: ");
    Ref.Nome = Console.ReadLine();
    Ref.Alunos = new List<Pessoa>();

    for (int i = 0; i < quantidadeAlunos; i++)
    {
        Console.Clear();
        Console.WriteLine($"Digite o nome completo do seu {i + 1}° aluno ");
        Ref.Adicionador(Console.ReadLine());
    }
    Console.Clear();
    Ref.ListarAlunos();

    if(valor < 2){

    
    Console.WriteLine("Deseja cadastrar outro curso? S/N");
    string outroCurso = Console.ReadLine();

    if (outroCurso == "S" || outroCurso == "s")
    {
        liberacao = true;
    }
    else
    {
        liberacao = false;
        Console.Clear();
    }
    }
    else{
        Console.Clear();
        Console.WriteLine("O Limite são apenas 2 cursos");
        liberacao = false;
        Thread.Sleep(5000);
        Console.Clear();

    }

} while (liberacao);


Console.WriteLine("PROCESSANDO OS DADOS.........");
Thread.Sleep(3000);
Console.Clear();
curso1.ListarAlunos();

if(valor == 2){
Console.WriteLine("---------------------");
curso2.ListarAlunos();
}
else{
    Console.WriteLine("FIM!");
}
