using Core.Entities;
using Ports;

namespace Adapters.Persistence
{
    public class UserRepository : IUserRepository
    {
        private readonly List<UserModel> _users = new();

        public UserModel SaveOrUpdateUser(UserModel user)
        {
            //Simulando auto-incremento
            user.Id = _users.Count + 1;
            _users.Add(user);
            
            Console.WriteLine($"Usuário salvo: {user.Id} - {user.Name}");
            
            return user;
        }
    }
}