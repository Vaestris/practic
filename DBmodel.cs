using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace internet_shop_test2
{
    public class ProgramContext : DbContext
    {
       // public DbSet<customer> Customers { get; set; }
       // public DbSet<order> Orders { get; set; }
        public DbSet<product> Products { get; set; }
       // public DbSet<delivery> Deliveries { get; set; }
        public ProgramContext()
        {
            Database.EnsureCreated();
        }

        //private const string connectionstring = @"Server=.\MSSQLSERVER;Database=internet_shop_test;Trusted_Connection=True;";
        private const string connectionstring = @"Server=DESKTOP-8HTVICI;Database=internet_sop_test;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionstring);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
           // modelBuilder.Entity<customer>().HasKey(u => u.phone_number);
           // modelBuilder.Entity<order>().HasKey(u => u.id_order);
           // modelBuilder.Entity<order>().HasOne(p => p.customer).WithMany(b => b.Orders).HasForeignKey(p => p.phone_number);
            modelBuilder.Entity<product>().HasKey(u => u.id);
           // modelBuilder.Entity<delivery>().HasNoKey();
            //modelBuilder.Entity<Department>().Property(t => t.Name).IsRequired();
            //modelBuilder.Entity<customer>().HasNoKey();
            //modelBuilder.Entity<order>().HasNoKey();
            //modelBuilder.Entity<product>().HasNoKey();
            //modelBuilder.Entity<product>().Property(et => et.product_number).ValueGeneratedNever();
            // использование Fluent API
            base.OnModelCreating(modelBuilder);
        }
    }


   /* public class customer
    {
        public int phone_number { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string company { get; set; }

        public List<order> Orders { get; set; }

    }
    public class order
    {
        
        public int id_order { get; set; }
        public int product_number { get; set; }
        public int phone_number { get; set; }//внещний ключ

        public customer customer { get; set; }//навигационные свойство 

    }*/
    public class product
    {
        public int id { get; set; }
        public int product_number { get; set; }
        public int existence { get; set; }
        public string name { get; set; }
    }
  /*  public class delivery
    {
        public int order_number { get; set; }
        public bool shipment { get; set; }
        public bool issued { get; set; }
        public bool delivered { get; set; }
        public DateTime time { get; set; }

    }*/
}