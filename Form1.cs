namespace WorkCT
{
    public partial class Form1 : Form
    {
        double Input1 = 0.0;
        double Input2 = 0.0;
        string operation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // 5
            this.input1.Text = this.input1.Text + "5";
            this.input2.Text = this.input2.Text + "5";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 0
            this.input1.Text = this.input1.Text + "0";
            this.input2.Text = this.input2.Text + "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 2
            this.input1.Text = this.input1.Text + "2";
            this.input2.Text = this.input2.Text + "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // 8
            this.input1.Text = this.input1.Text + "8";
            this.input2.Text = this.input2.Text + "8";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // - 
            //assign value to class variable
            this.Input1 = Double.Parse(this.input1.Text);

            //clear input text
            this.input1.Text = "";
            this.input2.Text = this.input2.Text = "-";
            this.operation = "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // / 
            //assign value to class variable
            this.Input1 = Double.Parse(this.input1.Text);

            //clear input text
            this.input1.Text = "";
            this.input2.Text = this.input2.Text = "/";
            this.operation = "/";
        }

        private void input1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // 1
            this.input1.Text = this.input1.Text + "1";
            this.input2.Text = this.input2.Text + "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 3
            this.input1.Text = this.input1.Text + "3";
            this.input2.Text = this.input2.Text + "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 4
            this.input1.Text = this.input1.Text + "4";
            this.input2.Text = this.input2.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // 6
            this.input1.Text = this.input1.Text + "6";
            this.input2.Text = this.input2.Text + "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // 7
            this.input1.Text = this.input1.Text + "7";
            this.input2.Text = this.input2.Text + "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // 9
            this.input1.Text = this.input1.Text + "9";
            this.input2.Text = this.input2.Text + "9";
        }

        private void button17_Click(object sender, EventArgs e)
        {
           // c
            this.input1.Text = "";
            this.input2.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // .
            this.input1.Text = this.input1.Text = ".";
            this.input2.Text = this.input2.Text = ".";
        }

        private void button16_Click(object sender, EventArgs e)
        {
           // + 
           //assign value to class variable
            this.Input1 = Double.Parse(this.input1.Text);
            
            //clear input text
            this.input1.Text = "";
            this.input2.Text = this.input2.Text = "+";
            this.operation = "+";
            

        }

        private void button14_Click(object sender, EventArgs e)
        {
            // * 
            //assign value to class variable
            this.Input1 = Double.Parse(this.input1.Text);

            //clear input text
            this.input1.Text = "";
            this.input2.Text = this.input2.Text = "*";
            this.operation = "*";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double Input2 = Double.Parse(this.input1.Text);
            double result = 0;
            if (this.operation == "+") 
            {
                input2.Text = Input1.ToString() + operation + Input2.ToString() + "=" + (Input1 + Input2).ToString();
              input1.Text = (Input1 + Input2).ToString();
            }
            else if (this.operation == "-")
            {
                input2.Text = Input1.ToString() + operation + Input2.ToString() + "=" + (Input1 + Input2).ToString();
                input1.Text = (Input1 - Input2).ToString();
            }
            else if (this.operation == "*")
            {
                input2.Text = Input1.ToString() + operation + Input2.ToString() + "=" + (Input1 + Input2).ToString();
                input1.Text = (Input1 * Input2).ToString();
            }
            else if (this.operation == "/")
            {
                input2.Text = Input1.ToString() + operation + Input2.ToString() + "=" + (Input1 + Input2).ToString();
                input1.Text = (Input1 / Input2).ToString();
            }
           
        }
    }
}