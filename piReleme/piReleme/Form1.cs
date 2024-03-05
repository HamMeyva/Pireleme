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
            MessageBox.Show("Mesajınızın Uzunluğu, Şifreleme İşleminin Uzunluğunu Etkiler.","Uyarı");
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
                textBox3.Text = textBox3.Text.Replace("a", "97");
            }

            if (textBox1.Text.Contains("b"))
            { 
                textBox3.Text = textBox3.Text.Replace("b", "98");
            }

            if (textBox1.Text.Contains("c"))
            {
                textBox3.Text = textBox3.Text.Replace("c", "99");
            }

            if (textBox1.Text.Contains("d"))
            {
                textBox3.Text = textBox3.Text.Replace("d", "100");
            }

            if (textBox1.Text.Contains("e"))
            {
                textBox3.Text = textBox3.Text.Replace("e", "101");
            }

            if (textBox1.Text.Contains("f"))
            {
                textBox3.Text = textBox3.Text.Replace("f", "102");
            }

            if (textBox1.Text.Contains("g"))
            {
                textBox3.Text = textBox3.Text.Replace("g", "103");
            }

            if (textBox1.Text.Contains("h"))
            {
                textBox3.Text = textBox3.Text.Replace("h", "104");
            }

            if (textBox1.Text.Contains("i"))
            {
                textBox3.Text = textBox3.Text.Replace("i", "105");
            }

            if (textBox1.Text.Contains("j"))
            {
                textBox3.Text = textBox3.Text.Replace("j", "106");
            }

            if (textBox1.Text.Contains("k"))
            {
                textBox3.Text = textBox3.Text.Replace("k", "107");
            }

            if (textBox1.Text.Contains("l"))
            {
                textBox3.Text = textBox3.Text.Replace("l", "108");
            }


            if (textBox1.Text.Contains("m"))
            {
                textBox3.Text = textBox3.Text.Replace("m", "109");
            }

            if (textBox1.Text.Contains("n"))
            {
                textBox3.Text = textBox3.Text.Replace("n", "110");
            }

            if (textBox1.Text.Contains("o"))
            {
                textBox3.Text = textBox3.Text.Replace("o", "111");
            }

            if (textBox1.Text.Contains("p"))
            {
                textBox3.Text = textBox3.Text.Replace("p", "112");
            }

            if (textBox1.Text.Contains("q"))
            {
                textBox3.Text = textBox3.Text.Replace("q", "113");
            }

            if (textBox1.Text.Contains("r"))
            {
                textBox3.Text = textBox3.Text.Replace("r", "114");
            }

            if (textBox1.Text.Contains("s"))
            {
                textBox3.Text = textBox3.Text.Replace("s", "115");
            }

            if (textBox1.Text.Contains("t"))
            {
                textBox3.Text = textBox3.Text.Replace("t", "116");
            }

            if (textBox1.Text.Contains("u"))
            {
                textBox3.Text = textBox3.Text.Replace("u", "117");
            }

            if (textBox1.Text.Contains("v"))
            {
                textBox3.Text = textBox3.Text.Replace("v", "118");
            }

            if (textBox1.Text.Contains("w"))
            {
                textBox3.Text = textBox3.Text.Replace("w", "119");
            }

            if (textBox1.Text.Contains("x"))
            {
                textBox3.Text = textBox3.Text.Replace("x", "120");
            }

            if (textBox1.Text.Contains("y"))
            {
                textBox3.Text = textBox3.Text.Replace("y", "121");
            }

            if (textBox1.Text.Contains("z"))
            {
                textBox3.Text = textBox3.Text.Replace("z", "122");
            }

            if (textBox1.Text.Contains(" "))
            {
                textBox3.Text = textBox3.Text.Replace(" ", "32");
            }

            if (textBox1.Text.Contains("!"))
            {
                textBox3.Text = textBox3.Text.Replace("!", "33");
            }


            if (textBox1.Text.Contains("\"\""))
            {
                textBox3.Text = textBox3.Text.Replace("\"\"", "34");
            }

            if (textBox1.Text.Contains("#"))
            {
                textBox3.Text = textBox3.Text.Replace("#", "35");
            }

            if (textBox1.Text.Contains("$"))
            {
                textBox3.Text = textBox3.Text.Replace("$", "36");
            }

            if (textBox1.Text.Contains("%"))
            {
                textBox3.Text = textBox3.Text.Replace("%", "37");
            }

            if (textBox1.Text.Contains("&"))
            {
                textBox3.Text = textBox3.Text.Replace("&", "38");
            }

            if (textBox1.Text.Contains("'"))
            {
                textBox3.Text = textBox3.Text.Replace("'", "39");
            }

            if (textBox1.Text.Contains("("))
            {
                textBox3.Text = textBox3.Text.Replace("(", "40");
            }

            if (textBox1.Text.Contains(")"))
            {
                textBox3.Text = textBox3.Text.Replace(")", "41");
            }

            if (textBox1.Text.Contains("*"))
            {
                textBox3.Text = textBox3.Text.Replace("*", "42");
            }

            if (textBox1.Text.Contains("+"))
            {
                textBox3.Text = textBox3.Text.Replace("+", "43");
            }

            if (textBox1.Text.Contains(","))
            {
                textBox3.Text = textBox3.Text.Replace(",", "44");
            }

            if (textBox1.Text.Contains("-"))
            {
                textBox3.Text = textBox3.Text.Replace("-", "45");
            }

            if (textBox1.Text.Contains("."))
            {
                textBox3.Text = textBox3.Text.Replace(".", "46");
            }

            if (textBox1.Text.Contains("/"))
            {
                textBox3.Text = textBox3.Text.Replace("/", "47");
            }

            if (textBox1.Text.Contains("0"))
            {
                textBox3.Text = textBox3.Text.Replace("0", "48");
            }

            if (textBox1.Text.Contains("1"))
            {
                textBox3.Text = textBox3.Text.Replace("1", "49");
            }

            if (textBox1.Text.Contains("2"))
            {
                textBox3.Text = textBox3.Text.Replace("2", "50");
            }

            if (textBox1.Text.Contains("3"))
            {
                textBox3.Text = textBox3.Text.Replace("3", "51");
            }

            if (textBox1.Text.Contains("4"))
            {
                textBox3.Text = textBox3.Text.Replace("4", "52");
            }

            if (textBox1.Text.Contains("5"))
            {
                textBox3.Text = textBox3.Text.Replace("5", "53");
            }

            if (textBox1.Text.Contains("6"))
            {
                textBox3.Text = textBox3.Text.Replace("6", "54");
            }

            if (textBox1.Text.Contains("7"))
            {
                textBox3.Text = textBox3.Text.Replace("7", "55");
            }

            if (textBox1.Text.Contains("8"))
            {
                textBox3.Text = textBox3.Text.Replace("8", "56");
            }

            if (textBox1.Text.Contains("9"))
            {
                textBox3.Text = textBox3.Text.Replace("9", "57");
            }

            if (textBox1.Text.Contains(":"))
            {
                textBox3.Text = textBox3.Text.Replace(":", "58");
            }

            if (textBox1.Text.Contains(";"))
            {
                textBox3.Text = textBox3.Text.Replace(".", "59");
            }

            if (textBox1.Text.Contains("<"))
            {
                textBox3.Text = textBox3.Text.Replace(".", "60");
            }

            if (textBox1.Text.Contains("="))
            {
                textBox3.Text = textBox3.Text.Replace("=", "61");
            }

            if (textBox1.Text.Contains(">"))
            {
                textBox3.Text = textBox3.Text.Replace(".", "62");
            }

            if (textBox1.Text.Contains("?"))
            {
                textBox3.Text = textBox3.Text.Replace("?", "63");
            }

            if (textBox1.Text.Contains("@"))
            {
                textBox3.Text = textBox3.Text.Replace("@", "64");
            }

            if (textBox1.Text.Contains("A"))
            {
                textBox3.Text = textBox3.Text.Replace("A", "65");
            }

            if (textBox1.Text.Contains("B"))
            {
                textBox3.Text = textBox3.Text.Replace("B", "66");
            }

            if (textBox1.Text.Contains("C"))
            {
                textBox3.Text = textBox3.Text.Replace("C", "67");
            }

            if (textBox1.Text.Contains("D"))
            {
                textBox3.Text = textBox3.Text.Replace("D", "68");
            }

            if (textBox1.Text.Contains("E"))
            {
                textBox3.Text = textBox3.Text.Replace("E", "69");
            }

            if (textBox1.Text.Contains("F"))
            {
                textBox3.Text = textBox3.Text.Replace("F", "70");
            }

            if (textBox1.Text.Contains("G"))
            {
                textBox3.Text = textBox3.Text.Replace("G", "71");
            }

            if (textBox1.Text.Contains("H"))
            {
                textBox3.Text = textBox3.Text.Replace("H", "72");
            }

            if (textBox1.Text.Contains("I"))
            {
                textBox3.Text = textBox3.Text.Replace("I", "73");
            }

            if (textBox1.Text.Contains("J"))
            {
                textBox3.Text = textBox3.Text.Replace("J", "74");
            }

            if (textBox1.Text.Contains("K"))
            {
                textBox3.Text = textBox3.Text.Replace("L", "75");
            }

            if (textBox1.Text.Contains("L"))
            {
                textBox3.Text = textBox3.Text.Replace("L", "76");
            }

            if (textBox1.Text.Contains("M"))
            {
                textBox3.Text = textBox3.Text.Replace("M", "77");
            }

            if (textBox1.Text.Contains("N"))
            {
                textBox3.Text = textBox3.Text.Replace("N", "78");
            }

            if (textBox1.Text.Contains("O"))
            {
                textBox3.Text = textBox3.Text.Replace("O", "79");
            }

            if (textBox1.Text.Contains("P"))
            {
                textBox3.Text = textBox3.Text.Replace("P", "80");
            }
            
            if (textBox1.Text.Contains("Q"))
            {
                textBox3.Text = textBox3.Text.Replace("Q", "81");
            }

            if (textBox1.Text.Contains("R"))
            {
                textBox3.Text = textBox3.Text.Replace("R", "82");
            }

            if (textBox1.Text.Contains("S"))
            {
                textBox3.Text = textBox3.Text.Replace("S", "83");
            }

            if (textBox1.Text.Contains("T"))
            {
                textBox3.Text = textBox3.Text.Replace("T", "84");
            }

            if (textBox1.Text.Contains("U"))
            {
                textBox3.Text = textBox3.Text.Replace("U", "85");
            }

            if (textBox1.Text.Contains("V"))
            {
                textBox3.Text = textBox3.Text.Replace("V", "86");
            }

            if (textBox1.Text.Contains("W"))
            {
                textBox3.Text = textBox3.Text.Replace("W", "87");
            }

            if (textBox1.Text.Contains("X"))
            {
                textBox3.Text = textBox3.Text.Replace("X", "88");
            }

            if (textBox1.Text.Contains("Y"))
            {
                textBox3.Text = textBox3.Text.Replace("Y", "89");
            }

            if (textBox1.Text.Contains("Z"))
            {
                textBox3.Text = textBox3.Text.Replace("Z", "90");
            }

            if (textBox1.Text.Contains("["))
            {
                textBox3.Text = textBox3.Text.Replace("[", "91");
            }

            if (textBox1.Text.Contains("\\"))
            {
                textBox3.Text = textBox3.Text.Replace("\\", "92");
            }

            if (textBox1.Text.Contains("]"))
            {
                textBox3.Text = textBox3.Text.Replace("]", "93");
            }

            if (textBox1.Text.Contains("^"))
            {
                textBox3.Text = textBox3.Text.Replace("^", "94");
            }

            if (textBox1.Text.Contains("_"))
            {
                textBox3.Text = textBox3.Text.Replace("_", "95");
            }

            if (textBox1.Text.Contains("`"))
            {
                textBox3.Text = textBox3.Text.Replace("`", "96");
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
                textBox3.Text = textBox3.Text.Replace("é", "135");
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
                textBox3.Text = textBox3.Text.Replace("Ö", "153");
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



            string[] allLines = File.ReadAllLines(Application.StartupPath+ "\\pi.txt");
            Random rnd1 = new Random();
            string ad=(allLines[rnd1.Next(allLines.Length)]);

            byte[] byteArray = new byte[1024];
            var file = Application.StartupPath + "\\pi.txt";
            using (BinaryReader reader = new BinaryReader(new FileStream(file, FileMode.Open)))
            {
                Random rn = new Random();
                Random r = new Random();
                int rInt = r.Next(0, 1000000); //for ints
                int rnInt = r.Next(256, 768);

                reader.BaseStream.Seek(rInt, SeekOrigin.Begin);
                reader.Read(byteArray, 0, rnInt);
            }
            //int rslt2;
            string result = System.Text.Encoding.UTF8.GetString(byteArray);
            textBox4.Text = result;
           
            textBox6.Text = textBox4.Text;
            //textBox5.Text = mesaj;
            // textBox7.Text = (Convert.ToInt32(mesaj) + Convert.ToInt32(textBox6.Text)).ToString();
            //rslt2 = int.Parse(textBox6.Text);
            BigInteger total;
            total =BigInteger.Parse(textBox3.Text) +BigInteger.Parse (textBox6.Text);
            textBox7.Text = total.ToString();

            if (textBox1.Text.Length < 50)
            {
                textBox5.Text = textBox6.Text + textBox3.Text;
            }

            
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
            button1.Enabled = true;
        }

      
    }
}
