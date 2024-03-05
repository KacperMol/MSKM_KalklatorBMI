using SQLitePCL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace MSKM_KalklatorBMI
{
    internal class MainPageViewModel : INotifyPropertyChanged
    {
        public double height = 170;
        public double weight = 60;
        public double STEP = 1.0;

        public double Height
        {
            get => height;
            set
            {
                
                height = NextStep(value);
                UpdateResults();
            }
        }
        public double Weight
        {
            get => weight;
            set
            {
                weight = NextStep(value);
                UpdateResults();
            }
        }
        public double Bmi
            => Math.Round(Weight / Math.Pow(Height / 100, 2), 2);
        public string Classification
        {
            get
            {
                if (Bmi < 18.5)
                    return "Masz niedowage";
                else if (Bmi < 25)
                    return "Masz optymalna wage";
                else if (Bmi < 30)
                    return "Masz nadwage";
                else
                    return "Masz otyłość";
            }
        }
        public double NextStep(double value)
        {
            return Math.Round(value /STEP) * STEP;
        }
        public void Zaktalizuj(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public void UpdateResults()
        {
            Zaktalizuj(nameof(Bmi));
            Zaktalizuj(nameof(Classification));
        }
        public event PropertyChangedEventHandler PropertyChanged;   
    }
}
