using System;
using System.Linq;
using MyStore.Entity;

namespace MyStore.Repository
{
    public class UserRepository : IUserRepository
    {
        private StoreDbContext db;
        public UserRepository(StoreDbContext _db)
        {
            this.db = _db;
        }

        /// <summary>
        /// 根据用户名查找当前实体
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>
        public User GetEntity(string UserName)
        {
            return db.Users.FirstOrDefault(m => m.UserName == UserName);
        }
    }
}
