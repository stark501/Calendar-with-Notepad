using System;
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

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Page1());
        }
    }
   
}