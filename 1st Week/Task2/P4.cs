using System;
public class P4
{
	public static void Main(string[] args)
	{
		
		//soloution of problem 3

		/*
		the output is : 
		8
		8
		9
		10
		10
		11
		10
		*/

		//4
		double num1, num2;
		char op;
		try
		{
			Console.Write("Number 1 : ");
			num1 = Convert.ToDouble(Console.ReadLine());

			Console.Write("Number 2 : ");
			num2 = Convert.ToDouble(Console.ReadLine());

			Console.Write("Operator");
			op = Console.ReadLine();
			
			Console.Write("{} {} {} = ", num1, op, num2);
			switch(op)
			{
				case '+' : Console.WriteLine(num1 + num2); break;
				case '-' :  break;
				case '*' : Console.WriteLine(num1 * num2); break;
				case '/' : if(num2 == 0) throw new DivideByZeroException(); 
						   Console.WriteLine(num1 / num2); break;
				case '%' : if(num2 == 0) throw new DivideByZeroException(); 
						   Console.WriteLine(num1 % num2); break;
				default : Console.WriteLine("Wrong operator");
			}
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