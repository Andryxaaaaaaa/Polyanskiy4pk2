using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
     internal class DataContext : DbContext 
    {
        //public DataContext()
        //{
        //    Database.EnsureCreated();
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=192.168.147.50\\MSSQL2;Initial Catalog=База_ДанныхИу;User ID=pk;Password=1;");
        }
        public DbSet <Income> Income { get; set; }
    }
}
