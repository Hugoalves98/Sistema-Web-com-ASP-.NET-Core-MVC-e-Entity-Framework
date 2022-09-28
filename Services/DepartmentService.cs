using SaleWebMVC.Data;
using SaleWebMVC.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace SaleWebMVC.Services
{
    public class DepartmentService
    {
        private readonly SaleWebMVCContext _context;

        public DepartmentService(SaleWebMVCContext context)
        {
            _context = context;
        }
        /*
        public List<Department> FindAll() //Começou assim, mas o asyn é pra melhorar a performance da aplicaçao
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        } */
        public async Task<List<Department>> FindAllAsync() //Começou assim, mas o asyn é pra melhorar a performance da aplicaçao
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
