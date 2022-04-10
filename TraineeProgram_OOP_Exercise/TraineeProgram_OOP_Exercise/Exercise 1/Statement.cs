using System;

namespace TraineeProgram_OOP_Exercise
{
    public class Statement : Activation
    {
        public void Activate(string policyNumber, int statementNumber, double amount)
        {
            Console.WriteLine("I am statement activate in statement class");
        }
    }
}
