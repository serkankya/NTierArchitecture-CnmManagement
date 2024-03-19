using Proj.EntityLayer.Models;

namespace Proj.MappingLayer.Options
{
	public class AppUserProfileMap : BaseMap<AppUserProfile>
	{
		public AppUserProfileMap()
		{
			ToTable("Kullanici Bilgileri");
			Property(x => x.Name).HasColumnName("Ad");
			Property(x => x.Surname).HasColumnName("Soyad");
			Property(x => x.PhoneNumber).HasColumnName("Telefon Numarası");
			Property(x => x.City).HasColumnName("Şehir");
			Property(x => x.District).HasColumnName("İlçe");
			Property(x => x.Address).HasColumnName("Adres");
			Property(x => x.Gender).HasColumnName("Cinsiyet").HasColumnType("bit");
		}
	}
}
