using System;
using System.Collections.Generic;
class Student
{
	string name;
	int age;
	public static int subjectNumber;
	List<int> subjectDegrees;
	double percentage;

	public Student()
	{
		subjectDegrees = new List<int>();
	}

	//setter
	public void setName(string name)
	{
		this.name = name;
	}
	public void setAge(int age)
	{
		this.age = age;
	}
	

	//getter
	public string getName()
	{
		return this.name;
	}
	public int getAge()
	{
		return this.age;
	}
	public int getSubjectNumber()
	{
		return subjectNumber;
	}

	public double calculatePercentage()
	{
		double degrees = 0.0;
		foreach(int degree in subjectDegrees)
		{
			degrees += degree;
		}
		double tatalDegree = 50.0*subjectDegrees.Count;
		percentage = (degrees/tatalDegree) * 100;
		return percentage;
	}

	//adding student's subject degree to list
	public void addSubjectDegree(int degree)
	{
		subjectDegrees.Add(degree);
	}

	public void toString()
	{
		Console.WriteLine("{0}\t{1}\t{2}", getName(), getAge(), calculatePercentage());
	}
}