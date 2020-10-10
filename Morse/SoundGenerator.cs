using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace Morse
{
    class SoundGenerator
    {
        private WaveOut waveOut;
        private SineWaveOscillator osc;

        public SoundGenerator(int freq)
        {
            waveOut = new WaveOut();
            osc = new SineWaveOscillator(44100);
            osc.Frequency = freq;
            osc.Amplitude = 8192;
        }

        public void setFrequency(int freq)
        {
            osc.Frequency = freq;
        }

        public int getFrequency()
        {
            return (int)osc.Frequency;
        }

        public void start()
        {
            waveOut.Init(osc);
            waveOut.Play();
        }

        public void stop()
        {
            waveOut.Stop();
        }
    }
}
