using System;
using System.Collections.Generic;
using System.Text;

namespace MSKM_KalklatorBMI
{
    public  class Uzytkownik
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public double BMI { get; set; }
    }
}
