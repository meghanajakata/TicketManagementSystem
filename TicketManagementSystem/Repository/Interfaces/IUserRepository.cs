using TicketManagementSystem.Models;

namespace TicketManagementSystem.Repository.Interfaces
{
    public interface IUserRepository
    {
        public List<User> GetUsers();
        public User GetUserById(int id);
        public void AddUser(User user);
        public int UpdateUser(User userModel);
        public int DeleteUser(int id);
    }
}
