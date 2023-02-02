using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtorizaciya
{
    class checkUser
    {
        public string login{ get; set; }

        public bool IsAdmin { get; }

        public string Status => IsAdmin ? "Администратор" : "Клиент";

        public checkUser(String login, string isAdmin)
        {
            login = login.Trim();
            IsAdmin = IsAdmin;
        }
    }
}
