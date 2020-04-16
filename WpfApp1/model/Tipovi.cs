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
using System.ComponentModel;
using System.Xml.Serialization;

namespace WpfApp1.model
{
    [Serializable]
    public class Tipovi: INotifyPropertyChanged
    {

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }


        String naziv;
        String id;
        String opis;
        [XmlIgnore]
        String image;
        String idLokala;
        String nazivLokala;
        String image2;


        public Tipovi()
        {
            

        }
        public Tipovi(String naz,String id,String opis,String img)
        {
            this.Naziv = naz;
            this.id = id;
            this.Opis = opis;
            this.image = img;
            
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
        public string Naziv {
            get
            {
                return naziv;
            }
            set
            {
                naziv = value;
                OnPropertyChanged("Naziv");
            }



        }
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
        public string Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
                OnPropertyChanged("Ima");
            }
        }

       

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
