using Proj.EntityLayer.Models;

namespace Proj.MappingLayer.Options
{
	public class AppUserMap : BaseMap<AppUser>
	{
		public AppUserMap()
		{
			ToTable("Kullanıcı");
			Property(x => x.UserNumber).HasColumnName("Kullanıcı Numarası");
			Property(x => x.Password).HasColumnName("Şifre");
			HasOptional(x => x.AppUserProfile).WithRequired(x => x.AppUser);
		}
	}
}
