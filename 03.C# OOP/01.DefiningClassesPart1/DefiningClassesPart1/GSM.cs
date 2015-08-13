
namespace DefiningClassesPart1
{
    using System;
    using System.Collections.Generic;

    public class GSM
    {
        private string manufacturer;
        private double? price;
        private string model;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory; //Problem 9. Call history

        //Problem 6. Static field
        private static GSM iPhone4S = new GSM("iPhone4S", "Apple");
        public static GSM IPhone4S
        {
            get { return iPhone4S; }
        }


        //constructor with 2 mandatory parameters
        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.CallHistory = new List<Call>();
        }
        //constructor with all parameters - 2 mandatory, all other optional 
        public GSM(string model,
                   string manufacturer,
                   string owner = null,
                   double? price = null,
                   Battery battery = null,
                   Display display = null)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Owner = owner;
            this.Price = price;
            this.Battery = battery;
            this.Display = display;
            this.CallHistory = new List<Call>();
        }

        //Problem 5. Properties
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentOutOfRangeException("Manufacturer name should be > 0 symbols ");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }
        public double? Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Price should be > 0");
                }
                else
                {
                    this.price = value;
                }
            }
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
        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }
        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }
        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }

        //Problem 9. Call history
        public List<Call> CallHistory
        {
            get { return this.callHistory; }
            set { this.callHistory = value; }
        }

        //Problem 4. ToString
        public override string ToString()
        {
            return String.Format("Manufacturer: {0}\n" +
                                  "Model: {1}\n" +
                                  "Owner: {2}\n" +
                                  "Price: {3}\n" +
                                  "Battery: {4}\n" +
                                  "Display: {5}\n",
                this.Manufacturer, this.Model, this.Owner, this.Price, this.Battery, this.Display);
        }

        //Problem 10. Add/Delete calls
        //Add methods in the GSM class for adding and deleting calls from the calls history.
        public void AddCalls(Call call)
        {
            this.callHistory.Add(call);
        }
        public void DeleteCalls(Call call)
        {
            this.callHistory.Remove(call);
        }
        //Add a method to clear the call history.
        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        //Problem 11. Call price:Add a method that calculates the total price of the calls in the call history.
        //Assume the price per minute is fixed and is provided as a parameter.
        public decimal PriceOfCalls(decimal price)
        {
            decimal sum = 0;
            for (int i = 0; i < callHistory.Count; i++)
            {
                sum += callHistory[i].Duration * price / 60;
            }
            return sum;
        }
    }
}
