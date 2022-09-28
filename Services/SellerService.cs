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
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
