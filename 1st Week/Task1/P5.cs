using System;
class P5
{
	public static void Main(string [] args)
	{
		//5
		int num1, num2;
		double restult = 0.0;
		Console.WriteLine("Enter 2 numbers");
		
		Console.Write("Number 1 : ");
		num1 = Convert.ToInt32(Console.ReadLine());

		Console.Write("Number 2 : ");
		num2 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 + num2));
		Console.WriteLine("{0} - {1} = {2}", num1, num2, (num1 - num2));
	}
}