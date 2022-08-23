using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.LambdaExpression
{
    public  class MathOperation
    {
        //The last parameter type in a Func delegate is the return type and rest are input parameters.
        public Func<int, int> square = x => x * x;

        public Func<string,int>  getStringLength = x => x.Length;

        public Func<int,string> getStringValue = x => x.ToString();



    }
}
