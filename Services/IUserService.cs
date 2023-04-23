using AltanDenemeC.Models;

namespace AltanDenemeC.Services
{
    public interface IUserService
    {
        public bool deleteAll();
        public List<Users> getAll();
        public Users addNewUser(Users user);
    }
}