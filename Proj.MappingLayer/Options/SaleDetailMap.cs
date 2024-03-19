using Proj.EntityLayer.Models;

namespace Proj.MappingLayer.Options
{
	public class SaleDetailMap : BaseMap<SaleDetail>
	{
		public SaleDetailMap()
		{
			ToTable("Satis Detaylari");
			Ignore(x => x.ID);
			HasKey(x => new
			{
				x.SaleID,
				x.ProductID,
				x.MovieID
			});
		}
	}
}
