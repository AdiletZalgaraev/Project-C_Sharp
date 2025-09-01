using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfApp2
{
    internal class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void Notify(string Name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Name));
        }

        int h, w;

        public int H
        {
            get { return h;}
            set 
            {
                h = value;
                Notify("H");
            }
        }

        public int W
        {
            get { return w; }
            set
            {
                w = value;
                Notify("W");
            }
        }
    }
}
