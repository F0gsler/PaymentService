using PaymentServices.Repo.Models;
using System.Linq.Expressions;

namespace PaymentServices.Repo.Interfaces
{
    public interface IGenericsRepo<T> where T : class
    {
        Task<T> GetPaymentById(int id);
        Task<T> DeletePayment(int id);
        Task<IEnumerable<T>> GetAllPayments();
        Task<T> Add(T item);

    }
}