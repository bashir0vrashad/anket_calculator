using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    internal class Anket
    {
        private string ad;
        private string soyad;
        private string olke;
        private string seher;
        private string telefon;
       
        static string yoxlama = @"^(070|077|055|050|051|010|099)";
        Regex regex = new Regex(yoxlama);

        public string Ad
        {
            get { return ad; }
            set
            {
                if (value.Length >= 3 && (int)value[0] >= 65 && (int)value[0] <= 90 && !string.IsNullOrWhiteSpace(value)) ad = value;
                else throw new ApplicationException("Name Error...");
            }
        }
        public string Soyad
        {
            get { return soyad; }
            set
            {
                if (value.Length >= 5 && (int)value[0] >= 65 && (int)value[0] <= 90 && !string.IsNullOrWhiteSpace(value)) soyad = value;
                else throw new ApplicationException("Surname Error...");
            }
        }

        public string Olke
        {
            get { return olke; }
            set
            {
                if (value.Length >= 3 && (int)value[0] >= 65 && (int)value[0] <= 90 && !string.IsNullOrWhiteSpace(value)) olke = value;
                else throw new ApplicationException("Country Error...");
            }
        }
        public string Seher
        {
            get { return seher; }
            set
            {
                if (value.Length >= 3 && (int)value[0] >= 65 && (int)value[0] <= 90 && !string.IsNullOrWhiteSpace(value)) seher = value;
                else throw new ApplicationException("City Error...");
            }
        }
        public string Telefon
        {
            get { return telefon; }
            set
            {
              if(regex.IsMatch(value))telefon = value;
              else throw new ApplicationException("Phone Error...");
            }
        }
        public DateOnly Date { get; set; }
        public bool Cins { get; set; }

       public Anket(string ad, string soyad, string olke , string seher , string telefon , bool cins, DateOnly date)
        {
            Ad = ad;
            Soyad = soyad;
            Olke = olke;
            Seher = seher;
            Telefon = telefon;
            Cins = cins;
            Date = date;
        }



    }
}