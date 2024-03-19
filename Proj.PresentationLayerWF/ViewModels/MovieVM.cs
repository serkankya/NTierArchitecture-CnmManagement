using System;

namespace Proj.PresentationLayerWF.ViewModels
{
	public class MovieVM
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Director { get; set; }
		public string Description { get; set; }
		public DateTime ReleaseDate { get; set; }
		public decimal TicketPrice { get; set; }
		public int CategoryID { get; set; }
		public string CategoryName { get; set; }

		public override string ToString()
		{
			return $"{Name} - {TicketPrice:C2}";
		}
	}
}
