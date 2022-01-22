using Common;
using Repository;
using Repository.Entity;

namespace API.Services
{
    public class UserServices:IUserService
    {
        private readonly UserRepository _userRepository;
        public UserServices(UserRepository userRepository) {
            _userRepository = userRepository;
        }
        public void AddUser(UserModel model) {
            UserEntity entity = new UserEntity()
            {
                PassWord = model.Password,
                Type= EnumType.ADMIN.ToString()
            };
            _userRepository.Add(entity);
        }
    }
}
