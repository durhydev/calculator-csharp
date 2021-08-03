using System;

namespace project{
	class hello_world{
		static void Main(string[] args){
		        int a, b;
		        int option, result;
			
			Console.Write("Type the first number: ");
			a = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Type the second number: ");
			b = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("=========================");
			Console.WriteLine("       Calculator        ");
			Console.WriteLine("=========================");
			
			Console.WriteLine("1 - Sum");
			Console.WriteLine("2 - Subtraction");
			Console.WriteLine("3 - Multiplication");
			Console.WriteLine("4 - Division");
			
			Console.WriteLine("=========================");
			
			Console.Write("Type a option: ");
			option = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("=========================");
			
			switch(option){
				case 1:
				    result = a + b;
				    Console.WriteLine(a + " + " + b + " = " + result);
				    break;
				
				case 2:
				    result = a - b;
				    Console.WriteLine(a + " - " + b + " = " + result);
				    break;
				
				case 3:
				    result = a * b;
				    Console.WriteLine(a + " x " + b + " = " + result);
				    break;
				
				case 4:
				    result = a / b;
				    Console.WriteLine(a + " / " + b + " = " + result);
				    break;
				
				default:
				     Console.WriteLine("Option invalid. Try again.");
				     break;
			}
		}
	}
}
