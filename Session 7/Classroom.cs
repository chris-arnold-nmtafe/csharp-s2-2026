using System;
using System.Collections.Generic;
using System.Text;

namespace Session_7 {
    internal class Classroom {
        public string roomNumber;
        public int floorNumber;
        public bool hasAircon;
        private string[] Students { get; set; }

        public void PrintStudents() { }
        public string GetStudent(int index) {
            return Students[index]; 
        }
        public void TurnAirconOn() { }
        private void TurnAirconOff() { }
    }
}
