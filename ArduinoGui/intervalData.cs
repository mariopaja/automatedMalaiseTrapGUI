using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoGui
{

    /*
        class intervalData  :   creates a local storage which has four variables
                            :   used to temporary store the interval data & show them in the create program table
     */
    class intervalData
    {
        public string bottle { get; set; }
        public string days { get; set; }
        public string hours { get; set; }
        public string mins { get; set; }
    }
}
