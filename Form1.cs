using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public static double rez1(double x, double z) //первое решение
        {
            return (2 * Math.Pow(x, 2) + x - 5) / (x + 2) + 1 / Math.Tan(x / 2 * z);

        }

        public static double rez2(double x, double b) //второе решение
        {
            return (Math.Sqrt(x - b)) / 2 * b - Math.Tan(x) / Math.Pow(b, 2);
        }


        private void button1_Click(object sender, EventArgs e) //смена цветов кнопки 1
        {
            Random rand = new Random(); int c = rand.Next(1, 5);
            if (button2.BackColor != SystemColors.Control) c = 0;
            switch (c)
            {
                case 0: button2.BackColor = SystemColors.Control; button2.UseVisualStyleBackColor = true; break;
                case 1: button2.BackColor = Color.White; break;
                case 2: button2.BackColor = Color.Gray; break;
                case 3: button2.BackColor = Color.Red; break;
                case 4: button2.BackColor = Color.Green; break;

            }
            if (button1.BackColor == Color.White)
            {
                textBox4.Text = Convert.ToString(rez1(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
            }
        }

        private void button2_Click(object sender, EventArgs e) //смена цветов кнопки 2
        {
            Random rand = new Random(); int c = rand.Next(1, 5);
            if (button1.BackColor != SystemColors.Control) c = 0;
            switch (c)
            {
                case 0: button1.BackColor = SystemColors.Control; button1.UseVisualStyleBackColor = true; break;
                case 1: button1.BackColor = Color.White; break;
                case 2: button1.BackColor = Color.Gray; break;
                case 3: button1.BackColor = Color.Red; break;
                case 4: button1.BackColor = Color.Green; break;

            }
            if (button2.BackColor == Color.Gray)
            {
                textBox4.Text = Convert.ToString(rez1(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox3.Text)));
            }
        }

        private void button3_Click(object sender, EventArgs e) //команды кнопки 3
        {
            string message = "Ви хочете завершити роботу програми?";
            string caption = "RLY?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}