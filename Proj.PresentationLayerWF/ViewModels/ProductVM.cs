namespace Proj.PresentationLayerWF.ViewModels
{
	internal class ProductVM
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }

		public override string ToString()
		{
			return $"{Name} - {Price:C2}";
		}
	}
}
