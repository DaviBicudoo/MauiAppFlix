namespace MauiAppFlix.Categorias;

public partial class Terror : ContentPage
{
	public Terror()
	{
		InitializeComponent();
	}

    private void btnAnabelle_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Movies.Anabelle());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void btnChucky_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Movies.Chucky());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void btnBabadook_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Movies.TheBabadook());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}