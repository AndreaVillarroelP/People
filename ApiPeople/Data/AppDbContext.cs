using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiPeople.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiPeople.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<Person> People { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)// enlaza nuestra base de datos con el EntityFramework
        {

        }
    }
}
