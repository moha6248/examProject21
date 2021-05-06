using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore

namespace examProject21.Models
{
    public class ConnectionStringClass:DbContext
    {
        public ConnectionStringClass(DbContextOptions<ConnectionStringClass> options):(options)
        {

        }

        public DbSet<ExamClass> Sheet1$ { get; set; }

    }
}
