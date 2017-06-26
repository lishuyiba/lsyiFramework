using lsyi.Models.SystemMoels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace lsyi.Services.Blog
{
    public interface IUsersServies
    {
        IEnumerable<Users> GetAll(Expression<Func<Users, bool>> predicate);
    }
}
