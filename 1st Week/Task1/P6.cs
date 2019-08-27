using System;
class P6
{
	public static void Main(string [] args)
	{
		//6
		try
		{
			if(num2 == 0)
				throw new DivideByZeroException();
			restult = (double)num1 / (double)num2;
			Console.WriteLine("{0} / {1} = {2}", num1, num2, restult);
		}
		catch(DivideByZeroException e)
		{
			Console.WriteLine("You can not divide by zero");
		}
	}
}