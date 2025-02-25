using Introducao.Models;

namespace Introducao
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            
            minhaLista.ItemsSource = App.tarefas;
        }

        private void minhaLista_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            string aux = ((sender as ListView).SelectedItem as Tarefa).Nome;
            DisplayAlert("Introdução", $"Tarefa selecionada: {aux}", "OK");
        }
    }

}
