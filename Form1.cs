namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // assign string value to textbox
            string Nub01 = this.Num1.Text;
            string Nub02 = this.Nub2.Text;
            double Nub03 = double.Parse(Nub01) + double.Parse(Nub02);
            this.Answer3.Text = Nub03.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Nub01 = this.Num1.Text;
            string Nub02 = this.Nub2.Text;
            double Nub04 = double.Parse(Nub01) - double.Parse(Nub02);
            this.Answer3.Text = Nub04.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Nub01 = this.Num1.Text;
            string Nub02 = this.Nub2.Text;
            double Nub06 = double.Parse(Nub01) / double.Parse(Nub02);
            this.Answer3.Text = Nub06.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Nub01 = this.Num1.Text;
            string Nub02 = this.Nub2.Text;
            double Nub05 = double.Parse(Nub01) * double.Parse(Nub02);
            this.Answer3.Text = Nub05.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Num1.Text = "";
            this.Nub2.Text = "";
            this.Answer3.Text = "";
        }

    
        private void but1_Click(object sender, EventArgs e)
        {
            this.Num1.Text = this.Num1.Text + "9";
        }

        
    }
}


