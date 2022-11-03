using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment8_MaksimTomilin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string string1;
            StreamReader inputFile = File.OpenText("BoyNames.txt");
            while ((string1 = inputFile.ReadLine()) != null)
                BoyNameListbox.Items.Add(string1);
            inputFile.Close();

            string string2;
            StreamReader inputFile1 = File.OpenText("GirlNames.txt");
            while ((string2 = inputFile1.ReadLine()) != null)
                GirlNameListbox.Items.Add(string2);
            inputFile1.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Boy = textBox1.Text;
            bool found = false;
            for (int n = 0; n < BoyNameListbox.Items.Count; n++)
            {
                if ((string)BoyNameListbox.Items[n] == Boy)
                {
                    found = true;
                    break;
                }
            }

            if (found)
                MessageBox.Show("Popular name");
            else
                MessageBox.Show("Not popular name");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Girl = textBox2.Text;
            bool found = false;
            for (int n = 0; n < GirlNameListbox.Items.Count; n++)
            {
                if ((string)GirlNameListbox.Items[n] == Girl)
                {
                    found = true;
                    break;
                }
            }

            if (found)
                MessageBox.Show("Popular name");
            else
                MessageBox.Show("Not popular name");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
