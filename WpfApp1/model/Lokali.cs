using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1.model
{
    [Serializable]
    public class Lokali : INotifyPropertyChanged
    {
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        
        private String nazLokala;
        private String tipLokala;
        private String opisLokala;
        private String idLokala;
        private String dostupnostZaHendikepirane;
        private String dozvoljenoPusenje;
        private String rezervacije;
        private String kategorijeCena;
        private String alkohol;
        private String datum;
        private String slika;
        private List<String> etikete;

        public Lokali()
        {

        }

        public Lokali(String naz, String tip, String opis, String id,List<String> eti,String hendikepirani, String pusenje, String rezervacije, String kategorije, String alkohol, String datum,String slik)
        {
            this.nazLokala = naz;
            this.tipLokala = tip;
            this.opisLokala = opis;
            this.idLokala = id;
            this.dostupnostZaHendikepirane = hendikepirani;
            this.dozvoljenoPusenje = pusenje;
            this.rezervacije = rezervacije;
            this.kategorijeCena = kategorije;
            this.alkohol = alkohol;
            this.datum = datum;
            this.etikete = eti;
            this.slika = slik;
            
        }

        public String Naziv
        {
            get {
                return nazLokala;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Naziv ne sme da bude prazan");
                
                nazLokala = value;
                OnPropertyChanged("Naziv");
            }

        }

        public String Tip
        {
            get
            {
                return tipLokala;
            }
            set
            {
                
                tipLokala = value;
                OnPropertyChanged("Tip");
            }
        }
        
        public String Opis
        {
            get
            {
                return opisLokala;
            }
            set
            {
                opisLokala = value;
                OnPropertyChanged("Opis");
            }
        }
        public String Id
        {
            get
            {
                return idLokala;
            }
            set
            {
                
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Id ne sme da bude prazan");

                idLokala = value;
                OnPropertyChanged("Id");
            }
        }
        public String Hendikepirani
        {
            get
            {
                return dostupnostZaHendikepirane;
            }
            set
            {
                dostupnostZaHendikepirane = value;
                OnPropertyChanged("Hendikepirani");
            }
        }
        public String Pusenje
        {
            get
            {
                return dozvoljenoPusenje;
            }
            set
            {
                dozvoljenoPusenje = value;
                OnPropertyChanged("Pusenje");
            }
        }
        public String Rezervacije
        {
            get
            {
                return rezervacije;
            }
            set
            {
                rezervacije = value;
                OnPropertyChanged("Rezervacije");
            }
        }
        public String Kategorije
        {
            get
            {
                return kategorijeCena;
            }
            set
            {
                kategorijeCena = value;
                OnPropertyChanged("Kategorije");
            }
        }

        public String Alkohol
        {
            get
            {
                return alkohol;
            }
            set
            {
                alkohol = value;
                OnPropertyChanged("Alkohol");
            }
        }
        public String Datum
        {
            get
            {
                return datum;
            }
            set
            {
                datum = value;
                OnPropertyChanged("Datum");
            }
        }
        public String Image2
        {
            get
            {
                return slika;
            }
            set
            {
                slika = value;
                OnPropertyChanged("Image2");
            }
        }

        public List<string> Etikete { get => etikete; set => etikete = value; }
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
    }


    
}
