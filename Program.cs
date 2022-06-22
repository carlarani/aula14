namespace Aula13_Atividade
{
    public class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.RegistrarNota();
            aluno.ApresentarNotas();
            Console.WriteLine($"A média do aluno foi:{aluno.MediaDasNotas()}.");
            Console.WriteLine($"O aluno está:{aluno.Estagio()}.");
            aluno.Atualizar();
        }
    }
}