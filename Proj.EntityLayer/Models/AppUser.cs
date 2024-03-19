namespace Proj.EntityLayer.Models
{
	public class AppUser : EntityBase
	{
		public string UserNumber { get; set; }
		public string Password { get; set; }

		//Relations
		public virtual AppUserProfile AppUserProfile { get; set; }
	}
}
