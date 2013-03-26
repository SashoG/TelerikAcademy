using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    public class Battery
    {
        public enum BatteryType
        { LiIon, NiMH, NiCd, Nuclear }

        //Fields
        private string model;
        private decimal hoursIdle;
        private decimal hoursTalk;
        private BatteryType batType;

        public BatteryType BatType
        {
            get { return batType; }
            set { batType = value; }
        } 

        //Properties
        public string Model
        {
            get { return this.model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Model!");
                }
                this.model = value;
            }
        }
        public decimal HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (!decimal.TryParse(value.ToString(), out value))
                {
                    throw new ArgumentException("Invalid HoursIdle Value");
                }
                this.hoursIdle = value;
            }
        }
        public decimal HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (!decimal.TryParse(value.ToString(), out value))
                {
                    throw new ArgumentException("Invalid HoursTalk Value");
                }
                this.hoursTalk = value;
            }
        }

        //Constructors
        public Battery(string model)
        {
            this.model = model;
        }
        public Battery()
        {
        }
    }
}
