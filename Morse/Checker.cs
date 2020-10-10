using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Morse
{
    class Checker
    {
        private Label _label;
        private int counter;
        private int[] characterCode;
        private System.Timers.Timer timer;

        public Checker(Label label)
        {
            _label = label;
            counter = 0;

            timer = new System.Timers.Timer(1000);
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            _label.Text = "Неверно";
            counter = 0;
        }

        public void check(int curCharacter, int curCode)
        {
            switch (curCharacter)
            {
                case 1:
                    characterCode = new int[] { 0, 1 };
                    break;
                case 2:
                    characterCode = new int[] { 1, 0, 0, 0 };
                    break;
                case 3:
                    characterCode = new int[] { 0, 1, 1 };
                    break;
                case 4:
                    characterCode = new int[] { 1, 1, 0 };
                    break;
            }

            timer.Stop();
            if (counter < characterCode.Length)
            {
                if (curCode == characterCode[counter])
                {
                    counter++;
                    timer.Start();
                    if (counter == characterCode.Length)
                    {
                        _label.Text = "Верно";
                        counter = 0;
                        timer.Stop();
                    }
                }
                else
                {
                    counter = 0;
                    _label.Text = "Неверно";
                }
            }
        }
    }
}
