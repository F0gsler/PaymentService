using PaymentServices.Repo.Data;
using PaymentServices.Repo.Interfaces;
using PaymentServices.Repo.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;


namespace PaymentServices.Repo.Repositiories
{
    public class GenericRepo<T> : IGenericsRepo<T> where T : class
    {
        protected readonly DatabaseContext context;
        protected readonly DbSet<T> dbSet;

        public GenericRepo(DatabaseContext c)
        {
            context = c;
            dbSet = context.Set<T>();
        }

        public async Task<T> GetPaymentById(int id) => await dbSet.FindAsync(id);

        public async Task<IEnumerable<T>> GetAllPayments()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<T> DeletePayment(int id)
        {
            var item = await dbSet.FindAsync(id);
            if (item == null) return null;
            dbSet.Remove(item);
            await context.SaveChangesAsync();
            return item;
        }

        public async Task<T> Add(T item) {
            await dbSet.AddAsync(item);
            await context.SaveChangesAsync();
            return item;
        }

    }
}
