using Practice.LambdaExpression;
using Practice.StringConversion;
using Practice.Collection;
using System;
namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MathOperation mathOperation = new MathOperation();
            //Console.WriteLine("Value = "+mathOperation.square(5));
            //Console.WriteLine("Length = "+mathOperation.getStringLength("nadim ahmed"));
            //Console.WriteLine("StringValue = "+mathOperation.getStringValue(1000).GetType());

            //StringSplitter s = new StringSplitter();
            //s.SplitString();

            //Dictionary d = new Dictionary();
            //d.PrintDictionary();

            AnonymousMethod anonymousMethod = new AnonymousMethod();
            anonymousMethod.Show();

            //DelegatePractice delegatePractice = new DelegatePractice();
            //delegatePractice.Print();

            //DelegatePractice.NumberChanger nc = delegatePractice.AddNum;
            //Console.WriteLine(nc(99999));
        }
    }
}
