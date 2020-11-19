using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.InterFace
{
    public interface IUserService
    {
        bool IsValid(LoginRequestDTO req);
        string Sayhellow();
    }
}
