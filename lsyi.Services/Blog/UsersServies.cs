using lsyi.Data.Repository;
using lsyi.Models.SystemMoels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace lsyi.Services.Blog
{
    public class UsersServies : IUsersServies
    {
        private readonly IRepository<Users> _repository;

        public UsersServies(IRepository<Users> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Users> GetAll(Expression<Func<Users, bool>> predicate)
        {
            return _repository.GetAll(predicate);
        }
    }
}
