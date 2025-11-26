namespace cardGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 16)
            {
                textBox1.BackColor = Color.YellowGreen;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;

        }

    }
}
