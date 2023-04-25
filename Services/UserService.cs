using AltanDenemeC.Models;
using AltanDenemeC.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace AltanDenemeC.Services
{
    public class UserService : IUserService
    {
        private readonly IEfRepository<Users> _efRepo;
        public UserService(IEfRepository<Users> efRepository)
        {
            _efRepo = efRepository;    
        }

        public bool deleteAll() 
        {
            bool result = _efRepo.DeleteAll();
            return result;
        }
        public List<Users> getAll() 
        {
            return _efRepo.GetAll();
        }

        public Users addNewUser(Users user)
        {
            return _efRepo.Add(user);
        }
    }
}