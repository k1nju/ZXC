using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String__
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
        
            Answer.Text = vm.Evaluate("1+2*3");
        }



        //Событие на кнопку равно - вызов vm.Evaluate() и отображение результата в текстбоксе

    }
}
