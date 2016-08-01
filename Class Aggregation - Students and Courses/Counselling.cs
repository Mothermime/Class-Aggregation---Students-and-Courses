using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Aggregation___Students_and_Courses
{
    class Counselling
    {//private fields

        //constructor
        public Counselling()
        { Room = "Room A4";
            Field = "Retail Therapy";
            Toy = "Small cuddle bunny";
        }
        //
        //Properties
            public string Field { get; set; }
        public string Room { get; set; }
        public string Toy { get; set; }

    }
}
