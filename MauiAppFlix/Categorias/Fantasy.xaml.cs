namespace MauiAppFlix.Categorias;

public partial class Fantasy : ContentPage
{
	public Fantasy()
	{
		InitializeComponent();
	}

    private void btnAvatar_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Movies.Avatar());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void btnDune_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new Movies.Dune());
		}
		catch(Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "OK");
		}
    }

    private void btnHobbit_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Movies.Hobbit());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void btnTheLordOfTheRings_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Movies.TheLordOfTheRings());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}