using System.Collections.Generic;

namespace Aula13_Atividade
{
    public abstract class Administracao
    {
        public List<string> alunosCadastrados = new List<string>();
        public List<string> empresasCadastradas = new List<string>();
        protected List<string> funcionariosContratados = new List<string>();
        public abstract void Cadastrar();

        public abstract void Remover();

        public static void Atualizar()
        {
            
        }

        void ApresentarTodos()
        {

        }
    }
}
