using System;
public class P3
{
	public static void Main(string[] args)
	{
		//3
		Console.Write("Enter a number : ");
		int num = Convert.ToInt32(Console.ReadLine());
		int n =1;
		do
		{
			Console.WriteLine(num * n++);
		}
		while(n <= 10);

	}
}