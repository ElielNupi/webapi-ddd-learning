using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUsers
    {
        Task<bool> AddUser(string email, string password, int age, string phone);

    }
}
