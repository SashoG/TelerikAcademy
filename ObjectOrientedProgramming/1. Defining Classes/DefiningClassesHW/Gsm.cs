using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesHW
{
    public class Gsm
    {
        private const decimal CallPricePerMinute = 0.37m;

        public Gsm(string model, string manufacturer, decimal price = 0, string owner = null,
            Battery battery = null, Display display = null)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }
        
        private string model;

        private string manufacturer;

        private decimal price;

        private string owner;
        
        private Battery battery;

        private Display display;

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.model = value;                
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.manufacturer = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentNullException();
                }
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.owner = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        public static readonly Gsm IPhone4S = new Gsm("iPhone4S","Apple",1000000,"someone",new Battery(), new Display());

        public List<Call> CallHistory { get; set; }
        
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(String.Format("Model:{0}", Model));
            sb.AppendLine();
            sb.Append(String.Format("Manufacturer:{0}", Manufacturer));
            sb.AppendLine();
            sb.Append(String.Format("Price:{0}", Price));
            sb.AppendLine();
            sb.Append(String.Format("Owner:{0}", Owner));
            sb.AppendLine();
            sb.Append(String.Format("Battery:{0}", Battery.ToString()));
            sb.AppendLine();
            sb.Append(String.Format("Display:{0}", Display.ToString()));

            return sb.ToString();
        }

        public void AddCallToHistory(Call call)
        {
            this.CallHistory.Add(call);
        }

        public void RemoveCallFromHistory(Call call)
        {
            this.CallHistory.Remove(call);
        }

        public void ClearHistory()
        {
            this.CallHistory.Clear();
        }

        public decimal CalcTotalPriceCalls()
        {
            TimeSpan totalDuration = new TimeSpan();
            foreach (var call in this.CallHistory)
            {
                totalDuration.Add(call.Duration);
            }
            return totalDuration.Minutes * CallPricePerMinute;
        }
    }
}