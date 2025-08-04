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
    public partial class Form2 : Form
    {
        User user;
        List<Points> points;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(User user)
        {
            InitializeComponent();
            this.user = user;
            points = new List<Points>();
        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox1.Text);
            double z = Convert.ToDouble(textBox1.Text);

            Points p = new Points() { x = x, y = y, z = z };
            points.Add(p);
            listBox1.Items.Add(p.x + " " + p.y + " " + p.z);
        }
    }
}
