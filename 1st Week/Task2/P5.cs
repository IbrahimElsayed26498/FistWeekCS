using System;
public class P5
{
	public static void Main(string[] args)
	{
		

		//5
		string name;
		int age;

		Console.Write("Enter yout name : ");
		name = Console.ReadLine();

		Console.Write("Enter your age : ");
		age = Convert.ToInt32(Console.ReadLine());

		Console.Write("Hello, you are ");
		if(age>0 && age<=10)
			Console.WriteLine("baby");
		else if(age >10 && age<=20)
			Console.WriteLine("teenager");
		else if(age >20 && age<=40)
			Console.WriteLine("young");
		else
			Console.WriteLine("old");

	}
}