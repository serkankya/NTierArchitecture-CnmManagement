using System.Collections.Generic;

namespace Proj.EntityLayer.Models
{
	public class Sale : EntityBase
	{
		public string CustomerName { get; set; }

		//Relations
		public virtual List<SaleDetail> SaleDetails { get; set; }
	}
}
