using lsyi.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace lsyi.Data.Repository
{
    /// <summary>
    /// 
    /// lsy
    /// 
    /// 2017/6/26 上午11:30:13
    /// 
    /// 实体仓库
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;
        private DbSet<T> _entities;

        #region 构造函数
        public Repository()
        {
            this._context = new LsyiObjectContext();
        } 
        #endregion

        #region 属性
        protected virtual DbSet<T> Entities
        {
            get
            {
                if (_entities == null)
                {
                    _entities = _context.Set<T>();
                }
                return _entities;
            }
        }

        public virtual IQueryable<T> Table
        {
            get
            {
                return this.Entities;
            }
        }
        #endregion

        #region 增删查改
        public int Insert(T entity, bool isSave = true)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            this._context.Add(entity);
            if (isSave)
            {
                return this._context.SaveChanges();
            }
            return 0;
        }

        public int Update(T entity, bool isSave = true)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            this._context.Update<T>(entity);
            if (isSave)
            {
                return this._context.SaveChanges();
            }
            return 0;
        }

        public int Delete(T entity, bool isSave = true)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            this._context.Remove<T>(entity);
            if (isSave)
            {
                return this._context.SaveChanges();
            }
            return 0;
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return this.Table.Where(predicate);
        } 
        #endregion
    }
}
