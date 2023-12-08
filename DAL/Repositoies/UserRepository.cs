
using DAL.Context;
using DAL.DomainClass;
using DAL.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositoies
{
    public class UserRepository : IUser
    {
        private readonly DBContext dbContext;

        public UserRepository(DBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public User GetByID(string id)
        {
            return dbContext.Set<User>().Find(id);
        }

        public User GetByPhone(string phone)
        {
            return dbContext.Set<User>().SingleOrDefault(u => u.SoDienThoai == phone);
        }

        public User GetUserByUsername(string username)
        {
            return dbContext.Set<User>().SingleOrDefault(u => u.IdDangNhap == username);
        }

        public IEnumerable<User> GetAll()
        {
            return dbContext.Set<User>().ToList();
        }

        public void Delete(string userId)
        {
            var user = dbContext.Set<User>().Find(userId);
            if (user != null)
            {
                dbContext.Set<User>().Remove(user);
                dbContext.SaveChanges();
            }
        }

        public void Update(User user)
        {
            dbContext.Entry(user).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void Add(User user)
        {
            dbContext.Set<User>().Add(user);
            dbContext.SaveChanges();
        }
    }
}
