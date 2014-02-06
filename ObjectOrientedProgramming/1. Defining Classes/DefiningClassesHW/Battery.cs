using System;
using System.Text;

namespace DefiningClassesHW
{
    public class Battery
    {
        private string model;

        private int hoursIdle;

        private int hoursTalk;

        private BatteryType batteryType;

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.hoursIdle = value;
            }
        }

        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.hoursTalk = value;
            }
        }

        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                try 
                {
                    var checkIsValueInEnumeration = (BatteryType)Enum.Parse(typeof(BatteryType), value.ToString());
                }
                catch (ArgumentNullException)
                {
                    throw new ArgumentNullException();
                }
                catch (ArgumentException)
                {
                    throw new ArgumentException();
                }
                this.batteryType = value;
            }
        }

        public Battery(string model=null, int hoursIdle=0, int hoursTalk=0, BatteryType batteryType=BatteryType.Unknown)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(String.Format("BatteryModel:{0}", Model));
            sb.AppendLine();
            sb.Append(String.Format("HoursIdle:{0}", HoursIdle));
            sb.AppendLine();
            sb.Append(String.Format("HoursTalk:{0}", HoursTalk));
            sb.AppendLine();
            sb.Append(String.Format("BatteryType:{0}", BatteryType.ToString()));
            
            return sb.ToString();
        }
    }
}