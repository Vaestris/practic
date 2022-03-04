using System;
using Microsoft.EntityFrameworkCore;


namespace internet_shop_test2
{
    public class ProgramContext : DbContext
    {
        public DbSet<customer> customers { get; set; }
        public DbSet<order> orders { get; set; }
        public DbSet<product> products { get; set; }
        public DbSet<delivery> deliveries { get; set; }
        public ProgramContext()
        {
            Database.EnsureCreated();
        }

        //private const string connectionstring = @"Server=.\MSSQLSERVER;Database=internet_shop_test;Trusted_Connection=True;";
        private const string connectionstring = @"Server=(localdb)\mssqllocaldb;Database=internet_sop_test;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionstring);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<customer>().HasKey(u => u.phone_number);
            modelBuilder.Entity<order>().HasKey(u => u.order_number);
            modelBuilder.Entity<product>().HasKey(u => u.product_number);
            modelBuilder.Entity<delivery>().HasNoKey();
            //modelBuilder.Entity<customer>().HasNoKey();
            //modelBuilder.Entity<order>().HasNoKey();
            //modelBuilder.Entity<product>().HasNoKey();
            //modelBuilder.Entity<product>().Property(et => et.product_number).ValueGeneratedNever();
            // использование Fluent API
            base.OnModelCreating(modelBuilder);
        }
    }


    public class customer
    {
        public int phone_number { get; set; }
        public char fname { get; set; }
        public char lname { get; set; }
        public char company { get; set; }

    }
    public class order
    {
        public int phone_number { get; set; }
        public int order_number { get; set; }
        public int product_number { get; set; }

    }
    public class product
    {
        public int product_number { get; set; }
        public int existence { get; set; }
        public string name { get; set; }
    }
    public class delivery
    {
        public int order_number { get; set; }
        public bool shipment { get; set; }
        public bool issued { get; set; }
        public bool delivered { get; set; }
        public DateTime time { get; set; }

    }
}