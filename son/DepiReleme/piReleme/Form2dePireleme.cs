using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Numerics;

namespace piReleme
{
    public partial class Form2dePireleme : Form
    {
        public Form2dePireleme()
        {
            InitializeComponent();
            MessageBox.Show("Lütfen, pi kodunuzda düzenleme yapmadan, eksiksiz giriniz/Yapıştırınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void dePirele_Click(object sender, EventArgs e)
        {
            //iyi bilirdik derler ardımdan, bundan büyük yalan yooook1!!1!1 / maNga'm
            if (textBox1.Text.Length < 20)
            {
                MessageBox.Show("Pi kodu 50 karakterden kısa olamaz", "Uyarı");
            }

            else if (textBox1.Text=="")
            {
                MessageBox.Show("Lütfen Mesajınızı giriniz","Uyarı");
            }
            else
            { 
            string tumDepireleyici = textBox1.Text;
            tumDepireleyici = tumDepireleyici.Substring(tumDepireleyici.Length - 9);
            toplam.Text = tumDepireleyici.ToString();

            string uzunluk = toplam.Text;
            uzunluk = uzunluk.Substring(uzunluk.Length - 3);
            denItibaren.Text = uzunluk.ToString();
            string bas = toplam.Text;
            bas = bas.Substring(0,6);
            kacBasamak.Text = bas.ToString();
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length-9);    
         //   tumDepireleyici = tumDepireleyici.Remove(tumDepireleyici.Length - 9);
            toplam.Text = tumDepireleyici.ToString();
            string[] allLines = File.ReadAllLines(Application.StartupPath + "\\pi.txt");
                        Random rnd1 = new Random();
                        string ad = (allLines[rnd1.Next(allLines.Length)]);

                        byte[] byteArray = new byte[1024];
                        var file = Application.StartupPath + "\\pi.txt";
                        using (BinaryReader reader = new BinaryReader(new FileStream(file, FileMode.Open)))
                        {
                            int rInt = int.Parse(kacBasamak.Text) ;
                            int rnInt = int.Parse(denItibaren.Text);
                            reader.BaseStream.Seek(rInt, SeekOrigin.Begin);
                            reader.Read(byteArray, 0, rnInt);
                        }
                        //int rslt2;
                        string result = System.Text.Encoding.UTF8.GetString(byteArray);
                        mesaj.Text = result;
                        BigInteger an =BigInteger.Parse(textBox1.Text) - BigInteger.Parse(mesaj.Text);
                        sonmesajBinary.Text = an.ToString();
                // mesaj.Text = a.ToString();
            }
            dePirele.Enabled = false;
            okunanMesaj.Text = sonmesajBinary.Text;


            string a;
            a = okunanMesaj.Text;
            if (a.Contains("597"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("597", "a");
          }

          if (a.Contains("598"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("598", "b");
          }

          if (a.Contains("599"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("599", "c");
          }

          if (a.Contains("600"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("600", "d");
          }

          if (a.Contains("601"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("601", "e");
          }

          if (a.Contains("602"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("602", "f");
          }

          if (a.Contains("603"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("603", "g");
          }

          if (a.Contains("604"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("604", "h");
          }

          if (a.Contains("605"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("605", "i");
          }

          if (a.Contains("606"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("606", "j");
          }

          if (a.Contains("607"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("607", "k");
          }

          if (a.Contains("608"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("608", "l");
          }

          if (a.Contains("609"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("609", "m");
          }

          if (a.Contains("743"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("743", "n");
          }

          if (a.Contains("611"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("611", "o");
          }

          if (a.Contains("612"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("612", "p");
          }

          if (a.Contains("613"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("613", "q");
          }

          if (a.Contains("614"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("614", "r");
          }

          if (a.Contains("615"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("615", "s");
          }

          if (a.Contains("716"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("716", "t");
          }

          if (a.Contains("617"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("617", "u");
          }

          if (a.Contains("618"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("618", "v");
          }

          if (a.Contains("619"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("619", "w");
          }

          if (a.Contains("620"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("620", "x");
          }

          if (a.Contains("621"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("621", "y");
          }

          if (a.Contains("622"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("622", "z");
          }

          if (a.Contains("532"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("532", " ");
          }

          if (a.Contains("533"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("533", "!");
          }


          if (a.Contains("534"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("534", "\"\"");
          }

          if (a.Contains("535"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("535", "#");
          }

          if (a.Contains("536"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("536", "$");
          }

          if (a.Contains("537"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("537", "%");
          }

          if (a.Contains("538"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("538", "&");
          }

          if (a.Contains("539"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("539", "'");
          }

          if (a.Contains("540"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("540", "(");
          }

          if (a.Contains("541"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("541", ")");
          }

          if (a.Contains("542"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("542", "*");
          }

          if (a.Contains("543"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("543", "+");
          }

          if (a.Contains("544"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("544", ",");
          }

          if (a.Contains("545"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("545", "-");
          }

          if (a.Contains("546"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("546", ".");
          }

          if (a.Contains("547"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("547", "/");
          }

          if (a.Contains("858"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("858", ":");
          }

          if (a.Contains("859"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("859", ";");
          }

          if (a.Contains("560"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("560", "<");
          }

          if (a.Contains("561"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("561", "=");
          }

          if (a.Contains("562"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("562", ">");
          }

          if (a.Contains("563"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("563", "?");
          }

          if (a.Contains("564"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("564", "@");
          }

          if (a.Contains("365"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("365", "A");
          }

          if (a.Contains("566"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("566", "B");
          }

          if (a.Contains("567"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("567", "C");
          }

          if (a.Contains("468"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("468", "D");
          }

          if (a.Contains("569"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("569", "E");
          }

          if (a.Contains("570"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("570", "F");
          }

          if (a.Contains("571"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("571", "G");
          }

          if (a.Contains("572"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("572", "H");
          }

          if (a.Contains("573"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("573", "I");
          }

          if (a.Contains("574"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("574", "J");
          }

          if (a.Contains("575"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("575", "K");
          }

          if (a.Contains("576"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("576", "L");
          }

          if (a.Contains("577"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("577", "M");
          }

          if (a.Contains("578"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("578", "N");
          }

          if (a.Contains("579"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("579", "O");
          }

          if (a.Contains("580"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("580", "P");
          }

          if (a.Contains("581"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("581", "Q");
          }

          if (a.Contains("582"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("582", "R");
          }

          if (a.Contains("583"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("583", "S");
          }

          if (a.Contains("584"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("584", "T");
          }

          if (a.Contains("585"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("585", "U");
          }

          if (a.Contains("586"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("586", "V");
          }

          if (a.Contains("587"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("587", "W");
          }

          if (a.Contains("784"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("784", "X");
          }

          if (a.Contains("589"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("589", "Y");
          }

          if (a.Contains("590"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("590", "Z");
          }

          if (a.Contains("591"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("591", "[");
          }

          if (a.Contains("592"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("592", "\\");
          }

          if (a.Contains("593"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("593", "]");
          }

          if (a.Contains("594"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("594", "^");
          }

          if (a.Contains("595"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("595", "_");
          }

          if (a.Contains("596"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("596", "`");
          }

          if (a.Contains("128"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("128", "Ç");
          }

          if (a.Contains("129"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("129", "ü");
          }

          if (a.Contains("130"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("130", "é");
          }

          if (a.Contains("131"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("131", "â");
          }

          if (a.Contains("132"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("132", "ä");
          }

          if (a.Contains("133"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("133", "à");
          }

          if (a.Contains("135"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("135", "ç");
          }

          if (a.Contains("136"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("136", "ê");
          }

          if (a.Contains("137"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("137", "ë");
          }

          if (a.Contains("138"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("138", "è");
          }

          if (a.Contains("139"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("139", "ï");
          }

          if (a.Contains("140"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("140", "î");
          }

          if (a.Contains("141"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("141", "ı");
          }

          if (a.Contains("142"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("142", "Ä");
          }

          if (a.Contains("144"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("144", "É");
          }

          if (a.Contains("145"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("145", "æ");
          }

          if (a.Contains("146"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("146", "Æ");
          }

          if (a.Contains("147"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("147", "ô");
          }

          if (a.Contains("148"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("148", "ö");
          }

          if (a.Contains("149"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("149", "ò");
          }

          if (a.Contains("150"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("150", "û");
          }

          if (a.Contains("151"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("151", "ù");
          }

          if (a.Contains("453"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("453", "Ö");
          }

          if (a.Contains("154"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("154", "Ü");
          }

          if (a.Contains("171"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("171", "½");
          }

          if (a.Contains("172"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("172", "İ");
          }

          if (a.Contains("287"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("287", "ğ");
          }

          if (a.Contains("286"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("286", "Ğ");
          }

          if (a.Contains("951"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("951", "ş");
          }

          if (a.Contains("350"))
          {
              sonmesajBinary.Text = sonmesajBinary.Text.Replace("350", "Ş");
          }
            okunanMesaj.Text = a;

            System.Threading.Thread.Sleep(1000);

           

            /*
            if (okunanMesaj.Text.Contains("848"))
            {
                sonmesajBinary.Text = sonmesajBinary.Text.Replace("848", "0");
            }

            if (okunanMesaj.Text.Contains("849"))
            {
                sonmesajBinary.Text = sonmesajBinary.Text.Replace("849", "1");
            }

            if (okunanMesaj.Text.Contains("850"))
            {
                sonmesajBinary.Text = sonmesajBinary.Text.Replace("850", "2");
            }

            if (okunanMesaj.Text.Contains("851"))
            {
                sonmesajBinary.Text = sonmesajBinary.Text.Replace("851", "3");
            }

            if (okunanMesaj.Text.Contains("852"))
            {
                sonmesajBinary.Text = sonmesajBinary.Text.Replace("852", "4");
            }

            if (okunanMesaj.Text.Contains("853"))
            {
                sonmesajBinary.Text = sonmesajBinary.Text.Replace("853", "5");
            }

            if (okunanMesaj.Text.Contains("854"))
            {
                sonmesajBinary.Text = sonmesajBinary.Text.Replace("854", "6");
            }

            if (okunanMesaj.Text.Contains("855"))
            {
                sonmesajBinary.Text = sonmesajBinary.Text.Replace("855", "7");
            }

            if (okunanMesaj.Text.Contains("856"))
            {
                sonmesajBinary.Text = sonmesajBinary.Text.Replace("856", "8");
            }

            if (okunanMesaj.Text.Contains("857"))
            {
                sonmesajBinary.Text = sonmesajBinary.Text.Replace("857", "9");
            }
            */
     //       else
       //     {

         //       sonmesajBinary.Text = okunanMesaj.Text;
           // }
            
            // char[] rr;
            //rr = a.ToCharArray(0, 3);
            //karakterler.Text = rr.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Pi Kodu yalnızca sayılardan oluşur, lütfen farklı karakter kullanmayın!");
                //  textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                textBox1.Text = string.Empty;
            }
         /*   if(textBox1.Text == null)
            {
                dePirele.Enabled = false;
            }
            else
            {
                dePirele.Enabled = true;
            }
         */
        }

        private void yenile_Click(object sender, EventArgs e)
        {
            Refresh();
            textBox1.Text = string.Empty;
            mesaj.Text = string.Empty;
            dePirele.Enabled= true;
        }

        private void sonmesajBinary_TextChanged(object sender, EventArgs e)
        {
           // List<string> karakterler = new List<string>();
            
              // mesjKarakter.Text = sonmesajBinary.Text;
                


           
        }
        //  private void Form2_Load(object sender, EventArgs e)
        //{
        //   MessageBox.Show("Lütfen, pi kodunuzda düzenleme yapmadan, eksiksiz giriniz/Yapıştırınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        // }
    }
}
