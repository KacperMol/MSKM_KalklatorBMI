using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MSKM_KalklatorBMI
{
    public partial class App : Application
    {
        static BazaDanych database;

        public static BazaDanych Database
        {
            get
            {
                if(database == null)
                {
                    database = new BazaDanych(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "bazaBMI.db3"));
                }    
                return database;
            }
        }




        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
