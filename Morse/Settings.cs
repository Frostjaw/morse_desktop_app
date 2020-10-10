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
    public partial class Settings : Form
    {
        private int curFrequency;
        private int curDotDuration;
        private MorseCodeGenerator morsecodegenerator;

        public Settings()
        {
            InitializeComponent();
            morsecodegenerator = MorseCodeGenerator.getMorseCodeGenerator();
            curFrequency = morsecodegenerator.getFrequency();
            curDotDuration = morsecodegenerator.DotDuration;
            frequency_trackBar.Value = (curFrequency - 1000) / 100;
            label2.Text = curFrequency.ToString();
            dotDuration_trackBar.Value = (curDotDuration - 100) / 50;
            label3.Text = curDotDuration.ToString();
        }

        private void frequency_trackBar_Scroll(object sender, EventArgs e)
        {
            curFrequency = (frequency_trackBar.Value * 100) + 1000; // преобразование значений трекбара в нужные
            label2.Text = curFrequency.ToString();            
            morsecodegenerator.setFrequency(curFrequency);
        }

        private void dotDuration_trackBar_Scroll(object sender, EventArgs e)
        {
            curDotDuration = (dotDuration_trackBar.Value * 50) + 100; // преобразование значений трекбара в нужные
            label3.Text = curDotDuration.ToString();
            morsecodegenerator.DotDuration = curDotDuration;
        }
    }
}
