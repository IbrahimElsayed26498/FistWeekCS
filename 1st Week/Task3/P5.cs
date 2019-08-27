using System;
public class P5
{
	public static void Main(string[] args)
	{
		//5
		try
		{
			string condition;
			do
			{
				Console.Write("Enter a number : ");
				long num = Convert.ToInt64(Console.ReadLine());
				long fact = 1;
				for(int i=1; i<=num; i++)
				{
					fact *= i;
				}
				Console.WriteLine(fact);
				Console.Write("Do you want to continue ? ");
				condition = Console.ReadLine();
			}while(condition == "yes");
		}
		catch(Exception e)
		{
			Console.WriteLine("You must enter a number.");
		}

	}
}