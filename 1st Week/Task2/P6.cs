using System;
public class P6
{
	public static void Main(string[] args)
	{
		
		//6
		string name;
		double degree, sub1, sub2, sub3;

		Console.Write("Enter your name : ");
		name = Console.ReadLine();

		Console.WriteLine("Enter your degree.");
		Console.Write("Subject 1 : ");
		sub1 = Convert.ToDouble(Console.ReadLine());
		Console.Write("Subject 2 : ");
		sub2 = Convert.ToDouble(Console.ReadLine());
		Console.Write("Subject 3 : ");
		sub3 = Convert.ToDouble(Console.ReadLine());

		degree = (sub1 + sub2 + sub3) / 3.0;

		if(degree>=60 && degree<65)
			Console.WriteLine("Satisfy");
		else if(degree>=65 && degree< 75)
			Console.WriteLine("Good");
		else if(degree>=75 && degree<85)
			Console.WriteLine("Very good"); 
		else
			Console.WriteLine("Excellent");
	}
}