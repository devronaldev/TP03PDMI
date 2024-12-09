using Microsoft.EntityFrameworkCore;
using TP03PDMI.Models;
using TP03PDMI.Services;
using TP03PDMI.Views;

namespace TP03PDMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            AppDbRepository dbRepository = new AppDbRepository();
        }     

        private async void OnSearchClicked(object sender, EventArgs e)
        {
            string codigo = CodeEntry.Text.ToString().ToUpper();
            if (string.IsNullOrEmpty(codigo))
            {
                await DisplayAlert("Código não informado", "Você precisa informar um código válido para prosseguir", "Ok");
                return;
            }

            if (codigo.Length != 16)
            {
                await DisplayAlert("Código inválido", $"O código {codigo} não corresponde o tamanho exato de 16 caracteres", "Ok");
                return;
            }

            CodeEntry.Text = "";

            var context = new AppDbRepository();
            try
            {
                var pack = context.Packages.FirstOrDefault(p=> p.PackageId == codigo);
                if (pack == null)
                {
                    await DisplayAlert("Pacote Inexistente", $"O pacote com o código: {codigo}, não foi encontrado. Por favor, verificar se foi digitado corretamente.", "Tentar novamente");
                    return;
                }

                await Navigation.PushAsync(new ResultPage {BindingContext = pack});
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", $"Ocorreu um erro ao buscar o pacote: {ex.Message}", "Ok");
            }
        }
    }
}
