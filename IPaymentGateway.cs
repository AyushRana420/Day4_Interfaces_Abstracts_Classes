using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interfaces_Abstracts_Classes
{
    internal interface IPaymentGateway
    {
        //here we will declare the methods that will be implemented in the derived classes
        void Pay(decimal amount);
        void Refund(decimal amount);

        // In case of interface all methods are abstract by default, meaning they do not have a body.
        //Interfaces cannot have fields or properties with implementation, only method signatures.
        //We can create references to an interface type, but we cannot instantiate an interface directly.
        //
    }

    //Defining a class that implements the IPaymentGateway interface
    public class PayPalGateway : IPaymentGateway // Here we are implementing the IPaymentGateway interface
    {
        // Implementing the pay method from the IPaymentGateway interface
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount}");
        }
        // Implementing the refund method from the IPaymentGateway interface
        public void Refund(decimal amount)
        {
            Console.WriteLine($"Processing PayPal refund of {amount}");
        }
    }
}
