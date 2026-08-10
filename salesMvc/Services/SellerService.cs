using salesMvc.Data;
using salesMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace salesMvc.Services
{
    public class SellerService
    {
        private readonly salesMvcContext _context;

        public SellerService(salesMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Seller>> FindAllAsync()
        {
            return await _context.Seller.ToListAsync();
        }

        public async Task InsertAsync(Seller obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Seller> FindByIdAsync(int id)
        {
            return await _context.Seller
                .Include(obj => obj.Department)
                .FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Seller.FindAsync(id);
                _context.Seller.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new Exception("Can't delete seller because he/she has sales");
            }
        }
    }
}