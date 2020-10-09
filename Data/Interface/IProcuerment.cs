using Procuerment.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Procuerment.Data
{

    public interface IProcuerment
    {
        bool saveChanges();

        Task<(bool IsSuccess, IEnumerable<Models.Procurement> Procuerment, string ErrorMessage)> GetAllProcuerment();



        Task<(bool IsSuccess, IEnumerable<Models.Procurement> Procuerment, string ErrorMessage)> GetProcuermentByFilter(string queryParameter);


        Task<(bool IsSuccess, Models.Procurement Procuerment, string ErrorMessage)> GetProcuermentById(int id);

        Task<(bool IsSuccess, Models.LookUps lookup, string ErrorMessage)> GetAlllookups();

        Task<(bool IsSuccess, string ErrorMessage)> createProcuerment(Models.Procurement pm);

        void updateProcuerment(Models.Procurement pm);
    }
}
