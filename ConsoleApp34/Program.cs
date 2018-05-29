using System;

namespace ConsoleApp34
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}

		public static void SellProduct(Product product)
		{
			// vänta! skriv test först!
			if (product == null)
				throw new Exception("Product cannot be null!");
			if (product.Count < 1)
				throw new Exception("No products to sell");
			product.Count--;
		}
	}
	// sellProduct
}
