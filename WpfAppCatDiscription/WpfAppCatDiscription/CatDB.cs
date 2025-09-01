using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppCatDiscription
{
    internal class CatDB
    {
        List<Cat> cats;
        public CatDB()
            {
            cats = new List<Cat>();
            cats.Add(new Cat("Kiss kiss", 12, "C:\\Users\\ZalgaraevA\\Downloads\\cat-animals-photography.jpeg"));
            cats.Add(new Cat("Meow meow", 15, "C:\\Users\\ZalgaraevA\\Downloads\\cat-animals-photography.jpeg"));
            cats.Add(new Cat("Gaw Meaq", 10, "C:\\Users\\ZalgaraevA\\Downloads\\cat-animals-photography.jpeg"));
            cats.Add(new Cat("8shi", 2, "C:\\Users\\ZalgaraevA\\Downloads\\cat-animals-photography.jpeg"));
        }
        public List<Cat> GetCats()
        {
            return cats;
        }
    }
}
