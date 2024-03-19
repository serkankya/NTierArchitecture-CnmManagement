using Proj.EntityLayer.Models;

namespace Proj.MappingLayer.Options
{
	public class MovieMap : BaseMap<Movie>
	{
		public MovieMap()
		{
			ToTable("Film");
			Property(x => x.TicketPrice).HasColumnName("Bilet Fiyatı").HasColumnType("money");
			Property(x => x.Description).HasColumnName("Açıklama");
			Property(x => x.Name).HasColumnName("Film Adi");
			Property(x => x.ReleaseDate).HasColumnName("Çıkış Tarihi").HasColumnType("date");
			Property(x => x.Director).HasColumnName("Yönetmen");
		}
	}
}
