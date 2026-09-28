using PaymentServices.Repo.Models;
using System.Linq.Expressions;

namespace PaymentServices.Repo.Interfaces
{
    public interface IGenericRepo<T> where T : class
    {
        Task<T> GetPaymentById(int id);
    }
}