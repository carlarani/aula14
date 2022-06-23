namespace Aula13_Atividade
{
    public class Curso : Administracao
    {
        public override void Cadastrar()
        {
            Console.WriteLine("Qual o nome do aluno que deseja cadastrar?");
            string input = Console.ReadLine().ToUpper();            
            alunosCadastrados.Add(input);
        }

        public override void Remover()
        {
            Console.WriteLine("Qual o nome do aluno que deseja remover?");
            string input = Console.ReadLine().ToUpper();
            alunosCadastrados.Remove(input);
        }

        public void Atualizar()
        {
            Console.WriteLine("Qual o nome do aluno que deseja atualizar?");
            string input = Console.ReadLine().ToUpper();
            if (alunosCadastrados.Contains(input))
            {
                int index = alunosCadastrados.IndexOf(input);
                alunosCadastrados.Remove(input);
                Console.WriteLine("Qual o nome do atual do aluno?");
                string input2 = Console.ReadLine().ToUpper();
                alunosCadastrados.Insert(index, input2);
            }
            else
            {
                Console.WriteLine("Aluno não encontrado na base de dados. Deseja cadastrá-lo? [S/N]");
                char opcao = char.Parse(Console.ReadLine().ToUpper());
                switch(opcao)
                {
                    case 'S':
                        Cadastrar();
                        break;
                    default:
                        break;
                }
            }
        }

        public void ApresentarTodos()
        {
            Console.WriteLine("\nOs alunos inscritos são:");
            foreach(string aluno in alunosCadastrados)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
