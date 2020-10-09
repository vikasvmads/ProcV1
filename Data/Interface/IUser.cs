using Procuerment.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Procuerment.Data
{

    public interface IUser
    {
        Task<(bool IsSuccess, string ErrorMessage)> UserAccess(string Id);
        Task<(bool IsSuccess, string ErrorMessage)> IsAdmin(int? Id);

        public string getTokenData(HttpContext context);

    }
}
