using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;

namespace SalesWebMVC.Data
{
    public static class SeedingService
    {
        public static void Seed(SalesWebMVCContext _context)
        {
            if(_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return;
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");
            Department d5 = new Department(5, "Chemistrty");

            Seller s1 = new Seller(1, "Zed", "shadow@gmail.com", new DateTime(1998, 4, 21), 1000.00, d3);
            Seller s2 = new Seller(2, "Shrek", "ogre@gmail.com", new DateTime(200, 3, 30), 10000.00, d4);
            Seller s3 = new Seller(3, "Marco", "antonio@gmail.com", new DateTime(2004, 5, 31), 1500.00, d2);
            Seller s4 = new Seller(4, "Bentley", "turtle@gmail.com", new DateTime(1980, 2, 8), 2300.00, d1);
            Seller s5 = new Seller(5, "Vanitas", "van@gmail.com", new DateTime(1400, 11, 12), 3000.00, d4);
            Seller s6 = new Seller(6, "Jesse", "pinkman@gmail.com", new DateTime(1984, 11, 24), 5200.00, d5);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(), 11000.00, SaleStatus.Pending, s2);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2023, 1, 23), 6000.00, SaleStatus.Billed, s5);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2022, 7, 12), 7500.00, SaleStatus.Billed, s3);
            SalesRecord sr4 = new SalesRecord(4, new DateTime(2020, 3, 29), 5300.00, SaleStatus.Canceled, s6);
            SalesRecord sr5 = new SalesRecord(5, new DateTime(2023, 8, 7), 12000.00, SaleStatus.Pending, s1);
            SalesRecord sr6 = new SalesRecord(6, new DateTime(2021, 10, 10), 20000.00, SaleStatus.Pending, s2);
            SalesRecord sr7 = new SalesRecord(7, new DateTime(2022, 12, 30), 4000.00, SaleStatus.Billed, s4);
            SalesRecord sr8 = new SalesRecord(8, new DateTime(2023, 12, 20), 6000.00, SaleStatus.Canceled, s4);
            SalesRecord sr9 = new SalesRecord(9, new DateTime(2019, 4, 17), 15000.00, SaleStatus.Billed, s6);
            SalesRecord sr10 = new SalesRecord(10, new DateTime(2020, 9, 28), 10000.00, SaleStatus.Pending, s5);
            SalesRecord sr11 = new SalesRecord(11, new DateTime(2023, 1, 25), 6000.00, SaleStatus.Pending, s3);
            SalesRecord sr12 = new SalesRecord(12, new DateTime(2022, 2, 16), 7900.00, SaleStatus.Billed, s2);
            SalesRecord sr13 = new SalesRecord(13, new DateTime(2023, 5, 14), 6000.00, SaleStatus.Billed, s3);
            SalesRecord sr14 = new SalesRecord(14, new DateTime(2019, 5, 24), 6000.00, SaleStatus.Canceled, s1);
            SalesRecord sr15 = new SalesRecord(15, new DateTime(), 6000.00, SaleStatus.Billed, s3);

            _context.Department.AddRange(d1, d2, d3, d4, d5);
            _context.Seller.AddRange(s1, s2, s3, s4, s5);
            _context.SalesRecord.AddRange(
                sr1, sr2, sr3, sr4, sr5,
                sr6, sr7, sr8, sr9, sr10,
                sr11, sr12, sr13, sr14, sr15
            );

            _context.SaveChanges();
        }
    }
}
