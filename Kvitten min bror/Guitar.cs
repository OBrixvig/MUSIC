using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvitten_min_bror
{
    public class Guitar : Stringinstrument
    {
        public Guitar(string name, bool acustisk) : base(name, 6)
        {
            _acustisk = acustisk;

            
        }
        public bool _acustisk { get; private set; }



        public override string ToString()
        {
            if (_acustisk == true) 
            return Name + " go" + Numbersofstrings + " and the guitar is Autistic"  ;
            else
            {
            return Name + " go" + Numbersofstrings + " and the guitar is Electic HAIL METAL FUCKERS" ;
            }
        }

        public override void Play()
        {
            using (var audioFile = new AudioFileReader(@"C:\Users\olive\Downloads\guitar.wav"))
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

    }
}
