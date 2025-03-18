using Core.Entities;

namespace Ports
{
    public interface IUserRepository
    {
        public UserModel SaveOrUpdateUser (UserModel user);
    }
}
