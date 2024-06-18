using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp
{
    public class Authorization
    {
        private readonly List<User> _users;
        private int nextUserId;

        public Authorization()
        {
            _users = new List<User>();
            nextUserId = 0;
        }

        public bool Register(string name, string password, string email)
        {
            if (_users.Any(u => u.Email == email))
            {
                return false; //użytkownik istnieje, nie można założyć konta
            }
            else
            {
                var hashedPassword = User.HashPassword(password);
                var newUser = new User(name, hashedPassword, email);
                _users.Add(newUser);
                Console.WriteLine(newUser.Email);
                return true;
            }
        }

        public User Login(string email, string password)
        {
            var hashedPassword = User.HashPassword(password);
            var checkUser = _users.SingleOrDefault(u => u.Email == email && u.Password == hashedPassword);
            return checkUser;
        }
    }
}
