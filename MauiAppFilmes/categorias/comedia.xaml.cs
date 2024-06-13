namespace MauiAppFilmes.cateogorias;

public partial class comedia : ContentPage
{
	public comedia()
	{
		InitializeComponent();
	}

    private void abtc1_Clicked(object sender, EventArgs e)
    {
        {
            try
            {
                Navigation.PushAsync(new Videos.Filmecomedia1());
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }

    private void abtc2_Clicked(object sender, EventArgs e)
    {
        {
            try
            {
                Navigation.PushAsync(new Videos.Filmecomedia2());
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
    private void abtc3_Clicked(object sender, EventArgs e)
    {
        {
            try
            {
                Navigation.PushAsync(new Videos.Filmecomedia3());
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }

    private void abtc4_Clicked(object sender, EventArgs e)
    {
        {
            try
            {
                Navigation.PushAsync(new Videos.Filmecomedia4());
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}