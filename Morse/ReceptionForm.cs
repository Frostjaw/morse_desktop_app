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
    public partial class ReceptionForm : Form
    {
        private MorseCodeGenerator morsecodegenerator;
        private int curCharacter;

        public ReceptionForm()
        {
            InitializeComponent();
            morsecodegenerator = MorseCodeGenerator.getMorseCodeGenerator();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            curCharacter = random.Next(4) + 1; // 4 - верхняя граница диапазона (0-4)
            morsecodegenerator.playConcrete(curCharacter);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            if (curCharacter == 1)
            {
                label2.Text = "Верно";
            }
            else
            {
                label2.Text = "Неверно";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            if (curCharacter == 2)
            {
                label2.Text = "Верно";
            }
            else
            {
                label2.Text = "Неверно";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            if (curCharacter == 3)
            {
                label2.Text = "Верно";
            }
            else
            {
                label2.Text = "Неверно";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            if (curCharacter == 4)
            {
                label2.Text = "Верно";
            }
            else
            {
                label2.Text = "Неверно";
            }
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            TransmissionForm frm = new TransmissionForm();
            frm.Show();
            this.Close();
        }
    }
}
