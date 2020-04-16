using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1.model
{
    [Serializable]
    class Podaci
    {
        private Dictionary<string, Lokali> lokali;
        private Dictionary<string ,Tipovi> tipovi;
        private Dictionary<string ,Etikete> etikete;
        private Dictionary<string,Rect> slike;
        


        public Podaci()
        {
            this.lokali = new Dictionary<string, Lokali>();
            this.tipovi = new Dictionary<string ,Tipovi>();
            this.etikete = new Dictionary<string, Etikete>();
            this.slike = new Dictionary<string, Rect>();
        }
        //Lokali
        public void dodajLokal(string id,Lokali lok)
        {
            this.lokali.Add(id,lok);
        }
        public void ukloniLokal(string id)
        {
            this.lokali.Remove(id);
        }
        public void setKljuc(string id)
        {
            
        }
        public Dictionary<string, Lokali> GetListaLokala()
        {

            return lokali;
        }
        public Dictionary<string,Lokali> getLokali()
        {
            return this.lokali;
        }

       

        //Tipovi lokala
        public Dictionary<string,Tipovi> vratiTip()
        {
            return this.tipovi;
        }
        public void setTip(Dictionary<string, Tipovi> tip)
        {
            this.tipovi = tip;
        }
        public void brisanjeTipa(string id)
        {
            this.tipovi.Remove(id);
        }
        public void dodajTip(string id, Tipovi tip)
        {
            this.tipovi.Add(id, tip);
        }


        //Etikete
        public void dodajEtiketu(string id,Etikete et)
        {
            etikete.Add(id,et);
        }
        public Dictionary<string, Etikete> vratiEtiketu()
        {
            return etikete;
        }
        public void brisanjeEtikete(string id)
        {
            this.etikete.Remove(id);
        }


        //Slike
        public Dictionary<string,Rect> vratiSlike()
        {
            return this.slike;
        }
        public void brisanjeSlike(string id)
        {
            this.slike.Remove(id);
        }

    }


    
}
