using System;

namespace Hello_World {
	
	class Program {
		
		public static void Main(string[] args) {
						
			int num1;
			int num2;
			string inputStorage1;
			string inputStorage2;
		
			System.Console.WriteLine("Calculator for 2 numbers being added!");
			System.Console.WriteLine("");
			System.Console.WriteLine("Enter first number");
			inputStorage1 = Console.ReadLine();
			System.Console.WriteLine("Enter seccond number");
			inputStorage2 = Console.ReadLine();

			num1 = int.Parse(inputStorage1);
			num2 = int.Parse(inputStorage2);
			
			int output = num1 + num2;
			
			System.Console.WriteLine("Thanks! the answer is...");
			System.Console.WriteLine(num1);
			System.Console.WriteLine("+");
			System.Console.WriteLine(num2);
			System.Console.WriteLine("=");
			System.Console.WriteLine(output);
			Console.ReadKey(true);
		}
	}
}