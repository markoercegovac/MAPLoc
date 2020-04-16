using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for Etiketa.xaml
    /// </summary>
    public partial class Etiketa : Window, INotifyPropertyChanged
    {

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        public Etikete Etikete
        {
            get;
            set;
        }

        private Forma forma;

        public event PropertyChangedEventHandler PropertyChanged;

        public Etiketa()
        {
            InitializeComponent();
        }

        public Etiketa(Forma forma)
        {
            this.forma = forma;
            InitializeComponent();
        }

        private void promeniBoju(object sender, RoutedEventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                idTxt.Foreground = new SolidColorBrush(Color.FromArgb(cd.Color.A, cd.Color.R, cd.Color.G, cd.Color.B));
            }
        }//menjanje foreground u zavisnosti da li se kursor nalazi unutra ili ne
        //promena boje za colorpicker dugme
        



        //promena boje za dugme dodavnja
       

        private void ButtonDodaj_Click(object sender, RoutedEventArgs e)
        {
            if (forma.IzborLokala.MainWindow.Podaci.vratiEtiketu().ContainsKey(idTxt.Text))
            {
                System.Windows.MessageBox.Show("Etiketa sa tim ID vec postoji, molim vas unesite drugi ID");
                return;

            }
            forma.IzborLokala.MainWindow.Podaci.dodajEtiketu(idTxt.Text, new model.Etikete(idTxt.Text, optxt.Text,Convert.ToString( idTxt.Foreground)));
            forma.Lista.Add(idTxt.Text);
            forma.etiketaCombo.Items.Add(idTxt.Text);
            this.Close();
           
            
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
