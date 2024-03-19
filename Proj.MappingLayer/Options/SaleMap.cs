using Proj.EntityLayer.Models;

namespace Proj.MappingLayer.Options
{
	public class SaleMap : BaseMap<Sale>
	{
		public SaleMap()
		{
			ToTable("Satislar");
			Property(x => x.CustomerName).HasColumnName("Müşteri");
		}
	}
}
