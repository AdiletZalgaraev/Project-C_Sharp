using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfApp1
{
    internal class ViewModel : INotifyPropertyChanged
    {
        double a, b, sum;

        public double A 
        { 
            get { return a; }
            set { a = value;
                Sum = a + b;
                Notify("A");
            }
        }

        public double B
        {
            get { return b; }
            set
            {
                b = value;
                Sum = a + b;
                Notify("B");
            }
        }

        public double Sum
        {
            get { return sum; }
            set
            {
                sum = value;
                Notify("Sum");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void Notify (string name)
        {
            PropertyChanged?.Invoke (this, new PropertyChangedEventArgs (name));
        }
    }
}
