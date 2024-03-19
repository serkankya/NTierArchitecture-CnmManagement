using System.Collections.Generic;

namespace Proj.EntityLayer.Models
{
	public class Product : EntityBase
	{
		public string Name { get; set; }
		public decimal Price { get; set; }

		//Relations
		public virtual List<SaleDetail> SaleDetails { get; set; }
	}
}
