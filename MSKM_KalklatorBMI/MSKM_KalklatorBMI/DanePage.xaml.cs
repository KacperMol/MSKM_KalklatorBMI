using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MSKM_KalklatorBMI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DanePage : ContentPage
    {
        public DanePage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listaBMI.ItemsSource = await App.Database.WyswietlUzytkownikaAsync();
        }

        private void Wroc_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}