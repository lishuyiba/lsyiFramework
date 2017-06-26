using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace lsyi.Data.Repository
{
    /// <summary>
    /// 
    /// lsy
    /// 
    /// 2017/6/26 上午11:30:13
    /// 
    /// 仓库接口
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public partial interface IRepository<T> where T : class
    {
        int Insert(T entity, bool isSave = true);

        int Update(T entity, bool isSave = true);

        int Delete(T entity, bool isSave = true);

        IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate);
    }
}
