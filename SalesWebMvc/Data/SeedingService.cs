using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums; 

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context; 
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return;
                //DB ja foi populado;
            }

            Department d1 = new Department("Computers");
            Department d2 = new Department("Eletronics");

            /*Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Rodrigo", "rodrigo@gmail.com", new DateTime(1976, 8, 19), 500.0, d2);
            Seller s3 = new Seller(3, "Regiane", "regiane@gmail.com", new DateTime(1983, 1, 7), 3000.0, d1);
            Seller s4 = new Seller(4, "Davi", "davi@gmail.com", new DateTime(2016, 5, 1), 4000.0, d2);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 9, 25), 11000, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 9, 25), 5000, SaleStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 10, 1), 10000, SaleStatus.Billed, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 10, 5), 7000, SaleStatus.Billed, s4);*/

            _context.Department.AddRange(d1, d2);
           // _context.Seller.AddRange(s1, s2, s3, s4);
           // _context.SalesRecord.AddRange(r1, r2, r3, r4);

            _context.SaveChanges();


        }
    }
}
