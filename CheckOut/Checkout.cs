using System;
using System.Collections.Generic;

namespace CheckOut
{
	public class Checkout
	{
		private IList<Product> _products;

		public Checkout ()
		{
			_products = new List<Product>();

		}
		public int getTotal() 
		{
			var Total = 0;
			foreach (var product in _products) {
				Total += product.Price;
			}
			return Total;
		}
		public int ApplyDiscounts(int total)
		{
			var discount = new Discount ();
			var totalAfterDiscounts = discount.Check_For_Discount(_products, total);
			return totalAfterDiscounts;
		}
		public void addProduct(Product product) 
		{
			_products.Add(product);
		}

	}
}

