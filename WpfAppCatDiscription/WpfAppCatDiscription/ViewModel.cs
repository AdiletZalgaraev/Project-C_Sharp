using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows;

namespace WpfAppCatDiscription
{
    internal class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void Notify(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        List<Cat> catList;
        Cat selected;

        public Cat Selected 
        {
            get { return selected; }
            set
            {
                selected= value;
                if(selected != null && MessageBox.Show("Delete c a t " + selected.Name + "?" , "Delete?" ,MessageBoxButton.YesNo) == MessageBoxResult.Yes);
                catList.Remove(selected);
                CatList = new List<Cat>(CatList);
                Notify("Selected");
            }
        }

        public ViewModel() 
        {
            CatDB catDB = new CatDB();
            catList = new List<Cat>( catDB.GetCats() );
        }

        public List<Cat> CatList
        { get { return catList; }
            set { catList = value; Notify("CatList"); }
        }

    }
}
