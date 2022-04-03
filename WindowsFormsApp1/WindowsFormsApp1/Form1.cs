using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                listBox1.Tag = JsonConvert.DeserializeObject("book.json") as List<Info>;
                foreach (Info pers in listBox1.Tag as List<Info>)
                    listBox1.Items.Add(pers.Name);
            }
            catch
            {
                listBox1.Tag = new List<Info>();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            (listBox1.Tag as List<Info>).Add(form2.pers);
            listBox1.Items.Add(form2.pers.Name);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string json = JsonConvert.SerializeObject(listBox1.Tag, Formatting.Indented);
            File.WriteAllText("book.json", json);
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Info pers = (listBox1.Tag as List<Info>)[listBox1.SelectedIndex];
                textBox1.Text = pers.Name;
                textBox2.Text = pers.Surname;
                textBox3.Text = pers.FName;
                textBox4.Text = pers.Phone;
                textBox5.Text = pers.Email;
                textBox6.Text = pers.Address;
                textBox7.Text = pers.Job;
                textBox9.Text = pers.AddInfo;
                pictureBox1.Image = Image.FromFile(pers.Img);
            }
            catch
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (listBox1.Tag as List<Info>).RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            listBox1.SelectedIndex = -1;
        }
    }
}
