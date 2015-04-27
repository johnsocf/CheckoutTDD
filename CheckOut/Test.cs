using NUnit.Framework;
using System;

namespace CheckOut
{
	[TestFixture ()]
	public class Test
	{
		private Checkout _checkout;
		private Product _productA;
		private Product _productB;
		private Product _productC;
		private Product _productD;

		[SetUp]
		public void Setup()
		{
			_checkout = new Checkout();
			_productA = new Product { Name = "A", Price = 50 };
			_productB = new Product { Name = "B", Price = 30 };
			_productC = new Product { Name = "C", Price = 20 };
			_productD = new Product { Name = "D", Price = 15 };
		}

		[Test ()]
		public void TestCase ()
		{
			var total = _checkout.getTotal ();
			Assert.That(total, Is.EqualTo(0));
		}
		[Test ()]
		public void Should_return_50_for_product_A  ()
		{
			_checkout.addProduct(_productA);
			_checkout.getTotal();
			Assert.That (_checkout.getTotal(), Is.EqualTo(50));
		}
		[Test ()]
		public void Should_return_120_for_product_A_and_B ()
		{
			_checkout.addProduct(_productA);
			_checkout.addProduct(_productB);
			_checkout.getTotal();
			Assert.That (_checkout.getTotal(), Is.EqualTo(80));
		}
		[Test ()]
		public void Should_return_130_for_3_A_Products ()
		{
			_checkout.addProduct(_productA);
			_checkout.addProduct(_productA);
			_checkout.addProduct(_productA);
			var total = _checkout.getTotal();
			var totalAfterDiscounts = _checkout.ApplyDiscounts(total);
			Assert.That (totalAfterDiscounts, Is.EqualTo(130));
		}

		[Test ()]
		public void Should_return_180_for_4_A_Products ()
		{
			_checkout.addProduct(_productA);
			_checkout.addProduct(_productA);
			_checkout.addProduct(_productA);
			_checkout.addProduct(_productA);
			var total = _checkout.getTotal();
			var totalAfterDiscounts = _checkout.ApplyDiscounts(total);
			Assert.That (totalAfterDiscounts, Is.EqualTo(180));
		}

		[Test ()]
		public void Should_return_260_for_6_A_Products ()
		{
			_checkout.addProduct(_productA);
			_checkout.addProduct(_productA);
			_checkout.addProduct(_productA);
			_checkout.addProduct(_productA);
			_checkout.addProduct(_productA);
			_checkout.addProduct(_productA);
			var total = _checkout.getTotal();
			var totalAfterDiscounts = _checkout.ApplyDiscounts(total);
			Assert.That (totalAfterDiscounts, Is.EqualTo(260));
		}

		[Test ()]
		public void Should_return_160_for_3_A_Products_and_1_B_Product ()
		{
			_checkout.addProduct(_productA);
			_checkout.addProduct(_productA);
			_checkout.addProduct(_productA);
			_checkout.addProduct(_productB);
			var total = _checkout.getTotal();
			var totalAfterDiscounts = _checkout.ApplyDiscounts(total);
			Assert.That (totalAfterDiscounts, Is.EqualTo(160));
		}

		[Test ()]
		public void Should_return_45_for_2_B_Products ()
		{
			_checkout.addProduct(_productB);
			_checkout.addProduct(_productB);
			var total = _checkout.getTotal();
			var totalAfterDiscounts = _checkout.ApplyDiscounts(total);
			Assert.That (totalAfterDiscounts, Is.EqualTo(45));
		}

		[Test ()]
		public void Should_Apply_Triple_A_Discount_And_Double_B_Discount_To_Return_175_For_3_A_Products_And_Two_B_Products ()
		{
			_checkout.addProduct(_productA);
			_checkout.addProduct(_productA);
			_checkout.addProduct(_productA);
			_checkout.addProduct(_productB);
			_checkout.addProduct(_productB);
			var total = _checkout.getTotal();
			var totalAfterDiscounts = _checkout.ApplyDiscounts(total);
			Assert.That (totalAfterDiscounts, Is.EqualTo(175));
		}

		[Test ()]
		public void Should_Apply_Triple_A_Discount_And_Double_B_Discount_To_Return_230_For_3_A_Products_And_Two_B_Products_And_Two_C_Products_And_One_D_Product ()
		{
			_checkout.addProduct(_productA);
			_checkout.addProduct(_productA);
			_checkout.addProduct(_productA);
			_checkout.addProduct(_productB);
			_checkout.addProduct(_productB);
			_checkout.addProduct(_productC);
			_checkout.addProduct(_productC);
			_checkout.addProduct(_productD);
			var total = _checkout.getTotal();
			var totalAfterDiscounts = _checkout.ApplyDiscounts(total);
			Assert.That (totalAfterDiscounts, Is.EqualTo(230));
		}

	}
}

