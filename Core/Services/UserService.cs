using Core.Entities;
using Ports;

namespace Core.Services
{
    public class UserService
    {
        private IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        
        public UserModel SaveOrUpdateUser (UserModel user) {
            //Regras de negócio podem ser aplicadas aqui
            _userRepository.SaveOrUpdateUser(user);

            return user;
        }
    }
}
