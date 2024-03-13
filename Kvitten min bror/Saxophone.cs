using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvitten_min_bror
{
    public class Saxophone : Instrument //class arver fra Instrument.
    {
        //constructor.
        public Saxophone(string name, int buttonCount) : base(name) //constructor arver "name" fra instrument.
            {
             ButtonCount = buttonCount;
            using (var audioFile = new AudioFileReader(@"C:\Users\olive\Downloads\sax.wav"))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(1000);
                }

            }
        }

        //property get.
        public int ButtonCount { get; private set; }

        public override string ToString()
        {
            return Name + "and got " + ButtonCount + " buttoms" ;
        }

    }
}
