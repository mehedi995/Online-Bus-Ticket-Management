using System;
using BTMEntity;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMRepository
{
    class DataContext : DbContext
    {
        //public DbSet<Department> Departments { get; set; }
        //public DbSet<Employee> Employees { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<SpecialUser> SpecialUsers { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
    }
}
