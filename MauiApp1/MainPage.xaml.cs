using MauiApp1.Controller;

namespace MauiApp1;

public partial class MainPage : ContentPage
{

	API_PROTHEUS AP = new API_PROTHEUS();

	public MainPage()
	{
		InitializeComponent();
		Dados();



    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
	

    }

    private void bt2_Clicked(object sender, EventArgs e)
    {
	
		
    }

	public async Task Dados()
	{
		var item = AP.GETPRODUTOS();
        COLECTION.ItemsSource = item;

    }




}

