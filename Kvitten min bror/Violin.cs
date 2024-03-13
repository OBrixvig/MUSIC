using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvitten_min_bror
{
    public class Violin : BowString
    {
        //constructor - arver navn fra instrument og strengeantal fra Stringinstrument.
        public Violin(string name, int pegBoxCount) : base(name, 4) 
        {
            PegBoxCount = pegBoxCount;
            using (var audioFile = new AudioFileReader(@"C:\Users\olive\Downloads\violin.wav"))
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

        //property for violin. Get.
        public int PegBoxCount { get; private set; }
        public override string ToString()
        {
            return Name + " it got " + Numbersofstrings + " and got " + PegBoxCount + " peg boxes" ;
        }
    }
}
