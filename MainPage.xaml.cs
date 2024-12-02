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
        }

        private async void OnSearchClicked(object sender, EventArgs e)
        {
            string codigo = CodeEntry.Text.ToString();
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
            using var context = new AppDbContext();

            try
            {
                List<Event> events = new List<Event>
                {
                    new Event
                    {
                        Id = 1,
                        Date = DateTime.Now.AddHours(-1),
                        Description = "Pedido criado",
                        EventStatus = DeliveryStatus.Criado,
                        Locate = "São Paulo",
                    },
                    new Event
                    {
                        Id = 2,
                        Date = DateTime.Now.AddMinutes(-5),
                        Description = "Pedido coletado",
                        EventStatus = DeliveryStatus.Coletado,
                        Locate = "São Paulo"
                    }
                };
                Package pack = new Package
                {
                    PackageId = "NPC1234567890",
                    Status = DeliveryStatus.Coletado,
                    SentAt = DateTime.Now,
                    EstimatedDeliveryDate = DateTime.Now.AddDays(7),
                    Locate = "São Paulo",
                    Events = events
                };
                /*var pack = await context.Packages.FirstOrDefaultAsync(p => p.PackageId == codigo);

                if (pack == null) 
                {
                    await DisplayAlert("Erro", "Pacote não encontrado. Verifique o código e tente novamente mais tarde.", "Ok");
                    return;
                }*/

                // Se encontrado, redirecione para a próxima página.
                await Navigation.PushAsync(new ResultPage { BindingContext = pack });
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", $"Ocorreu um erro ao buscar o pacote: {ex.Message}", "Ok");
            }
        }
    }
}
