using SaleWebMVC.Data;
using SaleWebMVC.Models;

namespace SaleWebMVC.Services
{
    public class DepartmentService
    {
        private readonly SaleWebMVCContext _context;

        public DepartmentService(SaleWebMVCContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
