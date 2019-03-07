using System;

namespace Hello_World {
	
	class Program {
		
		public static void Main(string[] args) {
						
			int num1;
			int num2;
			string inputStorage1;
			string inputStorage2;
			
			inputStorage1 = Console.ReadLine();
			inputStorage2 = Console.ReadLine();
			
			num1 = int.Parse(inputStorage1);
			num2 = int.Parse(inputStorage2);
			
			int output = num1 + num2;
			
			Console.WriteLine(output);
			Console.ReadKey(true);
		}
	}
}