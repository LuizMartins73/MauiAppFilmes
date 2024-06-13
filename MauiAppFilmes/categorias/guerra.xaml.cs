namespace MauiAppFilmes.cateogorias;

public partial class guerra : ContentPage
{
	public guerra()
	{
		InitializeComponent();
	}

    private void abtg4_Clicked(object sender, EventArgs e)
    {
        {
            try
            {
                Navigation.PushAsync(new Videos.Filmeguerra4());
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }

    private void abtg3_Clicked(object sender, EventArgs e)
    {
        {
            try
            {
                Navigation.PushAsync(new Videos.Filmeguerra3());
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }

    private void abtg2_Clicked(object sender, EventArgs e)
    {
        {
            try
            {
                Navigation.PushAsync(new Videos.Filmeguerra2());
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }

    private void abtg1_Clicked(object sender, EventArgs e)
    {
        {
            try
            {
                Navigation.PushAsync(new Videos.Filmeguerra1());
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}