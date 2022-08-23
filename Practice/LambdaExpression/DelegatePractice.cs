using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.LambdaExpression
{
    public  class DelegatePractice
    {
		public delegate int NumberChanger(int n);
		 int num = 10;

		public  int AddNum(int p)
		{
			num += p;
			return num;
		}
		public  int MultNum(int q)
		{
			num *= q;
			return num;
		}
		public  int getNum()
		{
			return num;
		}

		public void Print()
		{
			NumberChanger nc1 = AddNum;// new NumberChanger(AddNum);
			NumberChanger nc2 = new NumberChanger(MultNum);
			NumberChanger nc = nc1 + nc2;
            //Console.WriteLine(nc1(10));
            //Console.WriteLine(nc2(5));
            // Console.WriteLine(nc(10));

            NumberChanger squareValue = (int num) => (num*num);			// using lambda expression 
            Console.WriteLine(squareValue(10));
		}
	}
}
