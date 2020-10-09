// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.Extensions.Logging;
// using Procuerment.Data;
// using Procuerment.Models;
// using AutoMapper;
// using Microsoft.AspNetCore.Authorization;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using System.Linq;
// using System.IdentityModel.Tokens.Jwt;
// using Microsoft.AspNetCore.Http;

// namespace Procuerment
// {

//     public class UserRepo : IUser
//     {
//         private readonly ProcuermentContext context;
//         private readonly ILogger<ProcurementRepo> logger;
//         public UserRepo(ProcuermentContext _context, ILogger<ProcurementRepo> _logger)
//         {
//             context = _context;
//             logger = _logger;
//         }
//         public async Task<(bool IsSuccess, string ErrorMessage)> UserAccess(string username)
//         {
//             try
//             {

//                 logger?.LogInformation("Checking Role Access");
//                 var User = await context.UserInfo.FirstOrDefaultAsync(c => c.UserName == username);
//                 var Role = await context.UserRoleMapping.FirstOrDefaultAsync(c => c.UserId == User.UserId);
//                 if (Role == null)
//                 {
//                     return (false, "Not Authorized");
//                 }
//                 else if (Role.RoleId == 2)
//                 {
//                     return (true, null);
//                 }
//                 else
//                 {
//                     return (false, "Not Authorized");
//                 }
//             }
//             catch (Exception ex)
//             {
//                 logger?.LogError(ex.ToString());
//                 Console.WriteLine("{0} Exception caught.", ex);
//                 return (false, "Not Found");
//             }
//         }

//         public async Task<(bool IsSuccess, string ErrorMessage)> IsAdmin(int? Id)
//         {
//             try
//             {
//                 logger?.LogInformation("Checking Role Access");
//                 var Role = await context.UserRoleMapping.FirstOrDefaultAsync(c => c.UserId == Id);
//                 if (Role == null)
//                 {
//                     return (false, "Not Authorized");
//                 }
//                 else if (Role.RoleId == 1)
//                 {
//                     return (true, null);
//                 }
//                 else
//                 {
//                     return (false, "Not Authorized");
//                 }
//             }
//             catch (Exception ex)
//             {
//                 logger?.LogError(ex.ToString());
//                 Console.WriteLine("{0} Exception caught.", ex);
//                 return (false, "Not Found");
//             }
//         }

//         public string getTokenData(HttpContext context)//Decode JWT TOken to get UserName
//         {
//             var handler = new JwtSecurityTokenHandler();
//             string authHeader = context.Request.Headers["Authorization"];
//             authHeader = authHeader.Replace("Bearer ", "");
//             var jsonToken = handler.ReadToken(authHeader);
//             var tokenS = handler.ReadToken(authHeader) as JwtSecurityToken;
//             var UserName = tokenS.Claims.First(claim => claim.Type == "sub").Value;
//             return UserName;
//         }


//     }
// }
