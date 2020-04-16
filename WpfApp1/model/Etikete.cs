using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfApp1.model
{
    [Serializable]
    public class Etikete: INotifyPropertyChanged
    {
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }



        private String id;
        private String boja;
        private String opis;

        public event PropertyChangedEventHandler PropertyChanged;

        public Etikete()
        {

        }
        public Etikete(String id,String opis,String boja)
        {
            this.Id = id;
            this.Opis = opis;
            this.Boja = boja;
        }

        public string Id {
            get
            {
                return id;
            }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }

        }
        public String Boja { get => boja; set => boja = value; }
        public string Opis {
            get
            {
                return opis;
            }
            set
            {
                opis = value;
                OnPropertyChanged("Opis");
            }

        }
    }

        
    }

