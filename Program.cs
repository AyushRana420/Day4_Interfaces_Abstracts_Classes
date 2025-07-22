using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interfaces_Abstracts_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting started with Abstract class and Interfaces");
            Console.WriteLine("--------------------------------------------------");
            //makesound class which with predeined methods which can we derived in child classes
            //Step 1: Create an abstract class
            //Step 2: Create an interface
            //Step 3: Implement the abstract class and interface in a derived class (Why? Because abstract classes cannot be instantiated directly)
            //Step 4: Create an instance of the derived class and call the methods

            //

            Console.WriteLine("Here is an Abastract class Demo...");
            // Creating an instance of the creditCardPayment class which is derived from the Payment abstract class
            Payment payment = new creditCardPayment();
            payment.MakePayment(100.00m); // Calling the MakePayment method
            payment.GenerateReceipt(); // Calling the GenerateReceipt method

            Console.WriteLine("Here is an Interface Demo...");
            IPaymentGateway paymentGateway = new PayPalGateway(); // Creating an instance of the PayPalGateway class which implements the IPaymentGateway interface
            paymentGateway.Pay(50.00m); // Calling the Pay method
            paymentGateway.Refund(20.00m); // Calling the Refund method
            Console.WriteLine("----------------------------------------------------");
        }
    }

    class creditCardPayment : Payment // Classes are derived from the Payment abstract class
    {
        // Implementing the abstract method from the Payment class
        public override void MakePayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount}");
            PaymentId = Guid.NewGuid().ToString(); // Generating a unique payment ID
        }
    }
}
