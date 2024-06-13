

namespace MauiAppFilmes.cateogorias;

public partial class animacao : ContentPage
{
	public animacao()
	{
        InitializeComponent();
	}

    private void abtn1_Clicked(object sender, EventArgs e)
    {
        {
            try
            {
                Navigation.PushAsync(new Videos.Filme1());
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }

    private void abtn2_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Videos.Filme2());
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", ex.Message, "OK");
        }
    }

    private void abtn3_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Videos.Filme3());
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", ex.Message, "OK");
        }
    }

    private void abtn4_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Videos.Filme4());
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", ex.Message, "OK");
        }
    }
}



 

