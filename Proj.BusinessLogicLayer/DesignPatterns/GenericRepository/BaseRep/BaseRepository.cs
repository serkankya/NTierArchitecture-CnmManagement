using Proj.BusinessLogicLayer.DesignPatterns.GenericRepository.InterfaceRep;
using Proj.BusinessLogicLayer.DesignPatterns.SingletonPatterns;
using Proj.DataAccessLayer.Context;
using Proj.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Proj.BusinessLogicLayer.DesignPatterns.GenericRepository.BaseRep
{
	public abstract class BaseRepository<T> : IRepository<T> where T : EntityBase
	{
		AppDbContext _db;
		public BaseRepository()
		{
			_db = DBTool.DbInstance;
		}

		public void Add(T entity)
		{
			_db.Set<T>().Add(entity);
			_db.SaveChanges();
		}

		public void AddRange(List<T> entities)
		{
			_db.Set<T>().AddRange(entities);
			_db.SaveChanges();
		}

		public bool Any(Expression<Func<T, bool>> exp)
		{
			return _db.Set<T>().Any(exp);
		}

		public void Delete(T entity)
		{
			entity.Status = EntityLayer.Enums.DataStatus.Deleted;
			entity.DeletedDate = DateTime.Now;
			_db.SaveChanges();
		}

		public void DeleteRange(List<T> entities)
		{
			foreach (T item in entities)
			{
				Delete(item);
			}
		}

		public void Destroy(T entity)
		{
			_db.Set<T>().Remove(entity);
			_db.SaveChanges();
		}

		public void DestroyRange(List<T> entities)
		{
			_db.Set<T>().RemoveRange(entities);
			_db.SaveChanges();
		}

		public T Find(int id)
		{
			return _db.Set<T>().Find(id);
		}

		public T FirstOrDefault(Expression<Func<T, bool>> exp)
		{
			return _db.Set<T>().FirstOrDefault(exp);
		}

		public List<T> GetActives()
		{
			return _db.Set<T>().Where(x => x.Status != EntityLayer.Enums.DataStatus.Deleted).ToList();
		}

		public List<T> GetAll()
		{
			return _db.Set<T>().ToList();
		}

		public List<T> GetDeleteds()
		{
			return _db.Set<T>().Where(x => x.Status == EntityLayer.Enums.DataStatus.Deleted).ToList();
		}

		public List<T> GetModifieds()
		{
			return _db.Set<T>().Where(x => x.Status == EntityLayer.Enums.DataStatus.Modified).ToList();
		}

		public object Select(Expression<Func<T, object>> exp)
		{
			return _db.Set<T>().Select(exp);
		}

		public IQueryable<X> Select<X>(Expression<Func<T, X>> exp)
		{
			return _db.Set<T>().Where(x => x.Status != EntityLayer.Enums.DataStatus.Deleted).Select(exp);
		}

		public void Update(T entity)
		{
			entity.Status = EntityLayer.Enums.DataStatus.Modified;
			entity.ModifiedDate = DateTime.Now;
			T values = Find(entity.ID);
			_db.Entry(values).CurrentValues.SetValues(entity);
			_db.SaveChanges();
		}

		public void UpdateRange(List<T> entities)
		{
			foreach (T item in entities)
			{
				Update(item);
			}
		}

		public List<T> Where(Expression<Func<T, bool>> exp)
		{
			return _db.Set<T>().Where(exp).ToList();
		}
	}
}
