using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MSKM_KalklatorBMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Zapisz_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(imietxt.Text) && !string.IsNullOrWhiteSpace(nazwiskotxt.Text))
            {
                await App.Database.ZapiszUzytkownikaAsync(new Uzytkownik
                {
                    Imie = imietxt.Text,
                    Nazwisko = nazwiskotxt.Text,
                    BMI = double.Parse(BMI.Text),
                });
                imietxt.Text = nazwiskotxt.Text = string.Empty;
                await DisplayAlert("Sukces", "Dodano dane do bazy", "OK");

            }
            else
                await DisplayAlert("Blad", "Wpisz imie i nazwisko", "OK");
        
        }
    }
}
