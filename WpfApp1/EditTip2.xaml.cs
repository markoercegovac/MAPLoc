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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for EditTip2.xaml
    /// </summary>
    public partial class EditTip2 : Window
    {
        private EditLokali editLokali;

        public EditTip2()
        {
            InitializeComponent();
        }

        public EditTip2(EditLokali editLokali)
        {
            InitializeComponent();
            this.editLokali = editLokali;
            imeLokTxt.Text = editLokali.IzborLokala.MainWindow.Podaci.vratiTip()[editLokali.tipCombo.Text].Naziv;
            idTxt.Text = editLokali.IzborLokala.MainWindow.Podaci.vratiTip()[editLokali.tipCombo.Text].Id;
            idTxt.IsEnabled = false;
            opisLokTxt.Text = editLokali.IzborLokala.MainWindow.Podaci.vratiTip()[editLokali.tipCombo.Text].Opis;
            slikaLokala.Source = new BitmapImage(new Uri( editLokali.IzborLokala.MainWindow.Podaci.vratiTip()[editLokali.tipCombo.Text].Image));
        }
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
            this.Close();

            editLokali.IzborLokala.MainWindow.Podaci.vratiTip()[idTxt.Text].Image =  Convert.ToString(slikaLokala.Source);
            editLokali.IzborLokala.MainWindow.Podaci.vratiTip()[idTxt.Text].Opis = opisLokTxt.Text;
            editLokali.IzborLokala.MainWindow.Podaci.vratiTip()[idTxt.Text].Naziv = imeLokTxt.Text;
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
    }
}

