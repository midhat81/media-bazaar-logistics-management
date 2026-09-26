namespace MediaBazaarWebsite.User_authentication
{
    public interface IUserRepository
    {
        User GetUserByEmail(string email);
        User AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
    }
}
