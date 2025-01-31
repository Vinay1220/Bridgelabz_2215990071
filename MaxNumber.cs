using System;

	class MaxNumber{
		
		
		static void maxNumber(int a, int b, int c){
			if(a>b && a>c){
				Console.WriteLine("Your first number is maximum: "+a);
			}else if(b>a && b>c){
				Console.WriteLine("Your second number is maximum: "+b);
			}else{
				Console.WriteLine("Your third number is maximum: "+c);
			}
		}
		
		static void Main(String[] args){
			
			Console.WriteLine("Enter First number");
			int a = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Enter second number");
			int b = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Enter third number");
			int c = int.Parse(Console.ReadLine());

			MaxNumber.maxNumber(a,b,c);
		}
	}