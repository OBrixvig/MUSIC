using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvitten_min_bror
{
    public class Drum : Instrument
    {
        public Drum(string name, int numberOfDrums) : base(name)
        {
            NumberOfDrums = numberOfDrums;
            
        }

        public override void Play()
        {
            using (var audioFile = new AudioFileReader(@"C:\Users\olive\Downloads\drum.wav"))
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

        public int NumberOfDrums { get; private set; }
        public override string ToString()
        {
            return Name + "and has" + NumberOfDrums+ " drums attatch" ;
        }
    }
}
