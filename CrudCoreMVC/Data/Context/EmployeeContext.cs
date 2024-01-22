using CrudCoreMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudCoreMVC.Data.Context
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
        }

        public DbSet<EmployeeModel> Emp { get; set; }
    }
}
