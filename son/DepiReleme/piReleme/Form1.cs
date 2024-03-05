using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Numerics;

namespace piReleme
{
    public partial class Form1 : Form
    {
        
   
        public Form1()
        {
            InitializeComponent();
            
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            var cipherInvertal = new Random();
            var TextToCipher = (string)textBox1.Text;
            // button1.Enabled = false;
            textBox2.Visible = true;
            // textBox2.PasswordChar = '*';
            textBox1.Text = TextToCipher;
            textBox2.Enabled = false;
            textBox2.Text = textBox1.Text;
            // textBox2.Text = Convert.ToString(TextToCipher.GetHashCode());
            textBox3.Text = textBox2.Text;
            //char[] chars = TextToCipher.ToCharArray();
            //textBox3.Text = chars.ToArray().ToString();
            // byte[] asciiBytes = Encoding.ASCII.GetBytes(TextToCipher);
            // textBox3.Text = asciiBytes.ToString();
            string value = TextToCipher;
            string s = TextToCipher;
            // byte[] ASCIIValues = Encoding.ASCII.GetBytes(s);
            //foreach (byte b in ASCIIValues)
            //{
            //  textBox3.Text=b.ToString();
            //}
            // byte[] asciiBytes = Encoding.ASCII.GetBytes("Y");
            //foreach (byte b in asciiBytes)
            //{
            //   textBox3.Text="" + b;
            //}
            var mesaj = textBox3.Text;   
            if (textBox1.Text.Contains("a"))
            { 
                textBox3.Text = textBox3.Text.Replace("a", "597");
            }

            if (textBox1.Text.Contains("b"))
            { 
                textBox3.Text = textBox3.Text.Replace("b", "598");
            }

            if (textBox1.Text.Contains("c"))
            {
                textBox3.Text = textBox3.Text.Replace("c", "599");
            }

            if (textBox1.Text.Contains("d"))
            {
                textBox3.Text = textBox3.Text.Replace("d", "600");
            }

            if (textBox1.Text.Contains("e"))
            {
                textBox3.Text = textBox3.Text.Replace("e", "601");
            }

            if (textBox1.Text.Contains("f"))
            {
                textBox3.Text = textBox3.Text.Replace("f", "602");
            }

            if (textBox1.Text.Contains("g"))
            {
                textBox3.Text = textBox3.Text.Replace("g", "603");
            }

            if (textBox1.Text.Contains("h"))
            {
                textBox3.Text = textBox3.Text.Replace("h", "604");
            }

            if (textBox1.Text.Contains("i"))
            {
                textBox3.Text = textBox3.Text.Replace("i", "605");
            }

            if (textBox1.Text.Contains("j"))
            {
                textBox3.Text = textBox3.Text.Replace("j", "606");
            }

            if (textBox1.Text.Contains("k"))
            {
                textBox3.Text = textBox3.Text.Replace("k", "607");
            }

            if (textBox1.Text.Contains("l"))
            {
                textBox3.Text = textBox3.Text.Replace("l", "608");
            }


            if (textBox1.Text.Contains("m"))
            {
                textBox3.Text = textBox3.Text.Replace("m", "609");
            }

            if (textBox1.Text.Contains("n"))
            {
                textBox3.Text = textBox3.Text.Replace("n", "743");
            }

            if (textBox1.Text.Contains("o"))
            {
                textBox3.Text = textBox3.Text.Replace("o", "611");
            }

            if (textBox1.Text.Contains("p"))
            {
                textBox3.Text = textBox3.Text.Replace("p", "612");
            }

            if (textBox1.Text.Contains("q"))
            {
                textBox3.Text = textBox3.Text.Replace("q", "613");
            }

            if (textBox1.Text.Contains("r"))
            {
                textBox3.Text = textBox3.Text.Replace("r", "614");
            }

            if (textBox1.Text.Contains("s"))
            {
                textBox3.Text = textBox3.Text.Replace("s", "615");
            }

            if (textBox1.Text.Contains("t"))
            {
                textBox3.Text = textBox3.Text.Replace("t", "716");
            }

            if (textBox1.Text.Contains("u"))
            {
                textBox3.Text = textBox3.Text.Replace("u", "617");
            }

            if (textBox1.Text.Contains("v"))
            {
                textBox3.Text = textBox3.Text.Replace("v", "618");
            }

            if (textBox1.Text.Contains("w"))
            {
                textBox3.Text = textBox3.Text.Replace("w", "619");
            }

            if (textBox1.Text.Contains("x"))
            {
                textBox3.Text = textBox3.Text.Replace("x", "620");
            }

            if (textBox1.Text.Contains("y"))
            {
                textBox3.Text = textBox3.Text.Replace("y", "621");
            }

            if (textBox1.Text.Contains("z"))
            {
                textBox3.Text = textBox3.Text.Replace("z", "622");
            }

            if (textBox1.Text.Contains(" "))
            {
                textBox3.Text = textBox3.Text.Replace(" ", "532");
            }

            if (textBox1.Text.Contains("!"))
            {
                textBox3.Text = textBox3.Text.Replace("!", "533");
            }

            if (textBox1.Text.Contains("\"\""))
            {
                textBox3.Text = textBox3.Text.Replace("\"\"", "534");
            }

            if (textBox1.Text.Contains("#"))
            {
                textBox3.Text = textBox3.Text.Replace("#", "535");
            }

            if (textBox1.Text.Contains("{"))
            {
                textBox3.Text = textBox3.Text.Replace("$", "536");
            }

            if (textBox1.Text.Contains("%"))
            {
                textBox3.Text = textBox3.Text.Replace("%", "537");
            }

            if (textBox1.Text.Contains("&"))
            {
                textBox3.Text = textBox3.Text.Replace("&", "538");
            }

            if (textBox1.Text.Contains("'"))
            {
                textBox3.Text = textBox3.Text.Replace("'", "539");
            }

            if (textBox1.Text.Contains("("))
            {
                textBox3.Text = textBox3.Text.Replace("(", "540");
            }

            if (textBox1.Text.Contains(")"))
            {
                textBox3.Text = textBox3.Text.Replace(")", "541");
            }

            if (textBox1.Text.Contains("*"))
            {
                textBox3.Text = textBox3.Text.Replace("*", "542");
            }

            if (textBox1.Text.Contains("+"))
            {
                textBox3.Text = textBox3.Text.Replace("+", "543");
            }

            if (textBox1.Text.Contains(","))
            {
                textBox3.Text = textBox3.Text.Replace(",", "544");
            }

            if (textBox1.Text.Contains("-"))
            {
                textBox3.Text = textBox3.Text.Replace("-", "545");
            }

            if (textBox1.Text.Contains("."))
            {
                textBox3.Text = textBox3.Text.Replace(".", "546");
            }

            if (textBox1.Text.Contains("/"))
            {
                textBox3.Text = textBox3.Text.Replace("/", "547");
            }

            if (textBox1.Text.Contains("0"))
            {
                textBox3.Text = textBox3.Text.Replace("0", "548");
            }

            if (textBox1.Text.Contains("1"))
            {
                textBox3.Text = textBox3.Text.Replace("1", "849");
            }

            if (textBox1.Text.Contains("2"))
            {
                textBox3.Text = textBox3.Text.Replace("2", "850");
            }

            if (textBox1.Text.Contains("3"))
            {
                textBox3.Text = textBox3.Text.Replace("3", "851");
            }

            if (textBox1.Text.Contains("4"))
            {
                textBox3.Text = textBox3.Text.Replace("4", "852");
            }

            if (textBox1.Text.Contains("5"))
            {
                textBox3.Text = textBox3.Text.Replace("5", "853");
            }

            if (textBox1.Text.Contains("6"))
            {
                textBox3.Text = textBox3.Text.Replace("6", "854");
            }

            if (textBox1.Text.Contains("7"))
            {
                textBox3.Text = textBox3.Text.Replace("7", "855");
            }

            if (textBox1.Text.Contains("8"))
            {
                textBox3.Text = textBox3.Text.Replace("8", "856");
            }

            if (textBox1.Text.Contains("9"))
            {
                textBox3.Text = textBox3.Text.Replace("9", "857");
            }

            if (textBox1.Text.Contains(":"))
            {
                textBox3.Text = textBox3.Text.Replace(":", "858");
            }

            if (textBox1.Text.Contains(";"))
            {
                textBox3.Text = textBox3.Text.Replace(";", "859");
            }

            if (textBox1.Text.Contains("<"))
            {
                textBox3.Text = textBox3.Text.Replace("<", "360");
            }

            if (textBox1.Text.Contains("="))
            {
                textBox3.Text = textBox3.Text.Replace("=", "561");
            }

            if (textBox1.Text.Contains(">"))
            {
                textBox3.Text = textBox3.Text.Replace(">", "562");
            }

            if (textBox1.Text.Contains("?"))
            {
                textBox3.Text = textBox3.Text.Replace("?", "563");
            }

            if (textBox1.Text.Contains("@"))
            {
                textBox3.Text = textBox3.Text.Replace("@", "564");
            }

            if (textBox1.Text.Contains("A"))
            {
                textBox3.Text = textBox3.Text.Replace("A", "365");
            }

            if (textBox1.Text.Contains("B"))
            {
                textBox3.Text = textBox3.Text.Replace("B", "566");
            }

            if (textBox1.Text.Contains("C"))
            {
                textBox3.Text = textBox3.Text.Replace("C", "567");
            }

            if (textBox1.Text.Contains("D"))
            {
                textBox3.Text = textBox3.Text.Replace("D", "468");
            }

            if (textBox1.Text.Contains("E"))
            {
                textBox3.Text = textBox3.Text.Replace("E", "569");
            }

            if (textBox1.Text.Contains("F"))
            {
                textBox3.Text = textBox3.Text.Replace("F", "570");
            }

            if (textBox1.Text.Contains("G"))
            {
                textBox3.Text = textBox3.Text.Replace("G", "571");
            }

            if (textBox1.Text.Contains("H"))
            {
                textBox3.Text = textBox3.Text.Replace("H", "572");
            }

            if (textBox1.Text.Contains("I"))
            {
                textBox3.Text = textBox3.Text.Replace("I", "573");
            }

            if (textBox1.Text.Contains("J"))
            {
                textBox3.Text = textBox3.Text.Replace("J", "574");
            }

            if (textBox1.Text.Contains("K"))
            {
                textBox3.Text = textBox3.Text.Replace("K", "575");
            }

            if (textBox1.Text.Contains("L"))
            {
                textBox3.Text = textBox3.Text.Replace("L", "576");
            }

            if (textBox1.Text.Contains("M"))
            {
                textBox3.Text = textBox3.Text.Replace("M", "577");
            }

            if (textBox1.Text.Contains("N"))
            {
                textBox3.Text = textBox3.Text.Replace("N", "578");
            }

            if (textBox1.Text.Contains("O"))
            {
                textBox3.Text = textBox3.Text.Replace("O", "579");
            }

            if (textBox1.Text.Contains("P"))
            {
                textBox3.Text = textBox3.Text.Replace("P", "580");
            }
            
            if (textBox1.Text.Contains("Q"))
            {
                textBox3.Text = textBox3.Text.Replace("Q", "581");
            }

            if (textBox1.Text.Contains("R"))
            {
                textBox3.Text = textBox3.Text.Replace("R", "582");
            }

            if (textBox1.Text.Contains("S"))
            {
                textBox3.Text = textBox3.Text.Replace("S", "583");
            }

            if (textBox1.Text.Contains("T"))
            {
                textBox3.Text = textBox3.Text.Replace("T", "584");
            }

            if (textBox1.Text.Contains("U"))
            {
                textBox3.Text = textBox3.Text.Replace("U", "585");
            }

            if (textBox1.Text.Contains("V"))
            {
                textBox3.Text = textBox3.Text.Replace("V", "586");
            }

            if (textBox1.Text.Contains("W"))
            {
                textBox3.Text = textBox3.Text.Replace("W", "587");
            }

            if (textBox1.Text.Contains("X"))
            {
                textBox3.Text = textBox3.Text.Replace("X", "784");
            }

            if (textBox1.Text.Contains("Y"))
            {
                textBox3.Text = textBox3.Text.Replace("Y", "589");
            }

            if (textBox1.Text.Contains("Z"))
            {
                textBox3.Text = textBox3.Text.Replace("Z", "590");
            }

            if (textBox1.Text.Contains("["))
            {
                textBox3.Text = textBox3.Text.Replace("[", "591");
            }

            if (textBox1.Text.Contains("\\"))
            {
                textBox3.Text = textBox3.Text.Replace("\\", "592");
            }

            if (textBox1.Text.Contains("]"))
            {
                textBox3.Text = textBox3.Text.Replace("]", "593");
            }

            if (textBox1.Text.Contains("^"))
            {
                textBox3.Text = textBox3.Text.Replace("^", "594");
            }

            if (textBox1.Text.Contains("_"))
            {
                textBox3.Text = textBox3.Text.Replace("_", "595");
            }

            if (textBox1.Text.Contains("`"))
            {
                textBox3.Text = textBox3.Text.Replace("`", "596");
            }

            if (textBox1.Text.Contains("Ç"))
            {
                textBox3.Text = textBox3.Text.Replace("Ç", "128");
            }

            if (textBox1.Text.Contains("ü"))
            {
                textBox3.Text = textBox3.Text.Replace("ü", "129");
            }

            if (textBox1.Text.Contains("é"))
            {
                textBox3.Text = textBox3.Text.Replace("é", "130");
            }

            if (textBox1.Text.Contains("â"))
            {
                textBox3.Text = textBox3.Text.Replace("â", "131");
            }

            if (textBox1.Text.Contains("ä"))
            {
                textBox3.Text = textBox3.Text.Replace("ä", "132");
            }

            if (textBox1.Text.Contains("à"))
            {
                textBox3.Text = textBox3.Text.Replace("à", "133");
            }

            if (textBox1.Text.Contains("ç"))
            {
                textBox3.Text = textBox3.Text.Replace("ç", "135");
            }

            if (textBox1.Text.Contains("ê"))
            {
                textBox3.Text = textBox3.Text.Replace("ê", "136");
            }

            if (textBox1.Text.Contains("ë"))
            {
                textBox3.Text = textBox3.Text.Replace("ë", "137");
            }

            if (textBox1.Text.Contains("è"))
            {
                textBox3.Text = textBox3.Text.Replace("è", "138");
            }

            if (textBox1.Text.Contains("ï"))
            {
                textBox3.Text = textBox3.Text.Replace("ï", "139");
            }

            if (textBox1.Text.Contains("î"))
            {
                textBox3.Text = textBox3.Text.Replace("î", "140");
            }

            if (textBox1.Text.Contains("ı"))
            {
                textBox3.Text = textBox3.Text.Replace("ı", "141");
            }

            if (textBox1.Text.Contains("Ä"))
            {
                textBox3.Text = textBox3.Text.Replace("Ä", "142");
            }

            if (textBox1.Text.Contains("É"))
            {
                textBox3.Text = textBox3.Text.Replace("É", "144");
            }

            if (textBox1.Text.Contains("æ"))
            {
                textBox3.Text = textBox3.Text.Replace("æ", "145");
            }

            if (textBox1.Text.Contains("Æ"))
            {
                textBox3.Text = textBox3.Text.Replace("Æ", "146");
            }

            if (textBox1.Text.Contains("ô"))
            {
                textBox3.Text = textBox3.Text.Replace("ô", "147");
            }

            if (textBox1.Text.Contains("ö"))
            {
                textBox3.Text = textBox3.Text.Replace("ö", "148");
            }

            if (textBox1.Text.Contains("ò"))
            {
                textBox3.Text = textBox3.Text.Replace("ò", "149");
            }

            if (textBox1.Text.Contains("û"))
            {
                textBox3.Text = textBox3.Text.Replace("û", "150");
            }

            if (textBox1.Text.Contains("ù"))
            {
                textBox3.Text = textBox3.Text.Replace("ù", "151");
            }

            if (textBox1.Text.Contains("Ö"))
            {
                textBox3.Text = textBox3.Text.Replace("Ö", "453");
            }

            if (textBox1.Text.Contains("Ü"))
            {
                textBox3.Text = textBox3.Text.Replace("Ü", "154");
            }

            if (textBox1.Text.Contains("½"))
            {
                textBox3.Text = textBox3.Text.Replace("½", "171");
            }

            if (textBox1.Text.Contains("İ"))
            {
                textBox3.Text = textBox3.Text.Replace("İ", "172");
            }

            if (textBox1.Text.Contains("ğ"))
            {
                textBox3.Text = textBox3.Text.Replace("ğ", "287");
            }

            if (textBox1.Text.Contains("Ğ"))
            {
                textBox3.Text = textBox3.Text.Replace("Ğ", "286");
            }

            if (textBox1.Text.Contains("ş"))
            {
                textBox3.Text = textBox3.Text.Replace("ş", "951");
            }

            if (textBox1.Text.Contains("Ş"))
            {
                textBox3.Text = textBox3.Text.Replace("Ş", "350");
            }



            string[] allLines = File.ReadAllLines(Application.StartupPath+ "\\pi.txt");
            Random rnd1 = new Random();
            string ad=(allLines[rnd1.Next(allLines.Length)]);

            byte[] byteArray = new byte[1024];
            var file = Application.StartupPath + "\\pi.txt";
            using (BinaryReader reader = new BinaryReader(new FileStream(file, FileMode.Open)))
            {
                Random rn = new Random();
                Random r = new Random();
                int rInt = r.Next(100000, 999999); //for ints
                int rnInt = r.Next(512, 999);

                reader.BaseStream.Seek(rInt, SeekOrigin.Begin);
                reader.Read(byteArray, 0, rnInt);
                
                kacinciBas.Text = rInt.ToString();
                basSayisi.Text = rnInt.ToString();
            }
            //int rslt2;
            
            string result = System.Text.Encoding.UTF8.GetString(byteArray);
            if (result.StartsWith("0"))
            {
                using (BinaryReader reader = new BinaryReader(new FileStream(file, FileMode.Open)))
                {
                    Random rn = new Random();
                    Random r = new Random();
                    int rInt = r.Next(100000, 999999); //for ints
                    int rnInt = r.Next(512, 999);

                    reader.BaseStream.Seek(rInt, SeekOrigin.Begin);
                    reader.Read(byteArray, 0, rnInt);

                    kacinciBas.Text = rInt.ToString();
                    basSayisi.Text = rnInt.ToString();
                }
                //int rslt2;
            }
            else
            {
                textBox4.Text = result;
                string coz = kacinciBas.Text + basSayisi.Text;
                textBox6.Text = textBox4.Text;
                //textBox5.Text = mesaj;
                // textBox7.Text = (Convert.ToInt32(mesaj) + Convert.ToInt32(textBox6.Text)).ToString();
                //rslt2 = int.Parse(textBox6.Text);
                BigInteger total;
                total = BigInteger.Parse(textBox3.Text) + BigInteger.Parse(textBox6.Text);
                textBox7.Text = total.ToString() + coz.ToString();
            }
         //   if (textBox1.Text.Length < 50)
           // {
             //   textBox5.Text = textBox6.Text + textBox3.Text;
            //}
            //else
            //{
             //   textBox5.Text = textBox3.Text + textBox6.Text;
            //}
            
            //else 
            //{
            //    textBox5.Text = textBox3.Text + textBox6.Text;
            //}
            // total = int.Parse(textBox3.Text) + int.Parse(textBox6.Text);
            //textBox7.Text = total.ToString();
            


            // textBox3.Text = accip;


            // if (textBox1.Text.Length < 5)
            //{
            // (Convert.ToInt32(accip) + Convert.ToInt32(rsl2).ToString())
            //}


            // byte[] asciiBytes = Encoding.ASCII.GetBytes(value);
            // string StringByte = BitConverter.ToString(asciiBytes);


            //  textBox3.Text = StringByte;
            //byte[] byteArray = new byte[10];
            //var file = Application.StartupPath + "\\pi.txt";
            //using (BinaryReader reader = new BinaryReader(new FileStream(file, FileMode.Open)))
            //{
            //   reader.BaseStream.Seek(ad, SeekOrigin.Begin);
            //  reader.Read(byteArray, 0, 10);
            //}

            //            string result = System.Text.Encoding.UTF8.GetString(byteArray);
            //          textBox2.Text = result;
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

    
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           
             //   MessageBox.Show("Pi Kodunun doğru oluşabilmesi için sayı kullanımı yasaktır, sayılarınızı örn: 9 yerine dokuz şeklinde giriniz!");
              //  textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
               // textBox1.Text = string.Empty;
                

            
    
                button1.Enabled = true;
        }

        private void form2button_Click(object sender, EventArgs e)
        {
            Form2dePireleme form2 = new Form2dePireleme();
            form2.Show();
          //  this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Mesajınızın Uzunluğu, Şifreleme, Deşifreleme İşlemlerinin Uzunluğunu Etkiler.", "Uyarı");
            MessageBox.Show("Pi Kodunun doğru oluşabilmesi için sayı kullanımı yasaktır, sayılarınızı örn: 9 yerine dokuz şeklinde giriniz!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Hand);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
