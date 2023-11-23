using CV_WindowsFormsApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_WindowsFormsApp.DataBaseContext
{
    public class MyDbContext : DbContext
    {
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<Candidate> Candidates { get; set; }




    }
}
