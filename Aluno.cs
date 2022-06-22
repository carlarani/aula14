namespace Aula13_Atividade
{
    public class Aluno
    {
        public int Matricula;
        public string? Nome;
        public string? Sobrenome;
        public string? Telefone;
        public double[]? Notas;
        public string[] Bimestres = { "primeiro bimestre", "segundo bimestre", "terceiro bimestre", "quarto bimestre" };
        public double media;

        //public Aluno(int matricula, string nome, string sobrenome, string telefone)
        //{
        //    this.Matricula = matricula;
        //    this.Nome = nome;
        //    this.Sobrenome = sobrenome;
        //    this.Telefone = telefone;
        //}

        public Aluno()
        {
            this.Notas = new double[4];
        }

        public void Atualizar()
        {
            int op = 0;
            Console.WriteLine("Qual informação deseja atualizar?");
            Console.WriteLine("1 - Nome");
            Console.WriteLine("2 - Sobrenome");
            Console.WriteLine("3 - Telefone");
            Console.WriteLine("4 - Sair do sistema de atualização;");
            int opcao = Convert.ToInt32(Console.ReadLine());

            while (op == 0) {
                switch (opcao)

                {
                    case 1:
                        Console.WriteLine("Qual é o nome atual?");
                        Nome = Console.ReadLine();
                        op = 1;
                        break;
                    case 2:
                        Console.WriteLine("Qual é o sobrenome atual?");
                        Sobrenome = Console.ReadLine();
                        op = 1;
                        break;
                    case 3:
                        Console.WriteLine("Qual é o telefone atual?");
                        Telefone = Console.ReadLine();
                        op = 1;
                        break;
                    case 4:
                        Console.WriteLine("Saindo do programa de atualização");
                        op = 1;
                        break;
                    default:
                        Console.WriteLine("Favor, inserir um valor válido");
                        break;
                }
            }
        }

        public void RegistrarNota()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Digite a nota do {Bimestres[i]}:");
                Notas[i] = double.Parse(Console.ReadLine());
            }
        }

        public void ApresentarNotas()
        {
            for (int i=0; i<4;i++)
            {
                Console.WriteLine($"A nota do {Bimestres[i]} foi {Notas[i]}.");
            }
        }

        public double MediaDasNotas()
        {
            double soma = 0;
            for (int j=0; j<Notas.Length; j++)
            {
                soma += Notas[j];
            }

            media = (soma)/4;

            return media;
        }

        public String Estagio()
        {
            string op;
            if (media >= 7) 
            {
                op = "Aprovado";
                
            } else
            {
                op = "Reprovado";
            }

            return op;
        }
    }
}
