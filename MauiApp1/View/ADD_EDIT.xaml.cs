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
       teste.Text = transactionS.DESCPROD.ToString();

    }
}