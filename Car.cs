using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSomeDesignPattern
{
    public abstract class Car
    {
        protected int basePrice = 0, onRoadPrice = 0;
        public string ModelName { get; set; }
        public int BasePrice { get => basePrice; set => basePrice = value; }
        public int OnRoadPrice { get => onRoadPrice; set => onRoadPrice = value; }
        public static int SetAdditionalPrice()
        {
            Random random = new Random();
            int additionalPrice = random.Next(200_000, 500_000);
            return additionalPrice;
        }
        public abstract Car Clone();
    }

    public class Mustang : Car
    {
        public Mustang(string model) => (ModelName, BasePrice) = (model, 200_000);
        public override Car Clone() => this.MemberwiseClone() as Mustang;
    }

    public class Bentley : Car
    {
        public Bentley(string model) => (ModelName, BasePrice) = (model, 300_000);
        public override Car Clone() => this.MemberwiseClone() as Bentley;
    }
}
