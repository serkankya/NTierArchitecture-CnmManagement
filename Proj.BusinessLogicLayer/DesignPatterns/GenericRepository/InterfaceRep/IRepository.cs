using Proj.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Proj.BusinessLogicLayer.DesignPatterns.GenericRepository.InterfaceRep
{
	public interface IRepository<T> where T : EntityBase
	{
		//List
		List<T> GetAll();
		List<T> GetActives();
		List<T> GetDeleteds();
		List<T> GetModifieds();

		//Modify
		void Add(T entity);
		void Update(T entity);
		void Delete(T entity);
		void Destroy(T entity);

		//RangeModify
		void AddRange(List<T> entities);
		void UpdateRange(List<T> entities);
		void DeleteRange(List<T> entities);
		void DestroyRange(List<T> entities);

		//Find
		T Find(int id);

		//LINQ
		List<T> Where(Expression<Func<T, bool>> exp);
		bool Any(Expression<Func<T, bool>> exp);
		T FirstOrDefault(Expression<Func<T, bool>> exp);
		object Select(Expression<Func<T, object>> exp);
		IQueryable<X> Select<X>(Expression<Func<T, X>> exp);
	}
}
