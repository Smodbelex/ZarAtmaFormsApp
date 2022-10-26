namespace zaratma
{
    public partial class Form1 : Form
    {
        Random rnd=new Random();
        int zar1;
        int zar2;
        public Form1()
        {
            InitializeComponent();
        }
        int b1, b2, b3;
        private void button1_Click(object sender, EventArgs e)
        {
            b1++;
                label5.Text = b1.ToString();
            zar1=rnd.Next(1,7);
            zar2=rnd.Next(1,7);
            label3.Text = zar1.ToString();
            label4.Text = zar2.ToString();
            label6.Text = (zar1+ zar2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b2++;
            label10.Text = b2.ToString();
            zar1 = rnd.Next(1, 7);
            zar2 = rnd.Next(1, 7);
            label3.Text = zar1.ToString();
            label4.Text = zar2.ToString();
            label11.Text = (zar1 + zar2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            b3++;
            label13.Text = b3.ToString();
            zar1 = rnd.Next(1, 7);
            zar2 = rnd.Next(1, 7);
            label3.Text = zar1.ToString();
            label4.Text = zar2.ToString();
            label12.Text = (zar1 + zar2).ToString();
        }
    }
}