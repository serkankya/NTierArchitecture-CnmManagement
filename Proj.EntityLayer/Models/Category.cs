using System.Collections.Generic;

namespace Proj.EntityLayer.Models
{
	public class Category : EntityBase
	{
		public string Name { get; set; }
		public string Description { get; set; }

		//Relations
		public virtual List<Movie> Movies { get; set; }
	}
}
