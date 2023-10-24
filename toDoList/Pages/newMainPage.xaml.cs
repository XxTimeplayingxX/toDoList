using System.Security.Cryptography.X509Certificates;

namespace toDoList.Pages;

public partial class newMainPage : ContentPage
{
	public newMainPage()
	{
		InitializeComponent();
        


    }
    private void Button_Clicked(object sender, EventArgs e)
    {
     
        Navigation.PushAsync(new Rick());
    }
}