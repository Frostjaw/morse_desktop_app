using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morse
{
    public partial class Learning1 : Form
    {
        private MorseCodeGenerator morsecodegenerator;

        public Learning1()
        {
            InitializeComponent();
            morsecodegenerator = MorseCodeGenerator.getMorseCodeGenerator();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            morsecodegenerator.play1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            morsecodegenerator.play2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            morsecodegenerator.play3();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            morsecodegenerator.play4();
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            ReceptionForm frm = new ReceptionForm();
            frm.Show();
            this.Close();
        }
    }
}
