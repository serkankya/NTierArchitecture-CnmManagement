namespace Proj.EntityLayer.Models
{
	public class SaleDetail : EntityBase
	{
		public int SaleID { get; set; }
		public int? ProductID { get; set; }
		public int? MovieID { get; set; }

		//Relations
		public virtual Sale Sale { get; set; }
		public virtual Movie Movie { get; set; }
		public virtual Product Product { get; set; }
	}
}
