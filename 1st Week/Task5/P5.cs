// In the name of Allah, the Gracious, the Merciful
using System;
using System.Collections.Generic;
public class P5
{
	public static void Main(string[] args)
	{
		int size = 0;
		List<int> list = new List<int>();
		List<int> list2 = new List<int>();

		Console.Write("Enter a number : ");
		size = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter {0} number(s) :", size);
		
		// storing data in the list
		for(int i=0; i<size; i++)
		{
			list.Add(Convert.ToInt32(Console.ReadLine()));
		}

		Console.WriteLine("\n\n");
		//printing the data
		foreach(int n in list)
		{
			Console.WriteLine(n);
		}

		Console.WriteLine();

		// adding 100 to every element at the array
		foreach(int n in list)
		{
			list2.Add(n + 100);
		}

		//printing the data
		foreach(int n in list2)
		{
			Console.WriteLine(n);
		}

	}


}