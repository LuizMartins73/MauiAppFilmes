namespace MauiAppFilmes
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }



        private void btn1_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new cateogorias.animacao());
            }
            catch (Exception ex) 
            {
                DisplayAlert("Error", ex.Message,"OK");
            }
        }

        private void btn2_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new cateogorias.aventura());
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private void btn3_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new cateogorias.comedia());
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private void btn4_Clicked(object sender, EventArgs e)
        {

        }

        private void btn5_Clicked(object sender, EventArgs e)
        {

        }

        private void btn6_Clicked(object sender, EventArgs e)
        {

        }

        private void btn7_Clicked(object sender, EventArgs e)
        {

        }

        private void btn8_Clicked(object sender, EventArgs e)
        {

        }

        private void btn9_Clicked(object sender, EventArgs e)
        {

        }

        private void btn10_Clicked(object sender, EventArgs e)
        {

        }

        private void btn11_Clicked(object sender, EventArgs e)
        {

        }

        private void btn12_Clicked(object sender, EventArgs e)
        {

        }
    }

}
