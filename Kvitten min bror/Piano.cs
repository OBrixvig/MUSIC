using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvitten_min_bror
{
    public class Piano : Stringinstrument //vi arver fra stringinstrument, som arver fra Instrument.
    {
        //constructor
        public Piano(string name, int numberOfKeys, int footPedals) : base(name, 88)
        {
            NumberOfKeys = numberOfKeys;
            FootPedals = footPedals;

        }

        public override void Play()
        {
            using (var audioFile = new AudioFileReader(@"C:\Users\olive\Downloads\piano.wav"))
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
        //property for attributter. Get.
        public int NumberOfKeys { get; private set; }
        public int FootPedals { get; private set; }

        //ToString metode:
        public override string ToString()
        {
            return "This is a " + Name + ", it got " + FootPedals + " foot pedals and " + Numbersofstrings + "number of strings.";
        }
    }
