using System;
using System.Collections.Generic;

namespace CheckOut
{
	public class Discount
	{
		
		public Discount ()
		{
			
		}

		public void Check_For_Discount(IList<Product> _products)
		{
			var products = _products;
			var countA = 0;
			var countB = 0;
			foreach (var product in _products) {
				if (product.Name == "A") {
					countA++;
				} else if (product.Name == "B") {
					countB++;
				}
				if ((countA % 3) == 0 && (countA != 0)) {
					Triple_A_Discount ();
					countA = 0;
				}
				if ((countB % 2) == 0 && (countB != 0)) {
					Double_B_Discount ();
					countB = 0;
				}
			}

			return;
		}

		public void Check_Cart_Totals()
		{
			
		}

		public int Triple_A_Discount ()
		{
			return 1;
		}

		public int Double_B_Discount ()
		{
			return 2;
		}
	}
}

