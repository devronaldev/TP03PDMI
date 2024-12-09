using TP03PDMI.Models;
using System;
namespace TP03PDMI.Views;

public partial class ResultPage : ContentPage
{
	public ResultPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        Package pack = (Package)BindingContext;

        StatusLabel.Text = pack.GetStatusName();
        SentAtLabel.Text = pack.SentAt.ToString();
        EstimatedDeliveryDateLabel.Text = pack.EstimatedDeliveryDate.ToShortDateString();
        LocateLabel.Text = pack.Locate.ToString();
    }

    private async void OnReturnClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}