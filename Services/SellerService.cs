using Microsoft.EntityFrameworkCore;
using SaleWebMVC.Data;
using SaleWebMVC.Models;

namespace SaleWebMVC.Services
{
    public class SellerService
    {
        private readonly SaleWebMVCContext _context;

        public SellerService(SaleWebMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            //obj.Department = _context.Department.First(); N precisa mais pq ta instanciado com departamento agr
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }
        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }

    }
}
