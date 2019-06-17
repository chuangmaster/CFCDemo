using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFCDemo
{
    public class KTStoreEntities : DbContext
    {
        public KTStoreEntities():base("name=KTStoreModelConn")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Product { get; set; }
    }
}
