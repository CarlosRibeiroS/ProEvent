using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProEvents.API.models;

namespace ProEvents.API.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Event> Events { get; set; }

        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
        }
    }
}