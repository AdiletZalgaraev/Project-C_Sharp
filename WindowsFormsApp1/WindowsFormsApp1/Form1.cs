using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        //    List<User>users = new List<User>();
        //    users.Add(new User()
        //    {
        //        Id = 1, Name = "Igor", Login = "User", Password = "Igor"
        //    });
        //    users.Add(new User()
        //    {
        //        Id = 2, Name = "Lol", Login = "Admin", Password = "Admin"
        //    });
        //    users.Add(new User()
        //    {
        //        Id = 3, Name = "User", Login = "User", Password = "User"
        //    });
        //    UserSaving.Save(users);
        //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            List<User> users = UserLoader.LoadUsers();
            foreach (User user in users)
            {
                if(login.Equals(user.Login)
                    && password.Equals(user.Password))
                {
                    Form2 form2 = new Form2(user);
                    form2.ShowDialog();
                    return;
                }
            }
        MessageBox.Show("=(");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
