namespace toDoList.Pages;

public partial class Rick : ContentPage
{
	public Rick()
	{
		InitializeComponent();
	}
    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}