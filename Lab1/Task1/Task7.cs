using System;
using System.Collections.Generic;
class Task7
{
	public static void Main(string[] args)
	{
		int studentsNumber, subjectsNumbers;
		List<Student> list = new List<Student>();
		Console.Write("Enter students' number : ");
		studentsNumber = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter subjects' number : ");
		subjectsNumbers = Convert.ToInt32(Console.ReadLine());

		//adding the numebr of subjects
		Student.subjectNumber = studentsNumber;

		Student s;
		//adding the data of every student
		for(int i=0; i<studentsNumber; i++)
		{
			Console.WriteLine("\n\nStudent number " + (i+1));
			s = new Student();
			Console.Write("Name : ");
			s.setName(Console.ReadLine());
			Console.Write("Age : ");
			s.setAge(Convert.ToInt32(Console.ReadLine()));
			for(int j=0; j<subjectsNumbers; j++)
			{
				Console.Write("Subject number " + (j + 1) + " : ");
				s.addSubjectDegree(Convert.ToInt32(Console.ReadLine()));
			}
			list.Add(s);
		}

		Console.WriteLine("\n\n\n----------------------------");
		Console.WriteLine("Name\tAge\tPercentage");
		Console.WriteLine("----------------------------");
		foreach(Student s1 in list)
		{
			s1.toString();
		}

		
	}
}