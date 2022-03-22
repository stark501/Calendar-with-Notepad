using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection.Emit;
using Xamarin.Forms;


namespace Calendar_with_Notepad
{
    public class SplashPage : ContentPage
    {
        Image splashImage;

        public SplashPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            var sub = new AbsoluteLayout();
            splashImage = new Image
            {
                Source = "calendar.png",
                WidthRequest = 200,
                HeightRequest = 200

            };
            AbsoluteLayout.SetLayoutFlags(splashImage,
                AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashImage,
             new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(splashImage);

            this.BackgroundColor = Color.FromHex("#fff");
            this.Content = sub;
        }


        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await splashImage.ScaleTo(1, 2000);
            await splashImage.ScaleTo(0.5, 800, Easing.Linear);

            Application.Current.MainPage = new NavigationPage(new Page1());
        }

        
    }
}
