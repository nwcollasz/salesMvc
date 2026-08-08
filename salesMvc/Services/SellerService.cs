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
    }
}