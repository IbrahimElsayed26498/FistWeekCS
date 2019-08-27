// In the name of Allah, the Gracious, the Merciful
using System;
using System.Collections.Generic;
public class P6
{
	public static void Main(string[] args)
	{
		List<int> list = new List<int>();
		Console.WriteLine("Enter 5 number :");
		
		// storing data in the list
		for(int i=0; i<5; i++)
		{
			list.Add(Convert.ToInt32(Console.ReadLine()));
		}

		//sorting the list elements
		list.Sort();

		Console.WriteLine();

		//printing the list after sorting
		foreach(int n in list)
			Console.WriteLine(n);

	}


}