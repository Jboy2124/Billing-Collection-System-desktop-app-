using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billing_collection.Repository.Login
{
    public interface LoginRepoInterface
    {
        Task<bool> Authentication(string username, string password);
    }
}
