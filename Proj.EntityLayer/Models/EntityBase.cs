using Proj.EntityLayer.Enums;
using System;

namespace Proj.EntityLayer.Models
{
	public abstract class EntityBase
	{
		public int ID { get; set; }
		public DateTime InsertedDate { get; set; }
		public DateTime? ModifiedDate { get; set; }
		public DateTime? DeletedDate { get; set; }
		public DataStatus Status { get; set; }

		////Relations


		public EntityBase()
		{
			InsertedDate = DateTime.Now;
			Status = DataStatus.Inserted;
		}
	}
}
