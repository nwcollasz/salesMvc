using salesMvc.Data;
using salesMvc.Models;

namespace salesMvc.Services
{
    public class SellerService
    {
        private readonly salesMvcContext _context;

        public SellerService(salesMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
