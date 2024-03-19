namespace Proj.EntityLayer.Models
{
	public class AppUserProfile : EntityBase
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string PhoneNumber { get; set; }
		public string City { get; set; }
		public string District { get; set; }
		public string Address { get; set; }
		public bool Gender { get; set; }

		//Relations
		public virtual AppUser AppUser { get; set; }
	}
}
