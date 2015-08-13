
namespace DefiningClassesPart1
{
    using System;

    //Problem 3. Enumeration
    public enum BatteryType
    {
        LiIon, NiMH, NiCd, unknown
    }
    public class Battery
    {
        private string model;
        private double? hoursTalk;
        private double? hoursIdle;
        private BatteryType? type;

        public Battery()
        {
        }
        public Battery(string model)
        {
            this.Model = model;
        }
        public Battery(double? hoursTalk,
                        double? hoursIdle,
                        BatteryType? type)
        {
            this.HoursTalk = hoursTalk;
            this.HoursIdle = hoursIdle;
            this.Type = type;
        }
        //full constructor
        public Battery(string model = null,
                        double? hoursTalk = null,
                        double? hoursIdle = null,
                        BatteryType? type = null)
        {
            this.Model = model;
            this.HoursTalk = hoursTalk;
            this.HoursIdle = hoursIdle;
            this.Type = type;
        }
        public string Model
        {
            get { return this.model; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentOutOfRangeException("Model name should be > 0 symbols ");
                }
                else
                {
                    this.model = value;
                }
            }
        }
        public double? HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Hours Talk should be > 0");
                }
                else
                {
                    this.hoursTalk = value;
                }
            }
        }
        public double? HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Hours Idle should be > 0");
                }
                else
                {
                    this.hoursIdle = value;
                }
            }
        }
        public BatteryType? Type 
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public override string ToString()
        {
            return String.Format("Model: {0}, Hours Talk: {1}, Hours Idle: {2}, Battery type: {3}",
                this.Model, this.HoursTalk, this.HoursIdle, this.Type);
        }
    }
}
