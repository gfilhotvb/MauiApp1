using MauiApp1.Models;
using System.Transactions;

namespace MauiApp1.View;

public partial class ADD_EDIT : ContentPage
{
    public SB1 transactionS;
    public ADD_EDIT()
	{
		InitializeComponent();
        
	}


    public void SetTransactionToEdit(SB1 transaction)
    {
        transactionS = transaction;
        PROP();
    }

    public void PROP()
    {
        CODPROD.Text = transactionS.DESCPROD.ToString();
        CODPROD.IsEnabled = false;
        B1.Text = "ALTERAR";
        //B1.BackgroundColor = Color.FromArgb("#000");
        B1.BackgroundColor= Colors.Silver;
        B2.Text = "EXCLUIR";
        //B1.BackgroundColor = Color.FromArgb("#000");
        B2.BackgroundColor = Colors.Red;

    }

    private void B1_Clicked(object sender, EventArgs e)
    {
        if (B1.Text == "INCLUIR")
        {

        }
        else
        {

        }

    }

    private async void B2_Clicked(object sender, EventArgs e)
    {
        if(B2.Text=="EXCLUIR")
        {
            bool result = await App.Current.MainPage.DisplayAlert("Excluir!", "Tem certeza que deseja excluir?", "Sim", "Não");

            if (result)
            {
      
     
            }
            else
            {
                Navigation.PopModalAsync();
            }
        }
    }
}