using System;
class Operations
{
    double num1, num2;
	char op;

	//setter
	public void setNum1(double num1)
	{
		this.num1 = num1;
	}
	public void setNum2(double num2)
	{
		this.num2 = num2;
	}
	public void setOp(char op)
	{
		this.op = op;
	}

	//getter
	public double getNum1()
	{
		return this.num1;
	}
	public double getNum2()
	{
		return this.num2;
	}
	public char getOp()
	{
		return this.op;
	}

	// operations
	public double sum()
	{
		return num1 + num2;
	}
	public double sub()
	{
		return num1 - num2;
	}
	public double multiply()
	{
		return num1 * num2;
	}
	public double divide()
	{
		return num1 / num2;
	}
	public double modulas()
	{
		return num1 % num2;
	}

	public void checkOperator()
	{
		switch(op)
		{
			case '+' : Console.WriteLine("Sum = " + sum());	break;
			case '-' : Console.WriteLine("Sub = " + sub());	break;
			case '*' : Console.WriteLine("Multiply = " + multiply());	break;
			case '/' : Console.WriteLine("Divide = " + divide());	break;
			case '%' : Console.WriteLine("Modulas = " + modulas());	break;
			default : Console.WriteLine("Wrong Operation"); break;
		}
	}
}