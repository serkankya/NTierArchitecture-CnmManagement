using Proj.EntityLayer.Models;
using System.Collections.Generic;

namespace Proj.PresentationLayerWF.ViewModels
{
	public class CategoryVM
	{
		public int ID { get; set; }
		public string CategoryName { get; set; }
		public string CategoryDescription { get; set; }
		public virtual List<Movie> Movies { get; set; }

		public override string ToString()
		{
			return $"Kategori : {CategoryName} - Açıklama : {CategoryDescription}";
		}
	}
}
