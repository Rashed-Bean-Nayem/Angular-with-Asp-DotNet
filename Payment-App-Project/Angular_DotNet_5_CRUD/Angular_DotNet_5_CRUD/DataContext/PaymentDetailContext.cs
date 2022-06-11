using Angular_DotNet_5_CRUD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_DotNet_5_CRUD.DataContext
{
    public class PaymentDetailContext:DbContext
    {
        public PaymentDetailContext(DbContextOptions<PaymentDetailContext> options):base(options) 
        {
        
        
        }
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
}
