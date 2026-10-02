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
    public class PaymentController : ControllerBase
    {
        public IGenericsRepo<Payment> _repo;
        public PaymentController(IGenericsRepo<Payment> repo)
        {
            _repo = repo;
        }
        [HttpPost("PostPaypent")]
        public Task<Payment> PostPayment([FromBody]Payment payment)
        {
            var created = _repo.Add(payment);
            return created;
        }

        [HttpGet("{id}")]
        public async Task<Payment> GetPaymentsById(int id)
        {
            return await _repo.GetPaymentById(id);
        }

        [HttpGet("GetAllPayments")]
        public async Task<IEnumerable<Payment>> GetAllPayments()
        {
            var PaymentsHistory = await _repo.GetAllPayments();
            return PaymentsHistory;
        }

        [HttpDelete("{id}")]
        public async Task<Payment> DeletePayment(int id)
        {
            return await _repo.DeletePayment(id);
        }
    }
}
