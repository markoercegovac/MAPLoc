using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Controls;

namespace WpfApp1.model
{
    [Serializable]
    public class Slika : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private Image img;
        private String str;

        public Slika(Image i,String s)
        {
            this.img = i;
            this.str = s;
        }

        public Slika()
        {
        }

        public string Ime
        {
            get
            {
                return str;
            }
            set
            {
                str = value;
                OnPropertyChanged("Ime");
            }
        }
        public Image Img
        {
            get
            {
                return img;
            }
            set
            {
                img = value;
                OnPropertyChanged("Img");
            }
        }

    }

}
