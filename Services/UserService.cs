using AltanDenemeC.Models;
using AltanDenemeC.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace AltanDenemeC.Services
{
    public class UserService
    {
        private readonly EfRepository<Users> _efRepo;
        public UserService(EfRepository<Users> efRepository)
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