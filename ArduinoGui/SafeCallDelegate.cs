using System;

namespace ArduinoGui
{
    internal class SafeCallDelegate
    {
        private Action<string> writeTextSafe;

        public SafeCallDelegate(Action<string> writeTextSafe)
        {
            this.writeTextSafe = writeTextSafe;
        }
    }
}