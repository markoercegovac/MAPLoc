using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using WpfApp1.model;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for TabelaLokali.xaml
    /// </summary>
    public partial class TabelaLokali : Window , INotifyPropertyChanged
    {
        private IzborLokala izborLokala;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        private ICollectionView _View;
        public ICollectionView View
        {
            get
            {
                return _View;
            }
            set
            {
                _View = value;
                OnPropertyChanged("View");
            }
        }

        private bool _GroupView;
        public bool GroupView
        {
            get
            {
                return _GroupView;
            }
            set
            {
                if (value != _GroupView && View != null)
                {
                    View.GroupDescriptions.Clear();
                    if (value)
                    {
                        View.GroupDescriptions.Add(new PropertyGroupDescription("Upisan"));
                    }
                    _GroupView = value;
                    OnPropertyChanged("GroupView");

                    OnPropertyChanged("View");
                }
            }
        }

        public TabelaLokali()
        {
            InitializeComponent();
        }

        public ObservableCollection<Lokali> Lokali

        {
            
            get;
            set;
        }

        public TabelaLokali(IzborLokala izborLokala)
        {
            InitializeComponent();
            this.DataContext = this;
            List<Lokali> l = new List<Lokali>();
            l = izborLokala.MainWindow.Podaci.getLokali().Values.ToList();
            Lokali = new ObservableCollection<Lokali>(l);
            
            View = CollectionViewSource.GetDefaultView(Lokali);
            GroupView = false;
            this.izborLokala = izborLokala;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            
            List<Lokali> temp = new List<Lokali>();
            foreach (Lokali lok in izborLokala.MainWindow.Podaci.getLokali().Values)
            {
                if (lok.Naziv == txtFilter.Text)
                {
                    temp.Add(lok);

                }
                
            }
            
            Lokali = new ObservableCollection<Lokali>(temp);
            dgrMain.ItemsSource = null;
            dgrMain.ItemsSource = Lokali;
            GroupView = false;
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            List<Lokali> temp = new List<Lokali>();
            foreach(Lokali lok in izborLokala.MainWindow.Podaci.getLokali().Values)
            {
                if (lok.Id == txtPretraga.Text)
                {
                    temp.Add(lok);
                }
            }
            Lokali = new ObservableCollection<Lokali>(temp);
            dgrMain.ItemsSource = null;
            dgrMain.ItemsSource = Lokali;
            GroupView = false;
        }
    }
}
