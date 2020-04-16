using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1.model
{
    public  class Komande
    {
        public static readonly RoutedUICommand Save = new RoutedUICommand(
            "Save",
            "Save",
            typeof(Komande),
            new InputGestureCollection()
            {
                new KeyGesture(Key.S, ModifierKeys.Control)
                //new KeyGesture(Key.H, ModifierKeys.Alt | ModifierKeys.Control)
            }
            );
    }
}
