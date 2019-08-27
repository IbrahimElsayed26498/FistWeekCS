using System;
public class P1
{
	public static void Main(string[] args)
	{
		//1
		int num1, num2;
		try
		{
			Console.Write("Number 1 : ");
			num1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Number 2 : ");
			num2 = Convert.ToInt32(Console.ReadLine());

			if(num1 > num2)
				Console.WriteLine("The biggest is : " + num1);
			else
				Console.WriteLine("The biggest is : " + num2);
		}
		catch(Exception e)
		{
			Console.WriteLine("You must enter a number");
		}
	}
}