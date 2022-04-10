using System;

namespace TraineeProgram_OOP_Exercise
{
    public class Activation
    {
        public virtual void Activate(string policyNumber)
        {
            Console.WriteLine("I am policy activate in base class");
        }

        public virtual void Activate(string policyNumber, string agreementNumber)
        {
            Console.WriteLine("I am agreement activate in base class");
        }

        public void Activate(string policyNumber, int statementNumber, int amount)
        {
            Console.WriteLine("I am statement activate in base class");
        }

    }
}
