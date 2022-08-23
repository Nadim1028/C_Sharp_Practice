using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practice.LambdaExpression
{

	public class AnonymousMethod
	{
		delegate bool IsTeenAger(Student stud);
		public delegate void Print(int value);
		public  void Show()
		{
			//IsTeenAger isTeenAger = delegate (Student s) { return s.Age > 12 && s.Age < 20; };
			//Student stud = new Student() { Age = 25 };
			//Console.WriteLine(isTeenAger(stud));

			int i = 100;
			//Print prnt = delegate (int val) {
			//	val += i;
			//	Console.WriteLine("Anonymous method: {0}", val);
			//};

			Print prnt = val => { // using lambda expression
                val += i;
                Console.WriteLine("Anonymous method: {0}", val);
            };

			prnt(100);

		}
	}

	public class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
	}
}
