using Proj.EntityLayer.Models;
using System.Data.Entity.ModelConfiguration;

namespace Proj.MappingLayer.Options
{
	public abstract class BaseMap<T> : EntityTypeConfiguration<T> where T : EntityBase
	{
		public BaseMap()
		{
			Property(x => x.InsertedDate).HasColumnName("Oluşturulma Tarihi");
			Property(x => x.ModifiedDate).HasColumnName("Güncellenme Tarihi");
			Property(x => x.DeletedDate).HasColumnName("Silinme Tarihi");
			Property(x => x.Status).HasColumnName("Veri Durumu");
		}
	}
}
