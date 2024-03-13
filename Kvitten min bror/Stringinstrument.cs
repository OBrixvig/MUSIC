using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvitten_min_bror
{
    public class Stringinstrument : Instrument
    {
        public Stringinstrument(string name, int numberofstrings) : base(name)
        {
            Numbersofstrings = numberofstrings;
        }

        protected int Numbersofstrings { get; private set; }

        public override string ToString()
        {
            return Name + Numbersofstrings;
        }

    }



}
