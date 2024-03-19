using Proj.DataAccessLayer.Context;

namespace Proj.BusinessLogicLayer.DesignPatterns.SingletonPatterns
{
	public class DBTool
	{
		public DBTool()
		{

		}

		private static AppDbContext _DbInstance;

		public static AppDbContext DbInstance
		{
			get
			{
				if (_DbInstance == null)
				{
					_DbInstance = new AppDbContext();
				}
				return _DbInstance;
			}
		}
	}
}
