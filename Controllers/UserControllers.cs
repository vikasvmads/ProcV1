// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.Extensions.Configuration;
// using System.Collections.Generic;
// using Microsoft.IdentityModel.Tokens;
// using System.Security.Claims;
// using System.Text;
// using System;
// using System.IdentityModel.Tokens.Jwt;
// using System.Security.Claims;
// using System.Text;
// using System.Threading.Tasks;
// using Procuerment.Data;
// using Procuerment.Models;
// namespace Procuerment.Controllers
// {

//     [ApiController]
//     [Route("api/Role/")]

//     public class UserRoleMapper : ControllerBase
//     {

//         private readonly ProcuermentContext _repository;
//         private readonly IUser _userrepo;
//         private IConfiguration _configuration;


//         public UserRoleMapper(ProcuermentContext context, IUser userrepo, IConfiguration config)
//         {
//             _repository = context;//Get this from Dependency injection from start.cs
//             _userrepo = userrepo;
//             _configuration = config;

//         }

//         [HttpPost]

//         public async Task<IActionResult> CreateRoleMapping(UserRoleMapping _roleMapper, [FromQuery] ProcuermentQueryData parameters)//Done
//         {
//             if (_roleMapper.UserId > 0 && _roleMapper.RoleId > 0 && parameters.UserId > 0)
//             {
//                 try
//                 {
//                     Console.Write("_roleMapper" + _roleMapper);
//                     var userAccess = await _userrepo.IsAdmin(parameters.UserId);
//                     if (userAccess.IsSuccess)
//                     {
//                         var userData = await _repository.UserInfo.FirstOrDefaultAsync(u => u.UserId == _roleMapper.UserId);
//                         if (userData != null)
//                         {
//                             var isExist = await _repository.UserRoleMapping.FirstOrDefaultAsync(u => u.UserId == _roleMapper.UserId);
//                             if (isExist != null) //Existing Users
//                             {
//                                 isExist.RoleId = _roleMapper.RoleId;
//                                 isExist.CreatedDate = DateTime.Now;
//                                 isExist.MODIFY_DATE = DateTime.Now;
//                                 isExist.MODIFY_BY = (parameters.UserId).ToString();
//                                 var save = _repository.SaveChanges();
//                                 if (save >= 0)
//                                 {
//                                     return Ok();
//                                 }
//                                 else
//                                 {
//                                     return BadRequest();

//                                 }
//                             }
//                             else     //New User
//                             {
//                                 var newData = new UserRoleMapping();
//                                 newData.RoleId = _roleMapper.RoleId;
//                                 newData.UserId = _roleMapper.UserId;
//                                 newData.CreatedDate = DateTime.Now;
//                                 newData.MODIFY_DATE = DateTime.Now;
//                                 newData.MODIFY_BY = (parameters.UserId).ToString();
//                                 var mapping = await _repository.UserRoleMapping.AddAsync(newData);
//                                 var save = _repository.SaveChanges();
//                                 if (save >= 0)
//                                 {
//                                     return Ok();
//                                 }
//                                 else
//                                 {
//                                     return BadRequest();

//                                 }
//                             }
//                         }
//                         else
//                         {
//                             return NotFound();
//                         }
//                     }
//                     else
//                     {
//                         return Unauthorized();
//                     }

//                 }
//                 catch (Exception ex)
//                 {
//                     Console.WriteLine(ex);
//                     throw new Exception("Somthing went wrong.Please try again later.");
//                 }
//             }
//             else
//             {
//                 return BadRequest("Please provide inputs");
//             }

//         }

//         [HttpGet("auth")]
//         public async Task<IActionResult> Post(UserInfo _userData)
//         {
//             if (_userData != null)
//             {
//                 try
//                 {
//                     var user = await GetUser(_userData.UserId);

//                     if (user != null)
//                     {
//                         //create claims details based on the user information
//                         var claims = new[] {
//                         new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
//                         new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
//                         new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
//                         };

//                         var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

//                         var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

//                         var token = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"], claims, expires: DateTime.UtcNow.AddDays(1), signingCredentials: signIn);

//                         return Ok(new JwtSecurityTokenHandler().WriteToken(token));
//                     }
//                     else
//                     {
//                         return BadRequest("Invalid credentials");
//                     }
//                 }
//                 catch (Exception e)
//                 {
//                     Console.WriteLine(e);
//                     throw new Exception("Somthing went wrong.Please try again later.");

//                 }
//             }
//             else
//             {
//                 return BadRequest();
//             }
//         }
//         private async Task<UserInfo> GetUser(int userid)
//         {
//             return await _repository.UserInfo.FirstOrDefaultAsync(u => u.UserId == userid);
//         }
//     }

// }