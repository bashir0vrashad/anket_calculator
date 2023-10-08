using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Anket> ankets = new List<Anket>();
        bool buttonclick1 = false;
        string loadtext = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        public void yazma_oxuma<t>(string fayl_adi, t yeni, List<t> data)
        {

            if (!File.Exists(fayl_adi))
            {
                using (FileStream fs = File.Create(fayl_adi)) ;
            }
            else
            {
                string old_json = File.ReadAllText(fayl_adi);
                data = JsonConvert.DeserializeObject<List<t>>(old_json);

            }
            data.Add(yeni);
            string json = JsonConvert.SerializeObject(data);
            File.WriteAllText(fayl_adi, json);
        }
        public static List<t> oxuma<t>(string fayl_ad)

        {
            List<t> data = new List<t>();
            if (!File.Exists(fayl_ad)) return data;

            string old_json = File.ReadAllText(fayl_ad);
            data = JsonConvert.DeserializeObject<List<t>>(old_json);
            return data;
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            if (loadtext != "" && buttonclick1 == true)
            {
                List<Anket> ankets = oxuma<Anket>("Ankets.json");
                int j = -1;
                for (int i = 0; i < ankets.Count; i++)
                {
                    if (ankets[i].Telefon == loadtext) { j = i; break; }
                }
                if (j != -1)
                {
                    bool yoxla = false;
                    if (ankets[j].Ad != textBox2.Text) { ankets[j].Ad = textBox2.Text; yoxla = true; }
                    if (ankets[j].Soyad != textBox3.Text) { ankets[j].Soyad = textBox3.Text; yoxla = true; }
                    if (ankets[j].Olke != textBox4.Text) { ankets[j].Olke = textBox4.Text; yoxla = true; }
                    if (ankets[j].Seher != textBox5.Text) { ankets[j].Seher = textBox5.Text; yoxla = true; }
                    if (ankets[j].Telefon != textBox6.Text) { ankets[j].Telefon = textBox6.Text; yoxla = true; }
                    if (ankets[j].Date != DateOnly.FromDateTime(dateTimePicker1.Value.Date)) { ankets[j].Date = DateOnly.FromDateTime(dateTimePicker1.Value.Date); yoxla = true; }
                    if (ankets[j].Cins != radioButton1.Checked) { ankets[j].Cins = radioButton1.Checked; yoxla = true; }
                    if (yoxla)
                    {
                        string json = JsonConvert.SerializeObject(ankets);
                        File.WriteAllText("Ankets.json", json);

                    }
                    textBox3.Text = "";
                    textBox2.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                  
                }
                loadtext = "";
                buttonclick1 = false;
                return;
            }
                bool y;
                if (radioButton1.Checked) y = true;
                else y = false;
                try
                {
                    Anket yeni = new Anket(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, y, DateOnly.FromDateTime(dateTimePicker1.Value.Date));
                    yazma_oxuma<Anket>("Ankets.json", yeni, ankets);
                }
                catch (Exception ex)
               {

                    MessageBox.Show(ex.Message);
                }
                textBox3.Text = "";
                textBox2.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                dateTimePicker1.Value = DateTime.Now;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
           
                     
           
        

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            buttonclick1 = true;
            if (string.IsNullOrWhiteSpace(textBox1.Text)) { MessageBox.Show("Axtaris ucun metin daxil edin!!! "); return; }
            List<Anket> ankets = oxuma<Anket>("Ankets.json");
            if (ankets.Count == 0) { MessageBox.Show("Anket Listi Bosdu!!! "); return; }
            int j = -1;
            for (int i = 0; i < ankets.Count; i++)
            {
                if (ankets[i].Telefon == textBox1.Text) { j = i; break; }
            }
            if (j == -1) { MessageBox.Show("Axtaris Netice Vermedi!!! "); textBox1.Text = "";  return; }
            textBox3.Text = ankets[j].Soyad;
            textBox2.Text = ankets[j].Ad;
            textBox4.Text = ankets[j].Olke;
            textBox5.Text = ankets[j].Seher;
            textBox6.Text = ankets[j].Telefon;
            loadtext = ankets[j].Telefon;
            dateTimePicker1.Value = new DateTime(ankets[j].Date.Year, ankets[j].Date.Month, ankets[j].Date.Day, 0, 0, 0);
            radioButton1.Checked = ankets[j].Cins;
            radioButton2.Checked = !ankets[j].Cins;
            textBox1.Text = "";
        }
    }
}