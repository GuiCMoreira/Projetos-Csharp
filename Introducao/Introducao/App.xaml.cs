using Introducao.Models;

namespace Introducao
{
    public partial class App : Application
    {
        public static List<Tarefa> tarefas = new List<Tarefa>();

        public App()
        {  
            tarefas.Add(new Tarefa() { Nome = "Tarefa 1", Descricao = "Descrição da Tarefa 1"});
            tarefas.Add(new Tarefa() { Nome = "Tarefa 2", Descricao = "Descrição da Tarefa 2" });
            tarefas.Add(new Tarefa() { Nome = "Tarefa 3", Descricao = "Descrição da Tarefa 3" });
            tarefas.Add(new Tarefa() { Nome = "Tarefa 4", Descricao = "Descrição da Tarefa 4" });
            tarefas.Add(new Tarefa() { Nome = "Tarefa 5", Descricao = "Descrição da Tarefa 5" });
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
