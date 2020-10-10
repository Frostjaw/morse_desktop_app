using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Reflection;

namespace Morse
{
    class MorseCodeGenerator
    {
        private static MorseCodeGenerator instance;
        private SoundGenerator soundgenerator;
        private int _dotDuration;
        public int DotDuration
        {
            get { return _dotDuration; }
            set { _dotDuration = value; }
        }
        public readonly Dictionary<int, String> morseDictionary;

        private MorseCodeGenerator(int frequency, int dotDuration)
        {
            soundgenerator = new SoundGenerator(frequency);
            _dotDuration = dotDuration;
            morseDictionary = new Dictionary<int, string>(); // словарь для преобразования число - буква
            morseDictionary.Add(1, "А");
            morseDictionary.Add(2, "Б");
            morseDictionary.Add(3, "В");
            morseDictionary.Add(4, "Г");
            //morseDictionary.Add(5, "Д");
            //morseDictionary.Add(6, "Е");
            //morseDictionary.Add(7, "Ж");
            //morseDictionary.Add(8, "З");
            //morseDictionary.Add(9, "И");
            //morseDictionary.Add(10, "Й");
            //morseDictionary.Add(11, "К");
            //morseDictionary.Add(12, "Л");
            //morseDictionary.Add(13, "М");
            //morseDictionary.Add(14, "Н");
            //morseDictionary.Add(15, "О");
            //morseDictionary.Add(16, "П");
            //morseDictionary.Add(17, "Р");
            //morseDictionary.Add(18, "С");
            //morseDictionary.Add(19, "Т");
            //morseDictionary.Add(20, "У");
            //morseDictionary.Add(21, "Ф");
            //morseDictionary.Add(22, "Х");
            //morseDictionary.Add(23, "Ц");
            //morseDictionary.Add(24, "Ч");
            //morseDictionary.Add(25, "Ш");
            //morseDictionary.Add(26, "Щ");
            //morseDictionary.Add(27, "Ы");
            //morseDictionary.Add(28, "Ь");
            //morseDictionary.Add(29, "Э");
            //morseDictionary.Add(30, "Ю");
            //morseDictionary.Add(31, "Я");
        }

        public static MorseCodeGenerator getMorseCodeGenerator()
        {
            if (instance == null)
            {
                instance = new MorseCodeGenerator(1000, 100); // по умолчанию частота = 1000, длительность точки = 100мс
            }
            return instance;
        }

        public void setFrequency(int freq)
        {
            soundgenerator.setFrequency(freq);
        }

        public int getFrequency()
        {
            return soundgenerator.getFrequency();
        }

        //public void setDotDuration(int dotDuration)
        //{
        //    _dotDuration = dotDuration;
        //}

        //public int getDotDuration()
        //{
        //    return _dotDuration;
        //}

        // A
        public void play1()
        {
            soundgenerator.start();
            Thread.Sleep(_dotDuration);
            soundgenerator.stop();
            Thread.Sleep(_dotDuration);
            soundgenerator.start();
            Thread.Sleep(_dotDuration*3);
            soundgenerator.stop();
        }

        // Б
        public void play2()
        {
            soundgenerator.start();
            Thread.Sleep(_dotDuration*3);
            soundgenerator.stop();
            Thread.Sleep(_dotDuration);
            soundgenerator.start();
            Thread.Sleep(_dotDuration);
            soundgenerator.stop();
            Thread.Sleep(_dotDuration);
            soundgenerator.start();
            Thread.Sleep(_dotDuration);
            soundgenerator.stop();
            Thread.Sleep(_dotDuration);
            soundgenerator.start();
            Thread.Sleep(_dotDuration);
            soundgenerator.stop();
        }

        // В
        public void play3()
        {
            soundgenerator.start();
            Thread.Sleep(_dotDuration);
            soundgenerator.stop();
            Thread.Sleep(_dotDuration);
            soundgenerator.start();
            Thread.Sleep(_dotDuration * 3);
            soundgenerator.stop();
            Thread.Sleep(_dotDuration);
            soundgenerator.start();
            Thread.Sleep(_dotDuration * 3);
            soundgenerator.stop();
        }

        // Г
        public void play4()
        {
            soundgenerator.start();
            Thread.Sleep(_dotDuration * 3);
            soundgenerator.stop();
            Thread.Sleep(_dotDuration);
            soundgenerator.start();
            Thread.Sleep(_dotDuration * 3);
            soundgenerator.stop();
            Thread.Sleep(_dotDuration);
            soundgenerator.start();
            Thread.Sleep(_dotDuration);
            soundgenerator.stop();
        }

        public void playConcrete(int num)
        {
            String methodName = "play" + num;
            MethodInfo m = this.GetType().GetMethod(methodName);
            m.Invoke(this, null);
        }

        public void start()
        {
            soundgenerator.start();
        }

        public void stop()
        {
            soundgenerator.stop();
        }
    }
}
