﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calendar_with_Notepad
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewEvent : ContentPage
    {
        public NewEvent()
        {
            InitializeComponent();
        }

         async void OnButtonClicked1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Name.Text))
            {
                await App.Database.SaveNotesAsync(new Note
                {
                    Name = Name.Text,

                });

                Name.Text = string.Empty;
                NotesListView.ItemsSource = await App.Database.GetNotesAsync();
            }
        }




        private async void OnButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Page1());
        }

        static string generateColor()
        {
            var color = randomColor();

            return color;
        }
    }
}
