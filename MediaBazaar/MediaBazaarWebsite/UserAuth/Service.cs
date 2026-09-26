namespace MediaBazaarWebsite.User_authentication
{
    public class Service
    {
        private readonly IUserRepository _userRepository;

        public Service(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void CreateUser(string email, string password)
        {
            var user = new User
            {
                Email = email,
                PasswordHash = password
            };

            _userRepository.AddUser(user);
        }

        public void UpdateUser(User user)
        {
            _userRepository.UpdateUser(user);
        }
    }
}
