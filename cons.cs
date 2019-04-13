using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class cons
    {
        // private variables atau field
        private int year;
        private int month;
        private int date;
        private int hour;
        private int minute;
        private int second;
        // property
        public int Year {
            get { return year; }
            set { year = value; }
        }
        public int Month {
            get { return month; }
            set { month = value; }
        }
        public int Date {
            get { return date; }
            set { date = value; }
        }
        public int Hour {
            get { return hour; }
            set { hour = value; }
        }
        public int Minute {
            get { return minute; }
            set { minute = value; }
        }
        public int Second {
            get { return second; }
            set { second = value; }
        }

        // constructor
        public cons(int year, int month, int date,
            int hour, int minute, int second)
        {
            this.year = year;
            this.month = month;
            this.date = date;
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
    }
}
