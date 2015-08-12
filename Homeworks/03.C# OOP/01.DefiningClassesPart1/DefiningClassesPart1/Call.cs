//Problem 8. Calls
//Create a class Call to hold a call performed through a GSM.
//It should contain date, time, dialled phone number and duration (in seconds).

namespace DefiningClassesPart1
{
    using System;
    public class Call
    {
        private DateTime date;
        private int duration;
        private string dialledN;

        public Call()
        {
        }
        public Call(DateTime date, int duration, string dialledN)
        {
            this.Date = date;
            this.Duration = duration;
            this.DialledN = dialledN;
        }
        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
        public string DialledN 
        {
            get { return this.dialledN; }
            set { this.dialledN = value; }
        }

        public override string ToString()
        {
            return String.Format("Date and time: {0}, Duration: {1}, Dialled number: {2}",
                                  this.Date, this.Duration, this.DialledN);
        }

    }
}
