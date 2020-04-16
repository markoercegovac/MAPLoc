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
    /// Interaction logic for TabelaEtikete.xaml
    /// </summary>
    public partial class TabelaEtikete : Window, INotifyPropertyChanged
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
        public ObservableCollection<Etikete> Etikete

        {

            get;
            set;
        }
        public TabelaEtikete()
        {
            InitializeComponent();
        }

        public TabelaEtikete(Forma forma)
        {
            this.forma = forma;
            InitializeComponent();
            this.DataContext = this;
            List<Etikete> e = new List<Etikete>();
            e = forma.IzborLokala.MainWindow.Podaci.vratiEtiketu().Values.ToList();
            Etikete = new ObservableCollection<Etikete>(e);

            View = CollectionViewSource.GetDefaultView(Etikete);
            GroupView = false;
            
        }
    }
}
