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
    /// Interaction logic for EditEtiketa2.xaml
    /// </summary>
    public partial class EditEtiketa2 : Window
    {
        private EditLokali editLokali;

        public EditEtiketa2()
        {
            InitializeComponent();
        }

        public EditEtiketa2(EditLokali editLokali)
        {
            InitializeComponent();
            idTxt.Text = editLokali.IzborLokala.MainWindow.Podaci.vratiEtiketu()[editLokali.etiketeCombo.Text].Id;
            idTxt.IsEnabled = false;
            idTxt.Foreground= (Brush) new BrushConverter().ConvertFromString(editLokali.IzborLokala.MainWindow.Podaci.vratiEtiketu()[editLokali.etiketeCombo.Text].Boja);
            opis.Text = editLokali.IzborLokala.MainWindow.Podaci.vratiEtiketu()[editLokali.etiketeCombo.Text].Opis;
            this.editLokali = editLokali;
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

        private void izmeniEtiketu(object sender, RoutedEventArgs e)
        {
            editLokali.IzborLokala.MainWindow.Podaci.vratiEtiketu()[idTxt.Text].Opis = opis.Text;
            editLokali.IzborLokala.MainWindow.Podaci.vratiEtiketu()[idTxt.Text].Boja = Convert.ToString( idTxt.Foreground);
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

