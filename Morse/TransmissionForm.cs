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
    public partial class TransmissionForm : Form
    {
        private int curCharacter;
        private MorseCodeGenerator morsecodegenerator;
        private DateTime startTime;
        private double totalTime;
        private Checker checker;

        public TransmissionForm()
        {
            InitializeComponent();
            morsecodegenerator = MorseCodeGenerator.getMorseCodeGenerator();
            checker = new Checker(label3);
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            label2.Text = "";

            Random random = new Random();
            curCharacter = random.Next(4) + 1;
            label2.Text = morsecodegenerator.morseDictionary[curCharacter];
        }

        private void morse_key_button_MouseDown(object sender, MouseEventArgs e)
        {
            morsecodegenerator.start();
            startTime = DateTime.Now;            
        }

        private void morse_key_button_MouseUp(object sender, MouseEventArgs e)
        {
            morsecodegenerator.stop();
            totalTime = (DateTime.Now - startTime).TotalMilliseconds;
            if ((totalTime > 0) && (totalTime < 200))
            { // погрешность
                if (curCharacter != 0)
                {
                    checker.check(curCharacter, 0);
                }
            }
            else if ((totalTime > 200) && (totalTime < 1000))
            {
                if (curCharacter != 0) checker.check(curCharacter, 1);
            }
            else
            {
                label3.Text = "Неверно";
            }            
        }
    }
}
