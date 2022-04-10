using System;

namespace TraineeProgram_OOP_Exercise
{
    public class Agreement : Activation
    {
        public override void Activate(string policyNumber, string agreementNumber)
        {
            Console.WriteLine("I am agreement activate in agreement class");
        }
    }
}
