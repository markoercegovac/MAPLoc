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
    /// Interaction logic for EditEtiketaxaml.xaml
    /// </summary>
    public partial class EditEtiketaxaml : Window
    {
        private Forma forma;

        public EditEtiketaxaml()
        {
            InitializeComponent();
        }

        public EditEtiketaxaml(Forma forma)
        {
            InitializeComponent();
            idTxt.Text = forma.IzborLokala.MainWindow.Podaci.vratiEtiketu()[forma.etiketaCombo.Text].Id;
            idTxt.IsEnabled = false;
            idTxt.Foreground=(Brush)new BrushConverter().ConvertFromString( forma.IzborLokala.MainWindow.Podaci.vratiEtiketu()[forma.etiketaCombo.Text].Boja);
            opis.Text = forma.IzborLokala.MainWindow.Podaci.vratiEtiketu()[forma.etiketaCombo.Text].Opis;

            this.forma = forma;
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
        private void dugme1(object sender, System.Windows.Input.MouseEventArgs e)
        {
            buttonPromena.Foreground = Brushes.Black;
        }

        private void dugme2(object sender, System.Windows.Input.MouseEventArgs e)
        {
            buttonPromena.Foreground = Brushes.White;
        }



        //promena boje za dugme dodavnja
        private void dugme3(object sender, System.Windows.Input.MouseEventArgs e)
        {
            buttonDodaj.Foreground = Brushes.Black;
        }
        private void dugme4(object sender, System.Windows.Input.MouseEventArgs e)
        {
            buttonDodaj.Foreground = Brushes.White;
        }

        private void izmeniEtiketu(object sender ,RoutedEventArgs e)
        {
            forma.IzborLokala.MainWindow.Podaci.vratiEtiketu()[idTxt.Text].Opis = opis.Text;
            forma.IzborLokala.MainWindow.Podaci.vratiEtiketu()[idTxt.Text].Boja = Convert.ToString( idTxt.Foreground);
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
