﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commone_method_design
{
    class Stereo
    {
        public void On()
        {
            Console.WriteLine("Stereo is on");
        }

        public void Off()
        {
            Console.WriteLine("Stereo is off");
        }

        public void SetCD()
        {
            Console.WriteLine("Stereo is set for CD input");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"Stereo volume set to {volume}");
        }
    }
}
