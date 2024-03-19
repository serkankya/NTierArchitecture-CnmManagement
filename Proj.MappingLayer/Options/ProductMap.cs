using Proj.EntityLayer.Models;

namespace Proj.MappingLayer.Options
{
	public class ProductMap : BaseMap<Product>
	{
		public ProductMap()
		{
			ToTable("Ürünler");
			Property(x => x.Price).HasColumnName("Fiyat").HasColumnType("money");
			Property(x => x.Name).HasColumnName("Ürün");
		}
	}
}
