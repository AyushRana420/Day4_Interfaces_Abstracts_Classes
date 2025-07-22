using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interfaces_Abstracts_Classes
{
    abstract class Payment // An Absact Class is a class that cannot create an instance of itself and it should jave atleast one abstract method
    {
        //defibing class members like properties and methods , especially one abstract methods
        public string PaymentId { get; set; }

        // Abstract method that must be implemented by derived classes
        public abstract void MakePayment(decimal amount);

        public void GenerateReceipt()
        {
            // This is a concrete method that can be used by derived classes
            Console.WriteLine($"Receipt generated for payment ID: {PaymentId}");
        }
    }
}
