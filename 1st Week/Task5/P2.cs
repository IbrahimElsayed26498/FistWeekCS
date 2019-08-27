//In the name of Allah, the Gracious, the Merciful
using System;
public class P2
{
	public static void Main(string[] args)
	{
		int number1 = 0, sum = 0, counter = 0;
		do
		{
			// this condition will be true in the 3rd repetition
			if(counter++ == 2)
			{
				Console.WriteLine(sum);
				return;
			}

			Console.Write("Enter even number : ");
			number1 = Convert.ToInt32(Console.ReadLine());
			sum += number1;

		}while(number1 % 2 != 0); // if the first or the second number is even, it will be exit
		Console.WriteLine("Error");
	}
}