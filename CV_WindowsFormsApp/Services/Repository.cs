using CV_WindowsFormsApp.DataBaseContext;
using CV_WindowsFormsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_WindowsFormsApp.Services
{
    public class Repository
    {
        private readonly MyDbContext _context;

        public Repository(MyDbContext context)
        {
            _context = context;
        }

        public IQueryable<List<Candidate>> GetAllCandidatesTest()
        {
            return (IQueryable<List<Candidate>>)_context.Set<Candidate>().ToList();
        }

    }
}
