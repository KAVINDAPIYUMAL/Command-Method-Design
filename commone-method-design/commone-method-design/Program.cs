using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commone_method_design
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleRemoteControl remote = new SimpleRemoteControl();
            Light light = new Light();
            Stereo stereo = new Stereo();

            // We can change command dynamically
            remote.SetCommand(new LightOnCommand(light));
            remote.ButtonWasPressed();
            remote.SetCommand(new StereoOnWithCDCommand(stereo));
            remote.ButtonWasPressed();
            remote.SetCommand(new StereoOffCommand(stereo));
            remote.ButtonWasPressed();

            Console.ReadLine();
        }
    }
}
