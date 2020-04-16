using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private int i = 0, j = 0;
        public Window1()
        {
            InitializeComponent();
        }
        String WeakEncryptMethod(String textIn)
        {
            Char[] temp = textIn.ToArray<Char>();

            for (int i = 0; i < textIn.Length; i++)
            {
                temp[i] = (char)((int)temp[i] + 3);
            }
            return new String(temp);
        }
            private void btnKreirajNalog(object sender, RoutedEventArgs e)
        {
            if (File.Exists("Users.txt")
            && korisTxt.Text.Length >= 4
            && lozTxt.Text.Length >= 4
            )
            {
                StringBuilder stringBuilder = new StringBuilder();
                using (StreamReader streamReader = new StreamReader("Users.txt"))
                {
                    stringBuilder.Append(streamReader.ReadToEnd());
                }
                using (StreamWriter streamWriter = new StreamWriter("Users.txt"))
                {
                    streamWriter.Write(stringBuilder.ToString());
                    streamWriter.WriteLine(WeakEncryptMethod(korisTxt.Text));
                    streamWriter.WriteLine(WeakEncryptMethod(lozTxt.Text));
                }
                System.Windows.MessageBox.Show("Korisnik "+korisTxt.Text+ " uspesno kreiran");
                
                Login lg = new Login();
                lg.Show();
                this.Close();
            }
            else{
                    MessageBox.Show("Morate uneti vise od 4 znaka za lozinku i password");
                    return;
                }
            
        }

        private void povratakLogin(object sender, RoutedEventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Close();
        }

        private void ukloniKoris(object sender, MouseEventArgs e)
        {
            if (i != 1)
            {
                korisTxt.Text = "";
                i = i + 1;
            }
        }

        private void promena1(object sender, MouseEventArgs e)
        {
            buttonKreirajKorisnika.Foreground = Brushes.Black;

        }

        private void promena2(object sender, MouseEventArgs e)
        {
            buttonKreirajKorisnika.Foreground = Brushes.White;
        }

        private void promena3(object sender, MouseEventArgs e)
        {
            buttonLozinka.Foreground = Brushes.Black;
        }

        private void promena4(object sender, MouseEventArgs e)
        {
            buttonLozinka.Foreground = Brushes.White;
        }

        private void ukloniLoz(object sender, MouseEventArgs e)
        {
            if (j != 1)
            {
                lozTxt.Text = "";
                j++;
            }
        }
    }
}
