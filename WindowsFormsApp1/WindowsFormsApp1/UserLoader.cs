using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


namespace WindowsFormsApp1
{
    internal class UserLoader
    {
        public static List<User> LoadUsers()
        {
            FileStream file = new
                FileStream("logins.txt", FileMode.OpenOrCreate);
            StreamReader streamReader = new StreamReader(file);
            string text = streamReader.ReadToEnd();
            file.Close();
            return JsonConvert.DeserializeObject<List<User>>(text);
        }
    }
}
