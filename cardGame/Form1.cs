using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace cardGame
{
    public partial class Form1 : Form
    {
        bool cvcVisible = false;

        public Form1()
        {
            InitializeComponent();

            pictureBox3.Visible = false; 
            label4.Text = "CVC";

            button1.Click += button1_Click;
            pictureBox3.Click += pictureBox3_Click;
            pictureBox4.Click += pictureBox4_Click;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 16 && textBox1.Text.All(char.IsDigit))
                textBox1.BackColor = Color.YellowGreen;
            else
                textBox1.BackColor = Color.Red;
        }
   private void pictureBox4_Click(object sender, EventArgs e)
        {
            
            cvcVisible = true;

            pictureBox3.Visible = true;   
            pictureBox4.Visible = false;  

            label4.Text = textBox3.Text;   
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            cvcVisible = false;

            pictureBox3.Visible = false;  
            pictureBox4.Visible = true;   

            label4.Text = "CVC";      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valid = true;
            if (textBox1.Text.Length == 16 && textBox1.Text.All(char.IsDigit))
            {
                label1.Text = "";
                for (int i = 0; i < 16; i++)
                {
                    if (i % 4 == 0 && i != 0) label1.Text += "  ";
                    label1.Text += textBox1.Text[i];
                }
            }
            else valid = false;
            if (textBox2.Text.Length > 4 && textBox2.Text.Contains(" "))
                label2.Text = textBox2.Text.ToUpper();
            else
                valid = false;

            if (dateTimePicker1.Value > DateTime.Now)
                label3.Text = dateTimePicker1.Value.ToString("MM/yy");
            else
                valid = false;

            if (textBox3.Text.Length == 3 && textBox3.Text.All(char.IsDigit))
            {
                if (cvcVisible)
                    label4.Text = textBox3.Text; 
                else
                    label4.Text = "CVC";        
            }
            else valid = false;

            if (valid)
                MessageBox.Show("Məlumatlar uğurla karta yazıldı!");
            else
                MessageBox.Show("Məlumatlar düzgün deyil!");
        }

    }

}
