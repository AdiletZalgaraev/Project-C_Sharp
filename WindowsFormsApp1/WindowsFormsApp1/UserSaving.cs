using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;


namespace WindowsFormsApp1
{
    internal class UserSaving
    {
        public static void Save(List<User> users)
        {
            string text = JsonConvert.SerializeObject(users);
            FileStream file = new
                FileStream("logins.txt", FileMode.OpenOrCreate);
            StreamWriter writer = new StreamWriter(file);
            writer.Write(text);
            writer.Flush();
            file.Close();
        }
    }
}
