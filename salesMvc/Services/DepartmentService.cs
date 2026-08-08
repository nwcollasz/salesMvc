using Microsoft.EntityFrameworkCore;
using salesMvc.Models;
using salesMvc.Data;

namespace salesMvc.Services
{
    public class DepartmentService
    {
        private readonly salesMvcContext _context;

        public DepartmentService(salesMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}