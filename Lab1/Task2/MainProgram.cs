using System;
class MainClass
{
	public static void Main(string[] args)
	{
		Operations operation = new Operations();
		Console.Write("Numebr 1 : ");
		operation.setNum1(Convert.ToInt32(Console.ReadLine()));
		Console.Write("Numebr 2 : ");
		operation.setNum2(Convert.ToInt32(Console.ReadLine()));
		Console.Write("Operation : ");
		operation.setOp(Console.ReadLine()[0]);

		operation.checkOperator();

	}
}