using XiuXianFlume.Core.Data;

namespace XiuXianFlume.Services.User
{
    public class UserService : IUserService
    {
        private readonly IRepository<Core.Domain.User> _uerRepository;

        public UserService(IRepository<Core.Domain.User> uerRepository)
        {
            _uerRepository = uerRepository;
        }

        public Core.Domain.User GetUserById(int userId)
        {
            if (userId == 0)
                return null;

            return _uerRepository.GetById(userId);
        }
    }
}