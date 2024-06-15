using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4_1
{
    class Time
   {
        int hours;
        int minutes;
        int seconds;

        public Time()
        { }
        public Time(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }
        public void print24(int hours, int minutes, int seconds)
        {
            Console.WriteLine("The time is: {0}" + ":" + "{1}" + ":" + "{2}", hours, minutes, seconds);
        }
        public void print12(int hours, int minutes, int seconds)
        {
            if (hours >12) 
            { this.hours = hours - 12;
            string x = "PM";
                Console.WriteLine("The time is: {0}" + ":" + "{1}" + ":" + "{2}" + "{3}", this.hours, minutes, seconds, x); }
            else
            {
                string x = "AM";
                Console.WriteLine("The time is: {0}" + ":" + "{1}" + ":" + "{2}" + "    {3}", this.hours, minutes, seconds, x);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        { Time n = new Time();
            n.print24(22,05,31);
            n.print12(22, 05, 31);
        }
    }
}
