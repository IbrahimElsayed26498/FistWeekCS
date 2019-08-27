using System;
public class P2
{
	public static void Main(string[] args)
	{
		//2
		double num1, num2;
		try
		{
			Console.Write("Number 1 : ");
			num1 = Convert.ToDouble(Console.ReadLine());

			Console.Write("Number 2 : ");
			num2 = Convert.ToDouble(Console.ReadLine());
			if(num2 == 0)
				throw new DivideByZeroException();

			Console.WriteLine("{0} / {1} = {2}", num1, num2, (num1/num2));

		}
		catch(DivideByZeroException e)
		{
			Console.WriteLine("You can not divide by zero");	
		}
		catch(Exception e)
		{
			Console.WriteLine("You must enter a number");
		}
	}
}