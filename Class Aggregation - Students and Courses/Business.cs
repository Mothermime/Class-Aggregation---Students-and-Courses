using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Aggregation___Students_and_Courses
{
    class Business
    {
        private string _field;
        private string _room;

        //properties

            public string Field { get; set; }
        public string Room { get; set; }
        //constructor
        public Business()
        {
            Room = "Room A1";
            Field = "International Relations";
        }
    }
}
