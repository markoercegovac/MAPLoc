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
using System.Windows.Forms;
using WpfApp1.model;

using System.ComponentModel;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Forma.xaml
    /// </summary>
    public partial class Forma : Window, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private String slikaTipa;
        private IzborLokala izborLokala;
        private Tipovi tipLokala = new Tipovi();
        private List<String> lista = new List<String>();

        public IzborLokala IzborLokala { get => izborLokala; set => izborLokala = value; }
        internal Tipovi TipLokala { get => tipLokala; set => tipLokala = value; }


        public Lokali Lokali
        {
            get;
            set;
        }
        public Validacija Validacija
        {
            get;
            set;
        }

        public List<string> Lista { get => lista; set => lista = value; }

        public Forma()
        {

            InitializeComponent();

        }

        public Forma(IzborLokala izborLokala)
        {
            InitializeComponent();
            foreach(String str in izborLokala.MainWindow.Podaci.vratiEtiketu().Keys)
            {
                etiketaCombo.Items.Add(str);
            }
            slikaLokala.Source = new BitmapImage(new Uri("/img/add-image.png", UriKind.Relative));

            this.IzborLokala = izborLokala;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Tipovi tipLokala = new Tipovi();
            if (idTxt.Text == "")
            {
                txtBoxID.Visibility = Visibility.Visible;
                return;
            }
            if (tipCombo.SelectedIndex == -1 || alkoholCombo.Items.IsEmpty || kategorijeCombo.Items.IsEmpty ||  pusenjeTxt.Items.IsEmpty || hendikepiraniCombo.Items.IsEmpty)
            {
                txtBoxID.Visibility = Visibility.Visible;
                return;
            }
            if (izborLokala.MainWindow.Podaci.GetListaLokala().ContainsKey(idTxt.Text))
            {
                System.Windows.MessageBox.Show("ID vec postoji");
                return;

            }
           
            IzborLokala.MainWindow.Podaci.dodajLokal(idTxt.Text, new Lokali(nazTxt.Text, tipCombo.Text,
                opisTxt.Text, idTxt.Text, lista, hendikepiraniCombo.Text, pusenjeTxt.Text, rezervacijeCombo.Text, kategorijeCombo.Text, alkoholCombo.Text, datumDate.Text, Convert.ToString(slikaLokala.Source)));

            Image img = new Image();
            img.Source = slikaLokala.Source;

            Slika s = new Slika(img, nazTxt.Text);
            
            
            izborLokala.MainWindow.panelcic.Items.Refresh();

            //izborLokala.comboBox.Items.Add(idTxt.Text);

            IzborLokala.Close();

            //izborLokala.MainWindow.Podaci.vratiTip()[tipCombo.Text].Image2 = Convert.ToString( slikaLokala.Source);
            
            this.Close();
            izborLokala.MainWindow.Slike = new System.Collections.ObjectModel.ObservableCollection<Lokali>(izborLokala.MainWindow.Podaci.getLokali().Values.ToList<Lokali>());
            izborLokala.MainWindow.panelcic.ItemsSource = null;
            izborLokala.MainWindow.panelcic.ItemsSource = IzborLokala.MainWindow.Slike;

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










        private void izmena(object sender, RoutedEventArgs e)
        {

            this.Close();



        }

        private void dodajTip(object sender, RoutedEventArgs e)
        {
            Tip t = new Tip(this);
            t.ShowDialog();
        }
        private void izmeniTip(object sender, RoutedEventArgs e)
        {
            if (tipCombo.SelectedIndex == -1)
            {
                return;
            }
            TipEdit te = new TipEdit(this);
            te.ShowDialog();

        }
        private void ukloniTip(object sender, RoutedEventArgs e)
        {
            if (tipCombo.Items.IsEmpty)
            {
                return;
            }
            string objekatZaUklanjanje = tipCombo.Text;
            tipCombo.Items.Remove(objekatZaUklanjanje);
            buttonDodajTip.IsEnabled = true;
            slikaDodavanjaTipa.Source = new BitmapImage(new Uri("/img/file.png", UriKind.Relative));

            izborLokala.MainWindow.Podaci.brisanjeTipa(objekatZaUklanjanje);
        }

        private void TabelaTip(object sender, RoutedEventArgs e)
        {
            TabelaTipova tt = new TabelaTipova(this);
            tt.Show();


        }
        private void dodajEtiketu(object sender, RoutedEventArgs e)
        {
            Etiketa et = new Etiketa(this);
            et.ShowDialog();

        }
        private void izmeniEtiketu(object sender, RoutedEventArgs e)
        {
            if (etiketaCombo.SelectedIndex == -1)
            {
                return;
            }
            EditEtiketaxaml etd = new EditEtiketaxaml(this);
            etd.ShowDialog();

        }

        private void nevidi(object sender, System.Windows.Input.MouseEventArgs e)
        {
            txtBoxID.Visibility = Visibility.Hidden;
        }

        private void TabelaEtiketa(object sender, RoutedEventArgs e)
        {
            TabelaEtikete tbe = new TabelaEtikete(this);
            tbe.Show();

        }

        private void ukloniEtiketu(object sender, RoutedEventArgs e)
        {
            if (etiketaCombo.SelectedIndex == -1)
            {
                return;
            }
            izborLokala.MainWindow.Podaci.brisanjeEtikete(etiketaCombo.Text);
            etiketaCombo.Items.Remove(etiketaCombo.Text);
        }

        //help

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            IInputElement focusedControl = FocusManager.GetFocusedElement(System.Windows.Application.Current.Windows[0]);
            if (focusedControl is DependencyObject)
            {
                string str = model.HelpProvider.GetHelpKey((DependencyObject)focusedControl);
                model.HelpProvider.ShowHelp(str);
            }
        }

        public void doThings(string param)
        {
            //izmena.Background = new SolidColorBrush(Color.FromRgb(32, 64, 128));
            Title = param;
        }
    }
}
