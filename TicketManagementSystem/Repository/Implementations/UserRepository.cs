using TicketManagementSystem.Data;
using TicketManagementSystem.Models;
using TicketManagementSystem.Repository.Interfaces;

namespace TicketManagementSystem.Repository.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly TicketContext _dbcontext;
        public UserRepository(TicketContext dbContext)
        {
            _dbcontext = dbContext;
        }
        public List<User> GetUsers()
        {
            return _dbcontext.Users.ToList();
        }

        public User GetUserById(int id)
        {
            return _dbcontext.Users.FirstOrDefault(x => x.UserId == id);
        }

        public void AddUser(User user)
        {
            _dbcontext.Users.Add(user);
            _dbcontext.SaveChanges();
        }

        public int UpdateUser(User userModel)
        {
            User user = _dbcontext.Users.FirstOrDefault(x => x.UserId == userModel.UserId);
            if(user != null)
            {
                user = userModel;
                _dbcontext.SaveChanges();
                return 1;
            }
            return 0;
        }

        public int DeleteUser(int id)
        {
            User user = GetUserById(id);
            if(user != null)
            {
                _dbcontext.Users.Remove(user);
                _dbcontext.SaveChanges();
                return 1;
            }
            return 0;
        }

    }
}
