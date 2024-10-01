using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSomeDesignPattern
{
    public interface IOrderFactory
    {
        IOrder CreateOrder();
        IPayment CreatePayment();
        IShipping CreateShipping();
    }

    public interface IOrder
    {
        void ProcessOrder();
    }
    public interface IPayment
    {
        void ProcessPayment();
    }
    public interface IShipping
    {
        void ShipOrder();
    }

    public class DomesticOrderFactory : IOrderFactory
    {
        public IOrder CreateOrder()
        {
            return new DomesticOrder();
        }

        public IPayment CreatePayment()
        {
            return new DomesticPayment();
        }

        public IShipping CreateShipping()
        {
            return new DomesticShipping();
        }
    }

    public class InternationalOrderFactory : IOrderFactory
    {
        public IOrder CreateOrder()
        {
            return new InternationalOrder();
        }

        public IPayment CreatePayment()
        {
            return new InternationalPayment();
        }

        public IShipping CreateShipping()
        {
            return new InternationalShipping();
        }
    }

    public class DomesticOrder : IOrder
    {
        public void ProcessOrder()
        {
            Console.WriteLine("Processing Domestic Order..........");
        }
    }

    public class InternationalOrder : IOrder
    {
        public void ProcessOrder()
        {
            Console.WriteLine("Processing International Order..........");
        }
    }

    public class DomesticPayment : IPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing Domestic Payment..........");
        }
    }

    public class InternationalPayment : IPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing International Payment..........");
        }
    }

    public class DomesticShipping : IShipping
    {
        public void ShipOrder()
        {
            Console.WriteLine("Shipping Domestic Order..........");
        }
    }

    public class InternationalShipping : IShipping
    {
        public void ShipOrder()
        {
            Console.WriteLine("Shipping International Order..........");
        }
    }
}
