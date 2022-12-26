namespace Lab1._1
{
    public partial class Form1 : Form
    {
        double input1 = 0;
        string operation = "";
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// ปุ่มเลข 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            this.input.Text = this.input.Text + "1";
        }
        /// <summary>
        /// ปุ่มเลข 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button14_Click(object sender, EventArgs e)
        {
            this.input.Text = this.input.Text + "2";
        }
        /// <summary>
        /// ปุ่มเลข 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button13_Click(object sender, EventArgs e)
        {
            this.input.Text = this.input.Text + "3";
        }
        /// <summary>
        /// ปุ่มเลข 4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            this.input.Text = this.input.Text + "4";
        }
        /// <summary>
        /// ปุ่มเลข 5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button10_Click(object sender, EventArgs e)
        {
            this.input.Text = this.input.Text + "5";
        }
        /// <summary>
        /// ปุ่มเลข 6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, EventArgs e)
        {
            this.input.Text = this.input.Text + "6";
        }
        /// <summary>
        /// ปุ่มเลข 7
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button12_Click(object sender, EventArgs e)
        {
            this.input.Text = this.input.Text + "7";
        }
        /// <summary>
        /// ปุ่มเลข 8
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button11_Click(object sender, EventArgs e)
        {
            this.input.Text = this.input.Text + "8";
        }
        /// <summary>
        /// ปุ่มเลข 9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            this.input.Text = this.input.Text + "9";
        }
        /// <summary>
        /// ปุ่มเลข 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            this.input.Text = this.input.Text + "0";
        }
        /// <summary>
        /// ปุ่ม +
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.input1 = double.Parse(this.input.Text);
            this.input.Text = "";
            this.operation = "+";
        }
        /// <summary>
        /// ปุ่ม /
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            this.input1 = double.Parse(this.input.Text);
            this.input.Text = "";
            this.operation = "/";
        }
        /// <summary>
        /// จุดทศนิยม
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button16_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// ปุ่ม =
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button15_Click(object sender, EventArgs e)
        {
            double input2 = double.Parse(this.input.Text);
            double result = 0;
            if (this.operation == "+")
            {
                result = input1 + input2;
            }
            else if (this.operation == "-")
            {
                result = input1 - input2;
            }
            else if (this.operation == "*")
            {
                result = input1 * input2;
            }
            else if (this.operation == "/")
            {
                result = input1 / input2;
            }
            this.input.Text = result.ToString();
        }
        /// <summary>
        /// ปุ่ม *
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.input1 = double.Parse(this.input.Text);
            this.input.Text = "";
            this.operation = "*";
        }
        /// <summary>
        /// ปุ่ม -
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.input1 = double.Parse(this.input.Text);
            this.input.Text = "";
            this.operation = "-";
        }

        private void input_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.input.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}