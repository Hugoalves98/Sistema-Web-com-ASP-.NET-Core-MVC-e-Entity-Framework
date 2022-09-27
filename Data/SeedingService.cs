using SaleWebMVC.Models;

namespace SaleWebMVC.Data
{
    public class SeedingService
    {
        private SaleWebMVCContext _context;

        public SeedingService(SaleWebMVCContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if(_context.Department.Any() || 
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; // BD has been seeded, populado já
            }
            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "eLetronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Ebooks");

            Seller s1 = new Seller(1, "Mike", "mike@target.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Maria", "maria@target.com", new DateTime(1979, 12, 31), 3500.0, d2);
            Seller s3 = new Seller(3, "Alex", "alex@target.com", new DateTime(1988, 1, 15), 2200.0, d1);
            Seller s4 = new Seller(4, "Martha", "martha@target.com", new DateTime(1993, 11, 30), 3000.0, d1);
            Seller s5 = new Seller(5, "Donald", "donald@target.com", new DateTime(2000, 1, 9), 4000.0, d3);
            Seller s6 = new Seller(6, "Lexa", "lexa@target.com", new DateTime(1997, 3, 4), 3000.0, d2);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, Models.Enums.SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 10, 5), 5000.0, Models.Enums.SaleStatus.Pending, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 08, 15), 4000.0, Models.Enums.SaleStatus.Billed, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 06, 4), 1000.0, Models.Enums.SaleStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2018, 05, 20), 6000.0, Models.Enums.SaleStatus.Billed, s5);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5);
            _context.SaveChanges();
        }
    }
}
