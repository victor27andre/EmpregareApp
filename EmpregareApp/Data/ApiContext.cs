using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmpregareApp.Models;
using System.Web;

// Context vai encapsular todas as propriedades
namespace EmpregareApp.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }

    }
}
