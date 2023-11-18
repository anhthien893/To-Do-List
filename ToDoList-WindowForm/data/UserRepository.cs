using data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data
{
    public class UserRepository : RepositoryBase<User>
    {
        public UserRepository() : base() { }
        public User GetByUsername(string username)
        {
            return _dbSet.FirstOrDefault(u => u.UserName == username);
        }

        public bool IsEmailDuplicate(string emailToCheck)
        {
            using (var context = new databasePrnContext())
            {

                bool isDuplicate = context.Users.Any(user => user.Email == emailToCheck);
                return isDuplicate;
            }
        }

        public User GetByUserEmail(string email)
        {
            return _dbSet.FirstOrDefault(u => u.Email == email);
        }

        public void CreateUser(User user)
        {
            Add(user);
        }

        public void UpdateUser(User user)
        {
            Update(user);
        }

        public void DeleteUser(int userId)
        {
            var user = _dbSet.Find(userId);
            if (user != null)
            {
                DeleteEntity(user);
            }
        }
    }
}
