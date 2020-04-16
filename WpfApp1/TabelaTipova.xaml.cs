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
    /// Interaction logic for TabelaTipova.xaml
    /// </summary>
    public partial class TabelaTipova : Window, INotifyPropertyChanged
    {
        private Forma forma;


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

        public ObservableCollection<Tipovi> Tipovi

        {

            get;
            set;
        }

        public TabelaTipova()
        {
            InitializeComponent();
        }

        public TabelaTipova(Forma forma)
        {
            InitializeComponent();
            this.DataContext = this;
            List<Tipovi> l = new List<Tipovi>();
            l = forma.IzborLokala.MainWindow.Podaci.vratiTip().Values.ToList();
            Tipovi = new ObservableCollection<Tipovi>(l);

            View = CollectionViewSource.GetDefaultView(Tipovi);
            GroupView = false;


            this.forma = forma;
        }
    }
}
