using System;

namespace TraineeProgram_OOP_Exercise
{
    public class Policy : Activation
    {
        public override void Activate(string policyNumber)
        {
            Console.WriteLine("I am policy activate in policy class");
        }
    }
}
