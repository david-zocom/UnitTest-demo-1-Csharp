using ConsoleApp34;
using System;
using Xunit;

namespace XUnitTestProject1
{
	public class ProgramTest
	{
		// till�tna v�rden: objekt av klassen Product
		// otill�tna v�rden: null

		[Fact]
		public void ShouldThrowOnNull()
		{
			Product input = null;
			Assert.Throws<Exception>(() =>
			{
				Program.SellProduct(input);
			});
		}

		[Fact]
		public void ShouldDecreaseForValidProduct()
		{
			// Arrange, act, assert
			Product p = CreateProduct(1);
			int expected = 0;
			Program.SellProduct(p);
			int actual = p.Count;
			Assert.Equal(expected, actual);
		}
		private Product CreateProduct(int count)
		{
			return new Product()
			{
				Name = "Hello Kitty umbrella",
				Price = 123m,
				Count = count
			};
		}
		[Fact]
		public void ShouldThrowWhenNoProductsLeft()
		{
			// Arrange, act, assert
			Product p = CreateProduct(0);
			Assert.Throws<Exception>(() =>
			{
				Program.SellProduct(p);
			});
		}
		// exception om det inte finns n�gra kvar
		// m.m.?
	}
}
