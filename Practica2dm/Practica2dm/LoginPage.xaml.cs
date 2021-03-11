using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Practica2dm
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());

        }

        async void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {

            if (string.IsNullOrEmpty(Email.Text) || string.IsNullOrEmpty(Password.Text))
                { 
            await DisplayAlert("Login Failed", "Please fill all fields" ,"ok");
                 }
            else
            {
                await DisplayAlert("Welcome", Email.Text, "ok");
                await Navigation.PushAsync(new Home());

            }
        }
    }
}
