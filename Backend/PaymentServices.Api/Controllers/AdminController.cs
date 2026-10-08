using Microsoft.AspNetCore.Mvc;
using PaymentServices.Repo.Interfaces;
using PaymentServices.Repo.Models;
using System.Collections;
using System.Reflection.Metadata.Ecma335;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PaymentServices.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        public IGenericsRepo<Admin> _repo;

        public AdminController(IGenericsRepo<Admin> repoAdmin)
        {
            _repo = repoAdmin;
        }

        [HttpPost("createAdminUser")]
        public Task<Admin> CreateAdminUser([FromBody] Admin admin)
        {
            var created = _repo.Add(admin);
            return created;
        }

       
    }
}
