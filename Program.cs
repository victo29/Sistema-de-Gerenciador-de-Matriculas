using SistemaGerenciador.models;


Curso[] cursos = new Curso[3];



bool liberacao = true;
int contador = 0;

do
{
    Console.Write("Quantos Alunos você pretende cadastrar: ");
    int quantidadeAlunos = 0; 
    
    try
    {
        quantidadeAlunos = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        Console.Write("O valor passado não é valido, tente novamente: ");
        quantidadeAlunos = Convert.ToInt32(Console.ReadLine());
    }




    Console.Write("Digite o nome do curso: ");
    
    cursos[contador].Nome = Console.ReadLine();
   

    cursos[contador].Alunos = new List<Pessoa>();

    for (int i = 0; i < quantidadeAlunos; i++)
    {
        Console.Clear();
        Console.Write($"Digite o nome completo do seu {i + 1}° aluno ");
        cursos[contador].Adicionador(Console.ReadLine());
    }
    Console.Clear();
    cursos[contador].ListarAlunos();

    if (contador == 2)
    {

        Console.Clear();
        Console.WriteLine("O Limite são apenas 3 cursos");
        liberacao = false;
        Thread.Sleep(5000);
        Console.Clear();

    }
    else
    {
        Console.WriteLine("Deseja cadastrar outro curso? S/N");
        string outroCurso = Console.ReadLine();

        if (outroCurso == "S" || outroCurso == "s")
        {
            liberacao = true;
            contador++;
        }
        else
        {
            liberacao = false;
            Console.Clear();
        }
    }

} while (liberacao);


Console.WriteLine("PROCESSANDO OS DADOS.........");
Thread.Sleep(3000);
Console.Clear();


if (contador == 2)
{
    cursos[0].ListarAlunos();
    Console.WriteLine("---------------------");
    cursos[1].ListarAlunos();
    Console.WriteLine("---------------------");
    cursos[2].ListarAlunos();
    Console.WriteLine("---------------------");

}
else if (contador == 1)
{
    cursos[0].ListarAlunos();
    Console.WriteLine("---------------------");
    cursos[1].ListarAlunos();
}
else
{
    cursos[0].ListarAlunos();
}

