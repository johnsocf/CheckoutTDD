using System;
using System.Collections.Generic;

namespace CheckOut
{
	public class Discount
	{
		public int _total;
		public Discount ()
		{
			
		}

		public int Check_For_Discount(IList<Product> _products, int total)
		{
			var countA = 0;
			var countB = 0;
			_total = total;
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

			return _total;
		}

		public void Triple_A_Discount ()
		{
			_total -= 20;
		}

		public void Double_B_Discount ()
		{
			_total -= 15;
		}
	}
}

