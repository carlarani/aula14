namespace Aula13_Atividade
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////teste 01
            //Aluno aluno = new Aluno();
            //aluno.RegistrarNota();
            //aluno.ApresentarNotas();
            //Console.WriteLine($"A média do aluno foi:{aluno.MediaDasNotas()}.");
            //Console.WriteLine($"O aluno está:{aluno.Estagio()}.");
            //aluno.Atualizar();

            ////teste 02
            //Curso curso = new Curso();
            //curso.Cadastrar();
            //curso.Cadastrar();
            //curso.Cadastrar();
            //curso.Remover();
            //curso.Atualizar();
            //curso.ApresentarTodos();

            ////teste 03
            //Empresa empresa = new Empresa();
            //empresa.Cadastrar();
            //empresa.Cadastrar();
            //empresa.Cadastrar();
            //empresa.Remover();
            //empresa.Atualizar();
            //empresa.ApresentarTodos();


            //teste 04
            Funcionario func = new Funcionario();
            Aluno alunofunc = new Aluno();
            func.Cadastrar();
            func.Nome = alunofunc.Nome;
            alunofunc.RegistrarNota();
            alunofunc.MediaDasNotas();
            alunofunc.Estagio();
            func.EstagioDoFuncionario(alunofunc);

            
        }
    }
}