using System;

namespace project{
	class calculator{
		static void Main(string[] args){
			byte a, b;
			byte sum;
			
			Console.Write("Type a number: ");
			a = Convert.ToByte(Console.ReadLine());
			
			Console.Write("Type other number: ");
			b = Convert.ToByte(Console.ReadLine());
			
			sum = Convert.ToByte(a + b);
			
			Console.WriteLine(a + " + " + b + " = " + sum);
		}
	}
}
