using System;
using System.Collections.Generic;
using System.Text;

namespace Session_7 {
    internal class AlarmClock {
        public string make;
        public string model;
        private int hours;
        private int minutes;
        private int seconds;
        public string GetTime() { throw new NotImplementedException(); }
        public void MakeSound(string sound) { }
        private void ConvertToEpoch() { }
    }
}
