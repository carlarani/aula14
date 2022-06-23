namespace Aula13_Atividade
{
    class Empresa : Administracao
    {
        public override void Cadastrar()
        {
            Console.WriteLine("Qual o nome da empresa que deseja cadastrar?");
            string input = Console.ReadLine().ToUpper();
            empresasCadastradas.Add(input);
        }

        public override void Remover()
        {
            Console.WriteLine("Qual o nome da empresa que deseja remover?");
            string input = Console.ReadLine().ToUpper();
            empresasCadastradas.Remove(input);
        }

        public void Atualizar()
        {
            Console.WriteLine("Qual o nome da empresa que deseja atualizar?");
            string input = Console.ReadLine().ToUpper();
            if (empresasCadastradas.Contains(input))
            {
                int index = empresasCadastradas.IndexOf(input);
                empresasCadastradas.Remove(input);
                Console.WriteLine("Qual o nome do atual da empresa?");
                string input2 = Console.ReadLine().ToUpper();
                empresasCadastradas.Insert(index, input2);
            }
            else
            {
                Console.WriteLine("Empresa não encontrada na base de dados. Deseja cadastrá-la? [S/N]");
                char opcao = char.Parse(Console.ReadLine().ToUpper());
                switch (opcao)
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
            Console.WriteLine("\nAs empresas cadastradas são:");
            foreach (string empresa in empresasCadastradas)
            {
                Console.WriteLine(empresa);
            }
        }
    }
}
