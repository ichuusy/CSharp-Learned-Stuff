using System;

namespace Singleton
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			ItemManager item = ItemManager.NesneVer();
			ItemManager item1 = ItemManager.NesneVer();
			if (item == item1)
			{
				Console.WriteLine("Item1 and Item2 is equal.");
			}
		}
	}

	public class ItemManager
	{
		public static ItemManager Instance;

		private ItemManager()
		{
		}

		public static ItemManager NesneVer()
		{
			if (Instance==null)
			{
				Instance = new ItemManager();
			}

			return Instance;
		}
	}
}
