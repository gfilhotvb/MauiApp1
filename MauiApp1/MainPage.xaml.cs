using MauiApp1.Controller;
using MauiApp1.Models;
using MauiApp1.View;
using System;
using System.Transactions;

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

    private async void bt2_Clicked(object sender, EventArgs e)
    {

        var result = await FilePicker.PickAsync(new PickOptions { PickerTitle = "SELECIONAR FILE" ,FileTypes = FilePickerFileType.Images});
        if (result == null)
        {
            return;
        }
        var STREM = await result.OpenReadAsync();
        TESTE.Source = ImageSource.FromStream(()=> STREM);
       




    }

	public async Task Dados()
	{
		var item = AP.GETPRODUTOS();
        COLECTION.ItemsSource = item;

    }

    public async Task<FileResult> PickAndShow(PickOptions options)
    {
        try
        {
            var result = await FilePicker.Default.PickAsync(options);
            if (result != null)
            {
                if (result.FileName.EndsWith("jpg", StringComparison.OrdinalIgnoreCase) ||
                    result.FileName.EndsWith("png", StringComparison.OrdinalIgnoreCase))
                {
                    using var stream = await result.OpenReadAsync();
                    var image = ImageSource.FromStream(() => stream);
                }
            }

            return result;
        }
        catch (Exception ex)
        {
            // The user canceled or something went wrong
        }

        return null;
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        //var grid = (Grid)sender;
        //var gesture = (TapGestureRecognizer)grid.GestureRecognizers[0];
        //Transaction transaction = (Transaction)gesture.CommandParameter;

        //var transactionEdit = Handler.MauiContext.Services.GetService<TransactionEdit>();
        //transactionEdit.SetTransactionToEdit(transaction);
        //Navigation.PushModalAsync(transactionEdit);
    }

    private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
        var frame = (Frame)sender;
        var gesture = (TapGestureRecognizer)frame.GestureRecognizers[0];
        SB1 transaction = (SB1)gesture.CommandParameter;
        //var TESTE = transaction.CODPROD;

        var transactionEdit = (new ADD_EDIT());
        MainThread.BeginInvokeOnMainThread(async () =>
        {
            if (Navigation.ModalStack.Count == 0 || Navigation.ModalStack.Last().GetType() != transactionEdit.GetType())
            {
                transactionEdit.SetTransactionToEdit(transaction);
                await Navigation.PushModalAsync(transactionEdit);
                Console.WriteLine("OK -11");

            }
        });


    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        var transactionEdit = (new ADD_EDIT());
        MainThread.BeginInvokeOnMainThread(async () =>
        {
            if (Navigation.ModalStack.Count == 0 || Navigation.ModalStack.Last().GetType() != transactionEdit.GetType())
            {
                await Navigation.PushModalAsync(transactionEdit);
                Console.WriteLine("OK -11");

            }
        });

    }
}

