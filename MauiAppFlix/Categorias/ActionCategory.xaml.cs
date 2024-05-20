namespace MauiAppFlix.Categorias;

public partial class ActionCategory : ContentPage
{
	public ActionCategory()
	{
		InitializeComponent();
	}

    private void btnAvengers_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Movies.Avengers());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void btnMadMax_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Movies.MadMax());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}