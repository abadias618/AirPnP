using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AirPNP_Beta.Models;

namespace AirPNP_Beta
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void Login_Clicked(object sender, EventArgs e)
        {
            User user = new User(Username.Text, Password.Text);
            if (user.CheckLogin())
            {
                await DisplayAlert("Login", "Login Successful", "ok");

                //App.UserDatabase.SaveUser(user);
                await Navigation.PushAsync(new HomePage());
            }
            else
            {
                await DisplayAlert("Login", "Username and/or password incorrect", "ok");
            }
        }

    }
}
