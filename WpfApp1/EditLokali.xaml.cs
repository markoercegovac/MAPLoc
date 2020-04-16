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
    /// Interaction logic for EditLokali.xaml
    /// </summary>
    public partial class EditLokali : Window
    {
        private IzborLokala izborLokala;
        private string id;
        

        public IzborLokala IzborLokala { get => izborLokala; set => izborLokala = value; }

        public EditLokali()
        {
            InitializeComponent();
        }

        public EditLokali(IzborLokala izborLokala)
        {
            InitializeComponent();
            slikaLokala.Source = new BitmapImage(new Uri (izborLokala.MainWindow.Podaci.getLokali()[izborLokala.comboBox.Text].Image2));
            
            //tipCombo.Items.Add(izborLokala.MainWindow.Podaci.vratiTip().Naziv);
            idTxt.IsEnabled = false;
            idTxt.Text = izborLokala.MainWindow.Podaci.GetListaLokala()[izborLokala.comboBox.Text].Id;
            tipCombo.Items.Add(izborLokala.MainWindow.Podaci.GetListaLokala()[izborLokala.comboBox.Text].Tip);
            opisTxt.Text= izborLokala.MainWindow.Podaci.GetListaLokala()[izborLokala.comboBox.Text].Opis;
            hendikepiraniCombo.Text= izborLokala.MainWindow.Podaci.GetListaLokala()[izborLokala.comboBox.Text].Hendikepirani;
            pusenjeCombo.Text= izborLokala.MainWindow.Podaci.GetListaLokala()[izborLokala.comboBox.Text].Pusenje;
            rezervacijeCombo.Text= izborLokala.MainWindow.Podaci.GetListaLokala()[izborLokala.comboBox.Text].Rezervacije;
            ceneCombo.Text= izborLokala.MainWindow.Podaci.GetListaLokala()[izborLokala.comboBox.Text].Kategorije;
            alkoholCombo.Text= izborLokala.MainWindow.Podaci.GetListaLokala()[izborLokala.comboBox.Text].Alkohol;
            datumDate.Text = Convert.ToString(izborLokala.MainWindow.Podaci.GetListaLokala()[izborLokala.comboBox.Text].Datum);
            nazivTxt.Text= izborLokala.MainWindow.Podaci.GetListaLokala()[izborLokala.comboBox.Text].Naziv;
            foreach(String rec in izborLokala.MainWindow.Podaci.GetListaLokala()[izborLokala.comboBox.Text].Etikete)
            {
                etiketeCombo.Items.Add(rec);
            }
            /*
            foreach (KeyValuePair<string, Lokali> entry in izborLokala.MainWindow.Podaci.getLokali())
            {
                
                if (entry.Value.Id == izborLokala.comboBox.Text)
                {
                    tipCombo.Items.Add(entry.Value.Id);
                    nazivTxt.Text = entry.Value.Naziv;

                    opisTxt.Text = entry.Value.Opis;
                    idTxt.Text = entry.Value.Id;
                    hendikepiraniCombo.Text = entry.Value.Hendikepirani;
                    pusenjeCombo.Text = entry.Value.Pusenje;
                    ceneCombo.Text = entry.Value.Kategorije;
                    alkoholCombo.Text = entry.Value.Alkohol;
                    rezervacijeCombo.Text = entry.Value.Rezervacije;
                    datumDate.Text = Convert.ToString(entry.Value.Datum);
                }
            }

            */

            this.izborLokala = izborLokala;




        }

        public EditLokali(string id)
        {
            
            InitializeComponent();
            this.id = id;
            slikaLokala.Source = new BitmapImage(new Uri("/img/add-image.png", UriKind.Relative));

            //tipCombo.Items.Add(izborLokala.MainWindow.Podaci.vratiTip().Naziv);
            idTxt.IsEnabled = false;
            idTxt.Text = izborLokala.MainWindow.Podaci.GetListaLokala()[id].Id;
            tipCombo.Items.Add(izborLokala.MainWindow.Podaci.GetListaLokala()[id].Tip);
            opisTxt.Text = izborLokala.MainWindow.Podaci.GetListaLokala()[id].Opis;
            hendikepiraniCombo.Text = izborLokala.MainWindow.Podaci.GetListaLokala()[id].Hendikepirani;
            pusenjeCombo.Text = izborLokala.MainWindow.Podaci.GetListaLokala()[id].Pusenje;
            rezervacijeCombo.Text = izborLokala.MainWindow.Podaci.GetListaLokala()[id].Rezervacije;
            ceneCombo.Text = izborLokala.MainWindow.Podaci.GetListaLokala()[id].Kategorije;
            alkoholCombo.Text = izborLokala.MainWindow.Podaci.GetListaLokala()[id].Alkohol;
            datumDate.Text = Convert.ToString(izborLokala.MainWindow.Podaci.GetListaLokala()[id].Datum);
            nazivTxt.Text = izborLokala.MainWindow.Podaci.GetListaLokala()[id].Naziv;
            foreach (String rec in izborLokala.MainWindow.Podaci.GetListaLokala()[id].Etikete)
            {
                etiketeCombo.Items.Add(rec);
            }
        }

       

        private void izvrsi(object sender, RoutedEventArgs e)
        {
            izborLokala.MainWindow.Podaci.GetListaLokala()[izborLokala.comboBox.Text].Opis = opisTxt.Text;
            izborLokala.MainWindow.Podaci.GetListaLokala()[izborLokala.comboBox.Text].Hendikepirani = hendikepiraniCombo.Text;
            izborLokala.MainWindow.Podaci.GetListaLokala()[izborLokala.comboBox.Text].Kategorije = ceneCombo.Text;
            izborLokala.MainWindow.Podaci.GetListaLokala()[izborLokala.comboBox.Text].Alkohol = alkoholCombo.Text;
            izborLokala.MainWindow.Podaci.GetListaLokala()[izborLokala.comboBox.Text].Datum = datumDate.Text;
            izborLokala.MainWindow.Podaci.GetListaLokala()[izborLokala.comboBox.Text].Pusenje = pusenjeCombo.Text;
            izborLokala.MainWindow.Podaci.GetListaLokala()[izborLokala.comboBox.Text].Rezervacije = rezervacijeCombo.Text;
            izborLokala.MainWindow.Podaci.GetListaLokala()[izborLokala.comboBox.Text].Naziv = nazivTxt.Text;
            IzborLokala.MainWindow.Podaci.GetListaLokala()[izborLokala.comboBox.Text].Image2 = Convert.ToString(slikaLokala.Source);
            
            

        }
        private void IzmeniTip(object sender, RoutedEventArgs e)
        {
            if (tipCombo.SelectedIndex == -1)
            {
                return;
            }
            EditTip2 et2 = new EditTip2(this);
            et2.ShowDialog();
        }
        private void UkloniTip(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            izborLokala.MainWindow.Podaci.brisanjeTipa(tipCombo.Text);
            tipCombo.Items.Remove(tipCombo.Text);



        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            izborLokala.MainWindow.Podaci.brisanjeEtikete(etiketeCombo.Text);
            etiketeCombo.Items.Remove(etiketeCombo.Text);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (etiketeCombo.SelectedIndex==-1)
            {
                return;
            }
            EditEtiketa2 ee2 = new EditEtiketa2(this);
            ee2.ShowDialog();

        }

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
