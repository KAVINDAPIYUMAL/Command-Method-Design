using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commone_method_design
{
    class SimpleRemoteControl
    {
        private ICommand _slot; // only one button

        public SimpleRemoteControl()
        {
        }

        public void SetCommand(ICommand command)
        {
            // set the command the remote will execute
            _slot = command;
        }

        public void ButtonWasPressed()
        {
            _slot.Execute();
        }
    }
}
