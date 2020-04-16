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
using System.Media;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    /// 
    
    public partial class Login : Window
    {
        private int i=0,j=0;
        private SoundPlayer player = new SoundPlayer("C:\\Users\\Erceg\\source\\repos\\WpfApp1\\WpfApp1\\sound\\sound1.wav");
        private bool soundFinished = false;
        public Login()
        {
            InitializeComponent();
            LozinkaTb.FontFamily= new FontFamily("Arial");
            
            LozinkaTb.FontWeight = FontWeights.Bold;


        }

        //Kriptovanje uglavnom jako slab metod kriptovanja sifre i korisnickog imena
        //Kriptuje tako sto pomera vrednost nekog karaktera za tri na primer a koje je 65
        //Kriptuje u d koje ima vrednost 68, prosta cezarova sifra
        /*ako ostane vremena mozda stavim md5*/
        String WeakDecryptMethod(String textIn)
        {
            Char[] temp = textIn.ToArray<Char>();
            for (int i = 0; i < textIn.Length; i++)
            {
                temp[i] = (char)((int)temp[i] - 3);
            }
            return new String(temp);
        }
         

        
        
        //pritisak entera otvara novi prozor, naravno ako su uslovi zadovoljeni
        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
               
                    if (File.Exists("Users.txt") && korisnickoimeTb.Text.Length >= 4 && LozinkaTb.Text.Length >= 4)
                    {
                        using (StreamReader streamReader = new StreamReader("Users.txt"))
                        {

                            while (streamReader.Peek() >= 0)
                            {
                                int brc = 0;
                                String decryptedLogin = WeakDecryptMethod(streamReader.ReadLine());
                                String decryptedPass = WeakDecryptMethod(streamReader.ReadLine());
                                if (decryptedLogin == korisnickoimeTb.Text && decryptedPass == LozinkaTb.Text)
                                {
                                    player.Stop();
                                    MainWindow mw = new MainWindow();
                                    soundFinished = true;
                                    this.Close();
                                    mw.Show();

                                    


                                    break;
                                }

                                else
                                {

                                    tbBlock.Foreground = Brushes.Red;
                                    tbBlock.Text = "Uneli ste pogresnog korisnika ili lozinku!";


                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Morate uneti vise od 4 znaka za lozinku i password");
                        return;
                    }
                
               
                

            }
        }

        //klikom misa na dugme se otvara novi prozor, naravno ako su uslovi zadovoljeni
        //a to je provera sifre i korisnickog imena da li postoje u fajlu

        private void btnPrijava(object sender, RoutedEventArgs e)
        {
            if (File.Exists("Users.txt") && korisnickoimeTb.Text.Length >= 4 && LozinkaTb.Text.Length >= 4)
            {
                using (StreamReader streamReader = new StreamReader("Users.txt"))
                {

                    while (streamReader.Peek() >= 0)
                    {
                        int brc=0;
                        String decryptedLogin = WeakDecryptMethod(streamReader.ReadLine());
                        String decryptedPass = WeakDecryptMethod(streamReader.ReadLine());
                        if (decryptedLogin == korisnickoimeTb.Text && decryptedPass == LozinkaTb.Text)
                        {
                            player.Stop();
                            MainWindow mw = new MainWindow();
                            soundFinished = true;
                            this.Close();
                            mw.Show();
                            
                            
                            break;
                        }
                       
                        else
                        {
                            
                            tbBlock.Foreground = Brushes.Red;
                            tbBlock.Text = "Uneli ste pogresnog korisnika ili lozinku!";
                            
                            
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Morate uneti vise od 4 znaka za lozinku i password");
                return;
            }
        }
        //otvara registraciju ako korisnik izabere
        private void btnRegistracija(object sender, RoutedEventArgs e)
        {
            Window1 w1 = new Window1();
            w1.Show();
            this.Close();
        }

        private void zvuk(object sender, RoutedEventArgs e)
        {
           
            
            player.Load();

            player.Play();


            
           


        }

        private void ukloni(object sender, MouseEventArgs e)
        {
            
            if (i != 1)
            {
                korisnickoimeTb.Text = "";
                i = i + 1;
            }

        }

        

        private void promena(object sender, StylusEventArgs e)
        {
            buttonPri.Foreground = Brushes.Black;
        }

        private void promena(object sender, MouseEventArgs e)
        {
            buttonPri.Foreground = Brushes.Black;
        }

        private void promena1(object sender, MouseEventArgs e)
        {
            buttonPri.Foreground = Brushes.White;
        }

        private void promenaReg(object sender, MouseEventArgs e)
        {
            regButton.Foreground = Brushes.Black;
        }

        private void vracanjeReg(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
           
            regButton.Foreground = (Brush)bc.ConvertFrom("#FF4680E6");
        }

        private void ukloni2(object sender, MouseEventArgs e)
        {
            if (j != 1)
            {
                LozinkaTb.Text = "";
                j++;
            }
            LozinkaTb.FontFamily = new FontFamily("Password");
            LozinkaTb.FontWeight = FontWeights.Light;

        }
    }
}
