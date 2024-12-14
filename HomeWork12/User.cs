using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12
{
    internal class User(string login, string name, bool isPremium = false)
    {
        public string Login { get; set; } = login;
        public string Name { get; set; } = name;
        public bool IsPremium { get; set; } = isPremium;
    }
}
