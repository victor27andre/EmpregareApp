using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmpregareApp.Models;
using EmpregareApp.Data;


namespace EmpregareApp.Controllers
{
    [Produces("application/json")]
    [Route("api/Account")]
    public class AccountController : ControllerBase
    {
        private readonly ApiContext _context;

        public AccountController(ApiContext context) 
        {
            _context = context;
        } 

        //get dos logins se tem login ou não
        [HttpGet]
        public IEnumerable<Account> Login()
        {
            return _context.Accounts;
        }

        //post de um novo cadastro
        public IActionResult Post([FromBody] Account account)
        {
            return NoContent();
        }
    }
}
