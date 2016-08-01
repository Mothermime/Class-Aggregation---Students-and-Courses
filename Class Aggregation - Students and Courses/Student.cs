using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Aggregation___Students_and_Courses
{
    class Student
    {
        //fields - internal working in the class.
        private string _fname;
        private string _fullname;
        private string Business;
        private string WishyWashylifeSkills;

        //attached Class that you added in 
        public String City { get; set; }
        public Business business { get; set; }
        public Counselling counselling { get; set; }

        //constructors - hold defaulr data
        public Student()
        {
            counselling = new Counselling();
            business = new Business();
            //Sets start data
            College = "Vision College";
            City = "Christchurch";
        }
        //properties
        public string Firstname
        {
            //get = data out
            get { return _fname; }
            //set = data in
            set
            {
                _fname = value;
                if (_fname == "")
                {
                    _fname = "No name";
                }
            }
        }
        public String Lastname { get; set; }
        public string College { get; set; }

        //method
        public string Fullname()
        {
            return Firstname + " " + Lastname;
        }
    }
}
