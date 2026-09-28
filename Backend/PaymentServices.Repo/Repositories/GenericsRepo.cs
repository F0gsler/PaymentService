using PaymentServices.Repo.Data;
using PaymentServices.Repo.Interfaces;
using PaymentServices.Repo.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Threading.Tasks;


namespace PaymentServices.Repo.Repositiories
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        protected readonly DatabaseContext context;
        protected readonly DbSet<T> dbSet;

        public GenericRepo(DatabaseContext c)
        {
            context = c;
            dbSet = context.Set<T>();
        }

        public async Task<T> GetPaymentById(int id) => await dbSet.FindAsync(id);


    }
}
