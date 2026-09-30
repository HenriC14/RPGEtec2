using AppRpgEtec.ViewModels.Armas;
using AppRpgEtec.ViewModels.Personagens;

namespace AppRpgEtec.Views.Armas;

public partial class ListagemView : ContentPage
{
    ListagemArmasViewModel ArmaViewModel;
    public ListagemView()
	{
		InitializeComponent();

        ArmaViewModel = new ListagemArmasViewModel();
        BindingContext = ArmaViewModel;
        Title = "Armas - App Rpg Etec";
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _ = ArmaViewModel.ObterArmas();
    }

}