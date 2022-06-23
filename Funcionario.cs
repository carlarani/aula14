namespace Aula13_Atividade
{
    class Funcionario : Administracao
    {
        public string Nome;
        string? Sobrenome;
        string? Telefone;
        double? Salario;
        string? CPF;
           


        public void EstagioDoFuncionario(Aluno aluno)
        {
            string result = "";
            Console.WriteLine("Qual o nome do funcionário que deseja consultar?");
            string input = Console.ReadLine().ToUpper();
            if (!(funcionariosContratados.Contains(input)))
            {
                Console.WriteLine($"{input} não é funcionário da instituição.");
            }
            else
            {
                if (aluno.Estagio() == "Aprovado")
                {
                    result = "ativo";
                }
                else
                {
                    result = "inativo";
                }
                Console.WriteLine($"O estágio de {input} está {result}.");
            }
        }
        public override void Cadastrar()
        {
            Console.WriteLine("Qual o nome do funcionário que deseja cadastrar?");
            Nome = Console.ReadLine().ToUpper();
            funcionariosContratados.Add(Nome);
        }

        public void ApresentarTodos()
        {
            Console.WriteLine("\nOs funcionário são:");
            foreach (string funcionario in funcionariosContratados)
            {
                Console.WriteLine(funcionario);
            }
        }

        public override void Remover()
        {
            throw new NotImplementedException();
        }
    }
}
