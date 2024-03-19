using Proj.EntityLayer.Models;

namespace Proj.MappingLayer.Options
{
	public class CategoryMap : BaseMap<Category>
	{
		public CategoryMap()
		{
			ToTable("Kategori");
			Property(x => x.Name).HasColumnName("Kategori Adı");
			Property(x => x.Description).HasColumnName("Açıklama");
		}
	}
}
