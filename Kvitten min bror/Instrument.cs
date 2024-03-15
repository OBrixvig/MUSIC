using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvitten_min_bror
{
    public class Instrument
    {
        public Instrument(string name)
        {
            Name = name;
        }
        //ToString metode.
        public override string ToString()
        {
            return Name;
        }
        //metode til at spille musikken.
        public virtual void Play()
        {

        }
        //Property for instrumenter:
        public string Name { get; private set; }

    }
}
