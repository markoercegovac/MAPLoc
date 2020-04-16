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
    /// Interaction logic for IzborTipaLokala.xaml
    /// </summary>
    public partial class IzborTipaLokala : Window
    {
        public IzborTipaLokala()
        {
            InitializeComponent();
        }
        private void klik1(object sender, RoutedEventArgs e)
        {
            Tip t = new Tip();
            t.ShowDialog();
        }
        private void klik2(object sender, RoutedEventArgs e)
        {
            TipEdit te = new TipEdit();
            te.ShowDialog();
        }
    }
    
}
