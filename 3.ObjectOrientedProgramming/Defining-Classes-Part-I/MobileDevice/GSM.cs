using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    class GSM
    {
        public const decimal callPricePerMinute = 0.37m;

        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private static GSM iPhone4S = new GSM("IPhone4S", "Apple");
        private List<Call> callHistory = new List<Call>();

        //Constructors 
        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }
        public GSM(string model, string manufacturer, decimal? price)
            : this(model, manufacturer)
        {
            this.price = price;
        }
        public GSM(string model, string manufacturer, decimal? price, string owner)
            : this(model, manufacturer, price)
        {
            this.owner = owner;
        }
        public GSM()
        {

        }

        //
        //Properties

        public string Model
        {
            get { return this.model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Model");
                }
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Manufacturer");
                }
                this.manufacturer = value;
            }
        }
        public decimal? Price
        {
            get { return this.price; }
            set
            { this.price = value; }
        }
        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Owner");
                }
                this.owner = value;
            }
        }
        public static GSM IPhone4S
        {
            get { return iPhone4S; }
            set { iPhone4S = value; }
        }
        //Instances
        Display display = new Display();
        Battery battery = new Battery();

        //Method to override ToString()
        public override string ToString()
        {
            return String.Format("Model: {0}\nManufacturer: {1}\nOwner: {2}\nPrice: {3}", this.Model, this.Manufacturer, this.Owner, this.Price);
        }

        //Call History list with the performed calls

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
            set { this.callHistory = value; }
        }
        
        //Adding a call to the History
        public List<Call> AddCall(List<Call> CallHistory, Call currentCall)
        {
            CallHistory.Add(currentCall);
            return CallHistory;
        }

        //Removing a call from the History
        public List<Call> RemoveCall(List<Call> CallHistory, Call currentCall)
        {
            CallHistory.Remove(currentCall);
            return CallHistory;
        }
        //Clear call History
        public List<Call> ClearCallHistory(List<Call> CallHistory)
        {
            CallHistory.Clear();
            return CallHistory;
        }

        //Calculate price of the call in call History
        public decimal TotalPriceOfCalls(List<Call> callHistory)
        {
            decimal totalPriceOfCalls = 0m;
            foreach (var callItem in callHistory)
            {
                totalPriceOfCalls += callItem.Duration.Minutes * callPricePerMinute;
            }
            return totalPriceOfCalls;
        }
    }
}
