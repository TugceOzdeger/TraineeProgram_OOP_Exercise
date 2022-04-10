using System;

namespace TraineeProgram_OOP_Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("***** Object-Oriented Programming Concepts *****");
            Console.WriteLine("***** Polymorphism by method overriding, method overloading and " +
                              "parametric polymorphism and Inheritance *****");
            Activation policy = new Policy();
            policy.Activate("LP01");
            Activation agreement = new Agreement();
            agreement.Activate("LP01", "LA01");
            Activation claim = new Statement();
            claim.Activate("LP01", 98765, 123456);

            Console.WriteLine("***** Abstraction and Encapsulation *****");
            Risk r = new Risk(10, 20);
            Console.WriteLine(r.Calculate());
            Tax t = new Tax(10, 20, new Country {CountryCode = CountryEnum.Sweden});
            Console.WriteLine(t.Calculate());
            Console.ReadLine();
        }
    }
}
