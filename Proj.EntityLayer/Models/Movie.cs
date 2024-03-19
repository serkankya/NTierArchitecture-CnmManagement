using System;
using System.Collections.Generic;

namespace Proj.EntityLayer.Models
{
	public class Movie : EntityBase
	{
		public string Name { get; set; }
		public string Director { get; set; }
		public string Description { get; set; }
		public DateTime ReleaseDate { get; set; }
		public decimal TicketPrice { get; set; }
		public int CategoryID { get; set; }

		//Relations
		public virtual Category Category { get; set; }
		public virtual List<SaleDetail> SaleDetails { get; set; }
	}
}
