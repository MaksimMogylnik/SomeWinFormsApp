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

        public Info pers;

        public Form2()
        {
            InitializeComponent();
            pers = new Info();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pers.Name = textBox1.Text;
            pers.Surname = textBox2.Text;
            pers.FName = textBox3.Text;
            pers.Img = textBox18.Text;
            pers.Phone = textBox4.Text;
            pers.Email = textBox5.Text;
            pers.Address = textBox6.Text;
            pers.Job = textBox7.Text;
            pers.AddInfo = textBox9.Text;
            this.Close();
        }
    }
}
