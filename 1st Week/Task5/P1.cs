//In the name of Allah, the Gracious, the Merciful
using System;
public class P1
{
	public static void Main(string[] args)
	{
		string condition;
		int num1, num2;
		char op = ' '; // operation

		for(;;)
		{
			Console.Write("Number 1 : ");
			num1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Number 2 : ");
			num2 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Operation : ");
			
			op = Console.ReadLine()[0];
			
			Console.Write("{0} {1} {2} = ", num1, op, num2);
			if(op == '+')
				Console.WriteLine(num1 + num2);
			else if(op == '-')
				Console.WriteLine(num1 - num2);
			else if(op == '*')
				Console.WriteLine(num1 * num2);
			else if(op == '/')
				Console.WriteLine(num1 / num2);
			else if(op == '%')
				Console.WriteLine(num1 % num2);
			else
				Console.WriteLine("Wrong operation");

			Console.Write("Do you want to continue (yes or no) ? ");
			condition = Console.ReadLine();
			if(condition == "no")
				break;
		}
	}
}