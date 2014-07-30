using System;
using System.Linq;

public class IntOrArray
{
	public bool IsInt { private set; get; }

	public int IValue { private set; get; }

	public IntOrArray[] AValue { private set; get; }

	public IntOrArray(int i)
	{
		IsInt = true;
		IValue = i;
	}

	public IntOrArray(IntOrArray[] a)
	{
		IsInt = false;
		AValue = a;
	}
}

public class SumAllKlass
{
	public static void Main()
	{
		var l = Construct();
		var total = SumAll(l);

		Console.WriteLine(total);
	}

	public static IntOrArray Construct()
	{
		var innerestTwo = new IntOrArray(2);
		var innerestThree = new IntOrArray(3);
		var innerestArray = new IntOrArray(new IntOrArray[] { innerestTwo, innerestThree });

		var innerOne = new IntOrArray(1);
		var innerArray = new IntOrArray(new IntOrArray[] { innerOne, innerestArray });

		var outterOne = new IntOrArray(1);
		var outterTwo = new IntOrArray(2);
		var outterThree = new IntOrArray(3);

		return new IntOrArray(new IntOrArray[] { outterOne, outterTwo, outterThree, innerArray });
	}

	public static int SumAll(IntOrArray l)
	{
		if (l.IsInt)
		{
			return l.IValue;
		}
		else 
		{
			int tempTotal = 0;
			foreach(var item in l.AValue)
			{
				tempTotal += SumAll(item);
			}
			return tempTotal;
		}
	}
}