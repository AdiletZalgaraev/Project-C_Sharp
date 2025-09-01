using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppCatDiscription
{
    internal class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string PictureUrl { get; set; }
        public Cat( string name, int age, string pictureUrl ) 
        {
            Name = name;
            Age = age;
            PictureUrl = pictureUrl;
        }

        public override string ToString() 
        {
            return "Kot name: " + Name;
        }

    }
}
