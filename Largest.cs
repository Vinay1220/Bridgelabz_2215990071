using System;

class Largest
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers:");
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());
		if(number1 > number2 && number1 > number3){
			Console.WriteLine("Is the first number the largest? Yes");
			Console.WriteLine("Is the second number the largest? No");
			Console.WriteLine("Is the third number the largest? No");
		}else if(number2 > number1 && number2 > number3){
			Console.WriteLine("Is the first number the largest? No");
			Console.WriteLine("Is the second number the largest? Yes");
			Console.WriteLine("Is the third number the largest? No");
		}else{
			Console.WriteLine("Is the first number the largest? No");
			Console.WriteLine("Is the second number the largest? No");
			Console.WriteLine("Is the third number the largest? yes");
		}

    }
}
