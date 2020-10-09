using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Procuerment.Data;
using Procuerment.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Procuerment
{

    public class ProcurementRepo : IProcuerment
    {
        private readonly ProcuermentContext context;
        private readonly IMapper mapper;
        private readonly ILogger<ProcurementRepo> logger;
        public ProcurementRepo(ProcuermentContext _context, ILogger<ProcurementRepo> _logger, IMapper _mapper)
        {
            context = _context;
            logger = _logger;
            mapper = _mapper;
        }
        public async Task<(bool IsSuccess, string ErrorMessage)> createProcuerment(Models.Procurement pm)//Done
        {
            if (pm == null)
            {
                throw new System.ArgumentNullException(nameof(pm));
            }

            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    logger?.LogInformation("Creating Procuerment");
                    var created = context.Procurement.Add(pm);
                    var save = await context.SaveChangesAsync();
                    transaction.Commit();
                    return (true, null);
                }
                catch (Exception ex)
                {
                    logger?.LogError(ex.ToString());
                    transaction.Rollback();
                    Console.WriteLine("{0} Exception caught.", ex);
                    return (false, "Not Found");
                }
            }

            return (true, null);

        }

        public async Task<(bool IsSuccess, Models.Procurement Procuerment, string ErrorMessage)> GetProcuermentById(int id)
        {
            try
            {
                logger?.LogInformation("Querying Procuerment");
                var procuerment = await context.Procurement
                .Include(s => s.Baseline)
                .Include(s => s.ValueLever)
                .Include(s => s.InitiativeStatus)
                .Include(s => s.FinancialStatementArea)
                .Include(s => s.Role)
                .Include(s => s.Period)
                .Include(s => s.MilestoneStatus)
                .Include(s => s.Supplier)
                .Include(s => s.CompanyCodeNavigation)
                .Include(s => s.MaterialGroupNavigation)
                .Include(s => s.MaterialDescriptionNavigation)
                 .FirstOrDefaultAsync(c => c.ProcurementId == id);

                if (procuerment != null)
                {
                    logger?.LogInformation("Customprocuermenter found");
                    var result = mapper.Map<Models.Procurement>(procuerment);
                    return (true, result, null);
                }
                return (false, null, "Not Found");
            }
            catch (Exception ex)
            {
                logger?.LogError(ex.ToString());
                return (false, null, "Not Found");

            }
        }

        public async Task<(bool IsSuccess, IEnumerable<Models.Procurement> Procuerment, string ErrorMessage)> GetAllProcuerment()
        {
            try
            {
                logger?.LogInformation("Querying Procuerment");
                context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
                // IQueryable<Models.Procuerment> allProcuerment;
                // var allProcuerment = await context.Procurement.ToListAsync();
                var data = await context.Procurement
                .Include(s => s.Baseline)
                .Include(s => s.ValueLever)
                .Include(s => s.InitiativeStatus)
                .Include(s => s.FinancialStatementArea)
                .Include(s => s.Role)
                .Include(s => s.Period)
                .Include(s => s.MilestoneStatus)
                .Include(s => s.Supplier)
                .Include(s => s.CompanyCodeNavigation)
                .Include(s => s.MaterialGroupNavigation)
                .Include(s => s.MaterialDescriptionNavigation)
                .ToListAsync();
                //var data = allProcuerment.OrderByDescending(x => x.Creationdate);

                if (data != null && data.Any())
                {
                    logger?.LogInformation($"Procuerment(s) found", data);
                    var result = mapper.Map<IEnumerable<Models.Procurement>>(data);
                    return (true, result, null);
                }
                return (false, null, "Not Found");
            }
            catch (Exception ex)
            {
                logger?.LogError(ex.ToString());
                return (false, null, ex.Message);


            }
        }

        public async Task<(bool IsSuccess, IEnumerable<Models.Procurement> Procuerment, string ErrorMessage)> GetProcuermentByFilter(String queryParameter)
        {
            try
            {
                logger?.LogInformation("Querying Procuerment");
                context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
                // IQueryable<Models.Procuerment> allProcuerment;
                if (queryParameter != null)
                {
                    var allProcuerment = await context.Procurement.Where(x => x.InitiativeTitle == queryParameter
                    || x.CreatedBy == queryParameter).ToListAsync();//search with unique ID reamins
                    var data = allProcuerment.OrderByDescending(x => x.Creationdate);
                    if (data != null && data.Any())
                    {
                        logger?.LogInformation($"Procuerment(s) found");
                        var result = mapper.Map<IEnumerable<Models.Procurement>>(data);
                        return (true, result, null);
                    }
                }
                return (false, null, "Not Found");
            }
            catch (Exception ex)
            {
                logger?.LogError(ex.ToString());
                return (false, null, ex.Message);


            }
        }
        public bool saveChanges()
        {
            return (context.SaveChanges() >= 0);
        }

        public void updateProcuerment(Models.Procurement pm)
        {
            throw new NotImplementedException();
        }

        public async Task<(bool IsSuccess, LookUps lookup, string ErrorMessage)> GetAlllookups()
        {
            try
            {
                logger?.LogInformation("Querying Procuerment");
                context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

                var alldata = new Models.LookUps();

                alldata.BaselineType = await context.BaselineType.ToListAsync();
                alldata.CompanyCode = await context.CompanyCode.ToListAsync();
                alldata.FinancialStatementArea = await context.FinancialStatementArea.ToListAsync();
                alldata.InitiativeStatus = await context.InitiativeStatus.ToListAsync();
                alldata.MaterialGroup = await context.MaterialGroup.ToListAsync();
                alldata.MaterialGroupDesccription = await context.MaterialGroupDesccription.ToListAsync();
                alldata.MaterialMater = await context.MaterialMater.ToListAsync();
                alldata.MilestoneStatus = await context.MilestoneStatus.ToListAsync();
                alldata.Period = await context.Period.ToListAsync();
                alldata.PlantName = await context.PlantName.ToListAsync();
                alldata.PurchaseOrganization = await context.PurchaseOrganization.ToListAsync();
                alldata.Supplier = await context.Supplier.ToListAsync();
                alldata.ValueContribution = await context.ValueContribution.ToListAsync();
                alldata.ValueLever = await context.ValueLever.ToListAsync();
                if (alldata != null)
                {
                    logger?.LogInformation($"Procuerment(s) found");
                    return (true, alldata, null);
                }
                return (false, null, "Not Found");
            }
            catch (Exception ex)
            {
                logger?.LogError(ex.ToString());
                return (false, null, ex.Message);


            }
        }


    }
}
