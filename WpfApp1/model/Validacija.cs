using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1.model
{

    [Serializable]
    public class Validacija : ValidationRule
    {

        public int minimumKaraktera { get; set; }
        

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string charString = value as string;
            if (charString.Length < minimumKaraktera)
                return new ValidationResult(false, $"Koristite za unos barem {minimumKaraktera} karaktera");
           

            return new ValidationResult(true, null);
        }

        
    }
    public class Imena : ValidationRule
    {


        public int minimumimena { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string charString = value as string;
            if (charString.Length < minimumimena)
                return new ValidationResult(false, $"Ime mora imati bar {minimumimena} karaktera");


            return new ValidationResult(true, null);
        }


    }

    public class Empty : ValidationRule
    {

        public int minimumimena { get; set; }
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string charString = value as string;
            if (charString.Length < minimumimena)
                return new ValidationResult(false, $" bar {minimumimena} karaktera id");


            return new ValidationResult(true, null);
        }
    }

   


}
