using System.Windows.Forms.VisualStyles;

namespace Lab1
{
    
    public partial class Form1 : Form
    {
        double input1 = 0;
        string opperation = "";
        double result = 0;
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
            this.input1 = Double.Parse(this.Num1.Text);
            TextShow1.Text = this.input1 + " " + opperation;
            this.Num1.Text = "";
            this.opperation = "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.input1 = Double.Parse(this.Num1.Text);
            TextShow1.Text = this.input1 + " " + opperation;
            this.Num1.Text = "";
            this.opperation = "-";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.input1 = Double.Parse(this.Num1.Text);
            TextShow1.Text = this.input1 + " " + opperation;
            this.Num1.Text = "";
            this.opperation = "/";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.input1 = Double.Parse(this.Num1.Text);
            TextShow1.Text = this.input1 + " " + opperation;
            this.Num1.Text = "";
            this.opperation = "x";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.TextShow1.Text = "";
            this.Num1.Text = "0";


        }
        private void but1_Click(object sender, EventArgs e)
        {
            if (Num1.Text == "0")
                Num1.Clear();
            this.Num1.Text = this.Num1.Text + "1";         
        }


        private void but2_Click(object sender, EventArgs e)
        {
            if (Num1.Text == "0")
                Num1.Clear();
            this.Num1.Text = this.Num1.Text + "2";
        }

        private void but3_Click_1(object sender, EventArgs e)
        {
            if (Num1.Text == "0")
                Num1.Clear();
            this.Num1.Text = this.Num1.Text + "3";
        }

        private void but4_Click(object sender, EventArgs e)
        {
            if (Num1.Text == "0")
                Num1.Clear();
            this.Num1.Text = this.Num1.Text + "4";
        }

        private void but5_Click(object sender, EventArgs e)
        {
            if (Num1.Text == "0")
                Num1.Clear();
            this.Num1.Text = this.Num1.Text + "5";
        }

        private void but6_Click(object sender, EventArgs e)
        {
            if (Num1.Text == "0")
                Num1.Clear();
            this.Num1.Text = this.Num1.Text + "6";
        }

        private void but7_Click(object sender, EventArgs e)
        {
            if (Num1.Text == "0")
                Num1.Clear();
            this.Num1.Text = this.Num1.Text + "7";
        }

        private void but8_Click(object sender, EventArgs e)
        {
            if (Num1.Text == "0")
                Num1.Clear();
            this.Num1.Text = this.Num1.Text + "8";
        }

        private void but9_Click(object sender, EventArgs e)
        {
            if (Num1.Text == "0")
                Num1.Clear();
            this.Num1.Text = this.Num1.Text + "9";

        }

        private void but0_Click(object sender, EventArgs e)
        {
            if (Num1.Text == "0")
                Num1.Clear();
            this.Num1.Text = this.Num1.Text + "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Num1.Text = this.Num1.Text + ".";
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            double input2 = Double.Parse(this.Num1.Text);
            if(this.opperation == "+")
            {
                result = input1 + input2;
                Num1.Text = result.ToString("#,###.#####");

            } else if (this.opperation == "-")
            {
                result = input1 - input2;
                Num1.Text = result.ToString("#,###.#####");
            } else if(this.opperation == "x")
            {
                result = input1 * input2;
                Num1.Text = result.ToString("#,###.#####");

            }
            else if(this.opperation == "/")
                result= input1 / input2;
                Num1.Text = result.ToString("#,###.#####");

            

            
           
        }

        private void Answer3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


