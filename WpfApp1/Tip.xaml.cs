using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp1.model;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Tip.xaml
    /// </summary>
    public partial class Tip : Window
    {
        private Forma forma;

        public Tip()
        {
            
            InitializeComponent();
            slikaLokala.Source= new BitmapImage(new Uri("/img/add-image.png", UriKind.Relative));
        }

        public Tip(Forma forma)
        {
            InitializeComponent();
            slikaLokala.Source = new BitmapImage(new Uri("/img/add-image.png", UriKind.Relative));
            this.forma = forma;
        }


        //Menjanje slike tipa lokala
        private void slika1(object sender, RoutedEventArgs e)
        {
            slikaLokala.Source = new BitmapImage(new Uri("/img/hospital512.png", UriKind.Relative));
        }
        private void slika2(object sender, RoutedEventArgs e)
        {
            slikaLokala.Source = new BitmapImage(new Uri("/img/crkva512.png", UriKind.Relative));
        }
        private void slika3(object sender, RoutedEventArgs e)
        {
            slikaLokala.Source = new BitmapImage(new Uri("/img/skola512.png", UriKind.Relative));
        }
        private void slika4(object sender, RoutedEventArgs e)
        {
            slikaLokala.Source = new BitmapImage(new Uri("/img/gym512.png", UriKind.Relative));
        }
        private void slika5(object sender, RoutedEventArgs e)
        {
            slikaLokala.Source = new BitmapImage(new Uri("/img/picerija512.png", UriKind.Relative));
        }

        //dodajemo novu sliku tako sto filtriramo jpg i dodajemo preko filechoosera
        private void dodajSliku(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = "c:\\";
            dlg.Filter = "Image files (*.jpg)|*.jpg|All Files (*.*)|*.*";
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string selectedFileName = dlg.FileName;
                //FileNameLabel.Content = selectedFileName;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(selectedFileName);
                bitmap.EndInit();
                slikaLokala.Source = bitmap;
            }
        }
      

        

        private void izmena(object sender, RoutedEventArgs e)
        {
            if (forma.IzborLokala.MainWindow.Podaci.vratiTip().ContainsKey(idTxt.Text))
            {
                System.Windows.MessageBox.Show("ID tipa vec postoji, molim Vas unesite drugi ID.");
                return;
            }
            if (idTxt.Text == "" || nazTipText.Text == "") 
            {
                System.Windows.MessageBox.Show("ID, ili naziv tipa ne smeju da budu prazni");
                return;
            }
            
                forma.slikaLokala.Source = slikaLokala.Source;
            
            forma.tipCombo.Items.Add(idTxt.Text);
            this.Close();
            forma.InitializeComponent();
            forma.buttonDodajTip.IsEnabled = false;
            forma.slikaDodavanjaTipa.Source= new BitmapImage(new Uri("/img/lock.png", UriKind.Relative));
            forma.IzborLokala.MainWindow.Podaci.dodajTip(idTxt.Text,new Tipovi(nazTipText.Text, idTxt.Text, opisTipText.Text,Convert.ToString(slikaLokala.Source)));

            //forma.IzborLokala.MainWindow.Slike = new System.Collections.ObjectModel.ObservableCollection<Tipovi>(forma.IzborLokala.MainWindow.Podaci.vratiTip().Values.ToList<Tipovi>());
            //forma.IzborLokala.MainWindow.panelcic.ItemsSource = null;
            //forma.IzborLokala.MainWindow.panelcic.ItemsSource = forma.IzborLokala.MainWindow.Slike;

            //forma.IzborLokala.MainWindow.panelcic.Items.Refresh();





        }
        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            IInputElement focusedControl = FocusManager.GetFocusedElement(System.Windows.Application.Current.Windows[0]);
            if (focusedControl is DependencyObject)
            {
                string str = model.HelpProvider.GetHelpKey((DependencyObject)focusedControl);
                model.HelpProvider.ShowHelp(str);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
