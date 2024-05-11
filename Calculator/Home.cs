using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Home : Form
    {
        int move;
        int movx;
        int movy;

        double[] numbers = new double[100];
        char[] operations = new char[100];
        int count = 0;

        public Home() => InitializeComponent();

        private void Lab_title_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movx = e.X;
            movy = e.Y;
        }

        private void Lab_title_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }
        }

        private void Lab_title_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void But_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void But_c_Click(object sender, EventArgs e)
        {
            lab_1.Text = lab_2.Text = ""; 
            count = 0;
        }

        private void But_ce_Click(object sender, EventArgs e)
        {
            lab_1.Text = "";
        }

        private void But_Click(object sender, EventArgs e)
        {
            if (sender is Button b)
            {
                lab_1.Text += b.Text;
            }
        }

        private void But_operation_Click(object sender, EventArgs e)
        {
            //if (lab_1.Text.Length != 0)
            //{
            //    numbers[count] = double.Parse(lab_1.Text);
            //    But_Click(sender, e);
            //    lab_2.Text += lab_1.Text;
            //    operations[count] = lab_2.Text[lab_2.Text.Length - 1];
            //    But_ce_Click(sender, e);
            //    count++;
            //}
            if (lab_1.Text.Length != 0)
            {
                numbers[count] = double.Parse(lab_1.Text);
                if (sender is Button b)
                {
                    lab_1.Text += b.Text;
                }
                lab_2.Text += lab_1.Text;
                operations[count] = lab_2.Text[lab_2.Text.Length - 1];
                lab_1.Text = "";
                count++;
            }
        }

        private void But_negative_Click(object sender, EventArgs e)
        {
            if (lab_1.Text.Length!=0)
            {
                string text=lab_1.Text;
                lab_1.Text = "-"+text;
            }
        }

        private void But_equal_Click(object sender, EventArgs e)
        {
            But_operation_Click(sender, e);
            double result = 0;
            for (int j = 0; j < count; j++)
            {
                switch (operations[j])
                {
                    case 'X':
                        if (count == 2)
                        {
                            result = numbers[j] * numbers[j + 1];
                            break;
                        }
                        if (j==0)
                        {
                            numbers[j+1] = numbers[j] * numbers[j + 1];
                            break;
                        }
                        numbers[j] = numbers[j] * numbers[j + 1];
                        break;
                    case '/':
                        if (count == 2)
                        {
                            result = numbers[j] / numbers[j + 1];
                            break;
                        }
                        if (j == 0)
                        {
                            numbers[j + 1] = numbers[j] / numbers[j + 1];
                            break;
                        }
                        numbers[j] = numbers[j] / numbers[j + 1];
                        break;
                    case '%':
                        if (count == 2)
                        {
                            result = numbers[j] % numbers[j + 1];
                            break;
                        }
                        if (j == 0)
                        {
                            numbers[j + 1] = numbers[j] % numbers[j + 1];
                            break;
                        }
                        numbers[j] = numbers[j] % numbers[j + 1];
                        break;
                }
            }
            for (int i = 0; i < count; i++)
            {
                switch (operations[i])
                {
                    case '+':
                        result += numbers[i] + numbers[i + 1]; 
                        break;
                    case '-':
                        result += numbers[i] - numbers[i + 1];
                        break;
                }
            }
            if (count == 1)
            {
                result = numbers[0];
            }
            lab_1.Text = result.ToString();
            count = 0;
        }
    }
}