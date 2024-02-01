using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWinForms
{
    public partial class Form1 : Form
    {
        ViewModel vm;
        public Form1()
        {
            InitializeComponent();
            vm = new ViewModel();
        }

        private void buttonRavno_Click(object sender, EventArgs e)
        {

            Answer.Text = vm.Evaluate(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ' ' + '+' + ' '; 
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ' ' + '-' + ' ';
        }

        private void buttonYmn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ' ' + '*' + ' ';
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ' ' + '/' + ' ';
        }





        //Событие на кнопку равно - вызов vm.Evaluate() и отображение результата в текстбоксе

    }
}
