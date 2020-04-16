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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for IzborEtikete.xaml
    /// </summary>
    public partial class IzborEtikete : Window
    {
        public IzborEtikete()
        {
            InitializeComponent();
        }
        private void klik1(object sender, RoutedEventArgs e)
        {
            Etiketa et = new Etiketa();
            et.ShowDialog();
        }
        private void klik2(object sender, RoutedEventArgs e)
        {
            EditEtiketaxaml eet = new EditEtiketaxaml();
            eet.ShowDialog();
            
        }
    }

}
