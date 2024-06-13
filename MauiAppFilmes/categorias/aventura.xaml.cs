namespace MauiAppFilmes.cateogorias;

public partial class aventura : ContentPage
{
	public aventura()
	{
		InitializeComponent();
	}

    private void abtna4_Clicked(object sender, EventArgs e)
    {
        {
            try
            {
                Navigation.PushAsync(new Videos.Filmaventura1());
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }


    private void abtna3_Clicked(object sender, EventArgs e)
    {
        {
            try
            {
                Navigation.PushAsync(new Videos.Filmeaventura2());
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }

    private void abtna2_Clicked(object sender, EventArgs e)
    {
        {
            try
            {
                Navigation.PushAsync(new Videos.Filmeaventura3());
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }

    private void abtna1_Clicked(object sender, EventArgs e)
    {
        {
            try
            {
                Navigation.PushAsync(new Videos.Filmeaventura4());
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}