using Devbox.Models;
using Devbox.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devbox.ViewModels
{
    internal class UsersViewModel: BaseViewModel
    {
        private List<User> _users;
        public  List<User> Users
        {
            get => _users;
            set => OnPropertyChanged(ref _users, value);
        }

        public UsersViewModel()
        {
            Users = LoadUsers();
        }

        private List<User> LoadUsers()
        {
            List<User> users = new();
            for (int i = 0; i < 10; i++)
            {
                User user = new();
                user.Username = $"Asyn(void){i}";
                user.Id = Guid.NewGuid();
                user.ImageUrl = "11-11-11";
                users.Add(user);
            }

            return users;
        }
    }
}
