using Newtonsoft.Json;
using System.Data;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
        }

        private void button12_MouseClick(object sender, MouseEventArgs e)
        {
            if(label2.Text != "") { label1.Text = "";label2.Text = ""; }
            if (label1.Text == "" && label1.Text != null) label1.Text = "1";
            else label1.Text = label1.Text + "1";
        }

        private void button13_MouseClick(object sender, MouseEventArgs e)
        {
            if (label2.Text != "") { label1.Text = ""; label2.Text = ""; }
            if (label1.Text == "" && label1.Text != null) label1.Text = "2";
            else label1.Text = label1.Text + "2";
        }

        private void button14_MouseClick(object sender, MouseEventArgs e)
        {
            if (label2.Text != "") { label1.Text = ""; label2.Text = ""; }
            if (label1.Text == "" && label1.Text != null) label1.Text = "3";
            else label1.Text = label1.Text + "3";
        }

        private void button9_MouseClick(object sender, MouseEventArgs e)
        {
            if (label2.Text != "") { label1.Text = ""; label2.Text = ""; }
            if (label1.Text == "" && label1.Text != null) label1.Text = "4";
            else label1.Text = label1.Text + "4";
        }

        private void button10_MouseClick(object sender, MouseEventArgs e)
        {
            if (label2.Text != "") { label1.Text = ""; label2.Text = ""; }
            if (label1.Text == "" && label1.Text != null) label1.Text = "5";
            else label1.Text = label1.Text + "5";
        }

        private void button11_MouseClick(object sender, MouseEventArgs e)
        {
            if (label2.Text != "") { label1.Text = ""; label2.Text = ""; }
            if (label1.Text == "" && label1.Text != null) label1.Text = "6";
            else label1.Text = label1.Text + "6";
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            if (label2.Text != "") { label1.Text = ""; label2.Text = ""; }
            if (label1.Text == "" && label1.Text != null) label1.Text = "7";
            else label1.Text = label1.Text + "7";
        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            if (label2.Text != "") { label1.Text = ""; label2.Text = ""; }
            if (label1.Text == "" && label1.Text != null) label1.Text = "8";
            else label1.Text = label1.Text + "8";
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            if (label2.Text != "") { label1.Text = ""; label2.Text = ""; }
            if (label1.Text == "" && label1.Text != null) label1.Text = "9";
            else label1.Text = label1.Text + "9";
        }

        private void button16_MouseClick(object sender, MouseEventArgs e)
        {
            if (label2.Text != "") { label1.Text = ""; label2.Text = ""; }
            if (label1.Text == "" && label1.Text != null) label1.Text = "0";
            else label1.Text = label1.Text + "0";
        }

        private void button15_MouseClick(object sender, MouseEventArgs e)
        {
            if (label2.Text != "") { label1.Text = ""; label2.Text = ""; }
            if (label1.Text == "" && label1.Text != null) label1.Text = "0.";
            else if (label1.Text[label1.Text.Length - 1] == '/' || label1.Text[label1.Text.Length - 1] == '*' || label1.Text[label1.Text.Length - 1] == '-' || label1.Text[label1.Text.Length - 1] == '+')
            {
                string a = "";
                for (int i = 0; i < label1.Text.Length; i++) a += label1.Text[i];
                a += "0.";
                label1.Text = a;
            }
            else if (label1.Text[label1.Text.Length - 1] == '.') { }
            else label1.Text += '.';
        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {
            if (label2.Text != "") { label1.Text = label2.Text; label2.Text = ""; }
            if (label1.Text == "" && label1.Text != null) MessageBox.Show("Evvelce Eded Daxil Etmelisiniz!!!");
            else
            {
                if (label1.Text == "0") { label1.Text = ""; MessageBox.Show("Sifira Bolme Yoxdur!!!"); }
                else if (label1.Text[label1.Text.Length - 1] == '.') MessageBox.Show("Noqteden Sonra Eded olmalidir!!!");
                else if (label1.Text[label1.Text.Length - 1] == '*' || label1.Text[label1.Text.Length - 1] == '-' || label1.Text[label1.Text.Length - 1] == '+')
                {
                    string a = "";
                    for (int i = 0; i < label1.Text.Length - 1; i++) a += label1.Text[i];
                    a += '/';
                    label1.Text = a;
                }
                else if (label1.Text[label1.Text.Length - 1] == '/') { }
                else label1.Text += '/';
            }
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            if (label2.Text != "") { label1.Text = label2.Text; label2.Text = ""; }
            if (label1.Text == "" && label1.Text != null) MessageBox.Show("Evvelce Eded Daxil Etmelisiniz!!!");
            else
            {

                if (label1.Text[label1.Text.Length - 1] == '.') MessageBox.Show("Noqteden Sonra Eded olmalidir!!!");
                else if (label1.Text[label1.Text.Length - 1] == '/' || label1.Text[label1.Text.Length - 1] == '-' || label1.Text[label1.Text.Length - 1] == '+')
                {
                    string a = "";
                    for (int i = 0; i < label1.Text.Length - 1; i++) a += label1.Text[i];
                    a += '*';
                    label1.Text = a;
                }
                else if (label1.Text[label1.Text.Length - 1] == '*') { }
                else label1.Text += '*';
            }
        }

        private void button8_MouseClick(object sender, MouseEventArgs e)
        {
            if (label2.Text != "") { label1.Text = label2.Text; label2.Text = ""; }
            if (label1.Text[label1.Text.Length - 1] == '.') MessageBox.Show("Noqteden Sonra Eded olmalidir!!!");
            else if (label1.Text[label1.Text.Length - 1] == '/' || label1.Text[label1.Text.Length - 1] == '*' || label1.Text[label1.Text.Length - 1] == '+')
            {
                string a = "";
                for (int i = 0; i < label1.Text.Length - 1; i++) a += label1.Text[i];
                a += '-';
                label1.Text = a;
            }
            else if (label1.Text[label1.Text.Length - 1] == '-') { }
            else label1.Text += '-';
        }

        private void button17_MouseClick(object sender, MouseEventArgs e)
        {
            if (label2.Text != "") { label1.Text = label2.Text; label2.Text = ""; }
            if (label1.Text[label1.Text.Length - 1] == '.') MessageBox.Show("Noqteden Sonra Eded olmalidir!!!");
            else if (label1.Text[label1.Text.Length - 1] == '/' || label1.Text[label1.Text.Length - 1] == '*' || label1.Text[label1.Text.Length - 1] == '-')
            {
                string a = "";
                for (int i = 0; i < label1.Text.Length - 1; i++) a += label1.Text[i];
                a += '+';
                label1.Text = a;
            }
            else if (label1.Text[label1.Text.Length - 1] == '+') { }
            else label1.Text += '+';
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            if (label1.Text == "" || label1.Text == null) MessageBox.Show("Silinmeli Hecne Yoxdu!!!");
            else if (label1.Text[label1.Text.Length - 1] == '.' && label1.Text[label1.Text.Length - 2] == '.') label1.Text = "0";
            else if (label1.Text == "0") label1.Text = "";
            else
            {
                string a = "";
                for (int i = 0; i < label1.Text.Length - 1; i++) a += label1.Text[i];
                label1.Text = a;
            }
        }

        private double hesabla(string text)
        {

            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), text);

            DataRow row = table.NewRow();
            table.Rows.Add(row);
            double result = double.Parse((string)row["expression"]);

            return result;
        }



        private void button18_MouseClick(object sender, MouseEventArgs e)
        {

            if (label1.Text[label1.Text.Length - 1] == '.' || label1.Text[label1.Text.Length - 1] == '/' || label1.Text[label1.Text.Length - 1] == '*' || label1.Text[label1.Text.Length - 1] == '-' || label1.Text[label1.Text.Length - 1] == '+')
            {
                string a = "";
                for (int i = 0; i < label1.Text.Length - 1; i++) a += label1.Text[i];
                label1.Text = a;
            }
            double netice = hesabla(label1.Text);
            label2.Text = netice.ToString();
            string yeni = label1.Text + " = " + label2.Text;
            yazma_oxuma<string>("History.json", yeni, oxuma<string>("History.json"));
        }

        private void button19_MouseClick(object sender, MouseEventArgs e)
        {
           
            if (button19.Text == "ON")
            {
                label3.BackColor = Color.Black; label3.ForeColor = Color.Magenta;
                button19.Text = "OFF";
                groupBox1.ForeColor = Color.White;
                button19.BackColor = Color.Magenta;
                groupBox1.BackColor = Color.Black;
                button7.BackColor = Color.Magenta;
                button4.BackColor = Color.Magenta;
                button8.BackColor = Color.Magenta;
                button17.BackColor = Color.Magenta;
                button18.BackColor = Color.Magenta;
                button20.BackColor = Color.Magenta;
                button20.ForeColor = Color.White;

                label1.BackColor = Color.Black;
                label1.ForeColor = Color.DodgerBlue;
                label2.ForeColor = Color.White;
                label2.BackColor = Color.Black;

                button1.ForeColor = Color.DodgerBlue;
                button1.BackColor = Color.DimGray;
                button2.BackColor = Color.DimGray;
                button2.ForeColor = Color.DodgerBlue;
                button5.ForeColor = Color.DodgerBlue;
                button5.BackColor = Color.DimGray;
                button6.BackColor = Color.DimGray;
                button6.ForeColor = Color.DodgerBlue;
                button3.ForeColor = Color.DodgerBlue;
                button3.BackColor = Color.DimGray;
                button9.BackColor = Color.DimGray;
                button9.ForeColor = Color.DodgerBlue;
                button10.ForeColor = Color.DodgerBlue;
                button10.BackColor = Color.DimGray;
                button11.BackColor = Color.DimGray;
                button11.ForeColor = Color.DodgerBlue;
                button12.ForeColor = Color.DodgerBlue;
                button12.BackColor = Color.DimGray;
                button13.BackColor = Color.DimGray;
                button13.ForeColor = Color.DodgerBlue;
                button14.ForeColor = Color.DodgerBlue;
                button14.BackColor = Color.DimGray;
                button16.BackColor = Color.DimGray;
                button16.ForeColor = Color.DodgerBlue;
                button15.ForeColor = Color.DodgerBlue;
                button15.BackColor = Color.DimGray;
            }
            else
            {
                label3.BackColor = Color.White; label3.ForeColor = Color.Blue;
                button19.Text = "ON";
                groupBox1.ForeColor = Color.Black;
                button19.BackColor = Color.Blue;
                groupBox1.BackColor = Color.White;
                button7.BackColor = Color.Blue;
                button4.BackColor = Color.Blue;
                button8.BackColor = Color.Blue;
                button17.BackColor = Color.Blue;
                button18.BackColor = Color.Blue;
                button20.BackColor = Color.Blue;
                button20.ForeColor = Color.White;

                label1.BorderStyle = BorderStyle.FixedSingle;
                label2.BorderStyle = BorderStyle.FixedSingle;
                label1.BackColor = Color.White;
                label2.BackColor = Color.White;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Blue;

                button1.ForeColor = Color.Black;
                button1.BackColor = Color.Silver;
                button2.BackColor = Color.Silver;
                button2.ForeColor = Color.Black;
                button5.ForeColor = Color.Black;
                button5.BackColor = Color.Silver;
                button6.BackColor = Color.Silver;
                button6.ForeColor = Color.Black;
                button3.ForeColor = Color.Black;
                button3.BackColor = Color.Silver;
                button9.BackColor = Color.Silver;
                button9.ForeColor = Color.Black;
                button10.ForeColor = Color.Black;
                button10.BackColor = Color.Silver;
                button11.BackColor = Color.Silver;
                button11.ForeColor = Color.Black;
                button12.ForeColor = Color.Black;
                button12.BackColor = Color.Silver;
                button13.BackColor = Color.Silver;
                button13.ForeColor = Color.Black;
                button14.ForeColor = Color.Black;
                button14.BackColor = Color.Silver;
                button16.BackColor = Color.Silver;
                button16.ForeColor = Color.Black;
                button15.ForeColor = Color.Black;
                button15.BackColor = Color.Silver;
            }

        }
        private void yazma_oxuma<t>(string fayl_adi, t yeni, List<t> data)
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

        private List<t> oxuma<t>(string fayl_ad)

        {
            List<t> data = new List<t>();
            if (!File.Exists(fayl_ad)) return data;

            string old_json = File.ReadAllText(fayl_ad);
            data = JsonConvert.DeserializeObject<List<t>>(old_json);
            return data;
        }


        private void button20_MouseClick(object sender, MouseEventArgs e)
        {
            if (button19.Text == "ON") { label3.BackColor = Color.White; label3.ForeColor = Color.Blue; }
            else if (button19.Text == "OFF") { label3.BackColor = Color.Black; label3.ForeColor = Color.Magenta; }
            if (!label3.Visible)
            {
                label3.Visible = true;
                string h = "";
                List<string> list = oxuma<string>("History.json");
                for (int i = 0; i < list.Count; i++)
                {
                    h += list[i];
                    h += '\n';
                }
                label3.Text = h;
               
            }
            else label3.Visible = false;
        }
    }
}