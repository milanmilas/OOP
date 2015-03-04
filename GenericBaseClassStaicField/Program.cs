using System;

namespace GenericBaseClassStaicField
{
	class Program
	{
		static void Main(string[] args)
		{
			var testA1 = new A();
			A.Id = 1;

			var testB1 = new B();
			B.Id = 2;

			Console.WriteLine("A: {0} , B: {1}", A.Id, B.Id);

			Console.ReadKey();
		}
	}
}