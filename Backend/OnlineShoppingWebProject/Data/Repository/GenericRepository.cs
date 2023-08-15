﻿using Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Data.Repository
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{
<<<<<<< HEAD
		protected readonly OnlineShopDbContext _context;
=======
		readonly OnlineShopDbContext _context;
>>>>>>> a7aea91e0d5ffcffd71714a402ecc42b8df1b26f

		public GenericRepository(OnlineShopDbContext context)
		{
			_context = context;
		}

		public void Add(T entity)
		{
			_context.Set<T>().Add(entity);
		}

		public void AddRange(IEnumerable<T> entities)
		{
			_context.Set<T>().AddRange(entities);
		}

		public IEnumerable<T> FindAll(Expression<Func<T, bool>> expression)
		{
			var result = _context.Set<T>().Where(expression).ToList();

			return result;
		}

		public T FindFirst(Expression<Func<T, bool>> expression)
		{
			var result = _context.Set<T>().Where(expression).FirstOrDefault();

			return result;
		}

		public IEnumerable<T> GetAll()
		{
			var result = _context.Set<T>().ToList();

			return result;
		}

		public T GetById(int id)
		{
			var result = _context.Set<T>().Find(id);
			
			return result;
		}

		public void Remove(T entity)
		{
			_context.Set<T>().Remove(entity);
		}

		public void RemoveRange(IEnumerable<T> entities)
		{
			_context.Set<T>().RemoveRange(entities);
		}

		public void Update(T entity)
		{
			_context.Set<T>().Update(entity);
		}
	}
}
