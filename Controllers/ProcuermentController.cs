using System.Collections.Generic;
using Procuerment.Models;
using Procuerment.Data;
using AutoMapper;
using System;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.IdentityModel.Tokens.Jwt;

namespace Procuerment.Controller
{

    [Route("api/Procuerment/")]
    [ApiController]
    public class ProcuermentController : ControllerBase
    {
        private readonly IProcuerment _repo;
        // private readonly IUser _userrepo;

        // public ProcuermentController(IProcuerment repo, IUser userrepo)
        public ProcuermentController(IProcuerment repo)

        {

            _repo = repo;
            // _userrepo = userrepo;
        }
        [HttpPost]
        public async Task<IActionResult> createProcuerment(Models.Procurement pm)//Done
        {
            var result = await _repo.createProcuerment(pm);
            if (result.IsSuccess)
            {
                return CreatedAtRoute(nameof(GetProcuermentById), new { Id = pm.ProcurementId }, pm);
            }
            return NotFound();
        }



        [HttpGet("{id}", Name = "GetProcuermentById")]
        public async Task<IActionResult> GetProcuermentById(int id, [FromQuery] ProcuermentQueryData queryParameter)//Done
        {
            // if (queryParameter.UserId == null)
            // {
            //     return BadRequest("UserId is not found");
            // }
            var result = await _repo.GetProcuermentById(id);
            if (result.IsSuccess)
            {
                return Ok(result.Procuerment);
            }
            return NotFound();
            // var verification = await _userrepo.UserAccess(queryParameter.UserName);
            // if (verification.IsSuccess)
            // {
            //     var result = await _repo.GetProcuermentById(id);
            //     if (result.IsSuccess)
            //     {
            //         return Ok(result.Procuerment);
            //     }
            //     return NotFound();
            // }
            // else
            // {
            //     return Unauthorized();
            // }
        }


        [HttpGet("access/{id}")]
        // [Route("access/{id}")]
        // public async Task<IActionResult> checkUserAccess(string username)//Done
        // {
        //     if (username == null)
        //     {
        //         return BadRequest("UserId is required");
        //     }
        //     var verification = await _userrepo.UserAccess(username);
        //     if (verification.IsSuccess)
        //     {
        //         return Ok();
        //     }
        //     else
        //     {
        //         return Unauthorized();
        //     }
        // }
        [HttpGet]
        public async Task<IActionResult> GetAllProcuerment([FromQuery] ProcuermentQueryData queryParameter)//Done
        {
            try
            {
                // var UserName = _userrepo.getTokenData(HttpContext);
                // var verification = await _userrepo.UserAccess(UserName);
                // if (verification.IsSuccess)
                // {

                var result = await _repo.GetAllProcuerment();//
                if (result.IsSuccess)
                {
                    var Procuerments = result.Procuerment;
                    Procuerments = Procuerments
                                      .Skip(queryParameter.Size * (queryParameter.Page - 1))
                                      .Take(queryParameter.Size);
                    return Ok(Procuerments);
                }
                else
                {
                    return NotFound(result.ErrorMessage);
                }
                // }
                // else
                // {
                //     return Unauthorized();
                // }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception("Somthing went wrong.Please try again later.");
            }
        }

        [HttpGet("filterdata")]
        public async Task<IActionResult> GetProcuermentByFilter([FromQuery] string query, [FromQuery] DateTime fromdate, [FromQuery] DateTime todate)//Done
        {
            try
            {
                // var UserName = _userrepo.getTokenData(HttpContext);
                // var verification = await _userrepo.UserAccess(UserName);
                // if (verification.IsSuccess)
                // {
                if (query != null || fromdate != null || todate != null)
                {
                    var result = await _repo.GetProcuermentByFilter(query, fromdate, todate);//
                    if (result.IsSuccess)
                    {
                        var Procuerments = result.Procuerment;
                        return Ok(Procuerments);
                    }
                    else
                    {
                        return NotFound("No records found");
                    }
                }
                else
                {
                    return BadRequest("Please provide input field to search.");
                }

                // }
                // else
                // {
                //     return Unauthorized();
                // }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("Somthing went wrong.Please try again later.");
            }
        }

        [HttpGet(("alllookupdata"))]
        public async Task<IActionResult> GetAlllookupData()//Done
        {
            try
            {
                // var UserName = _userrepo.getTokenData(HttpContext);
                // var verification = await _userrepo.UserAccess(UserName);
                // if (verification.IsSuccess)
                // {

                var result = await _repo.GetAlllookups();//
                if (result.IsSuccess)
                {

                    return Ok(result.lookup);
                }
                else
                {
                    return NotFound();
                }
                // }
                // else
                // {
                //     return Unauthorized();
                // }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("Somthing went wrong.Please try again later.");
            }
        }

        public IActionResult updateProcuerment(int id, Models.Procurement pm)//Done
        {

            var Procuerment = _repo.GetProcuermentById(id);
            if (Procuerment == null)
            {
                return NotFound();
            }
            _repo.updateProcuerment(pm);
            _repo.saveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCommand(int id)
        {
            var result = await _repo.GetProcuermentById(id);

            if (result.IsSuccess)
            {
                _repo.deletedata(result.Procuerment);
                var saved = _repo.saveChanges();
                if (saved)
                {

                    var allData = await _repo.GetAllProcuerment();//
                    if (allData.IsSuccess)
                    {
                        var Procuerments = allData.Procuerment;
                        return Ok(Procuerments);
                    }
                    else
                    {
                        return NotFound(allData.ErrorMessage);
                    }
                }
                else
                {
                    return BadRequest("Something went wrong");
                }
            }
            return NotFound();


        }

    }
}