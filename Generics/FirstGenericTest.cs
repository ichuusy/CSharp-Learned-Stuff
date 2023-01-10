using System;
using System.Collections.Generic;

namespace GenericsType
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			var test = new Test<string>("Test","Project","Generics");
			test.Write();
		}
		
	}

	public class Test<T> where T : class
	{
		public List<T> Liste = new List<T>();

		public Test(params T[] data)
		{
			foreach (var obj in data)
			{
				Liste.Add(obj);
			}
		}

		public void Write()
		{
			foreach (var obj in Liste)
			{
				Console.WriteLine(obj);
			}
		}
	}
}
