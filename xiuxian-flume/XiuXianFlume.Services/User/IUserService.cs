namespace XiuXianFlume.Services.User
{
    /// <summary>
    /// user service interface
    /// </summary>
    public interface IUserService
    {
        Core.Domain.User GetUserById(int userId);
    }
}