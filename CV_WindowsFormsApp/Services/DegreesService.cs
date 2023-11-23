using CV_WindowsFormsApp.DataBaseContext;
using CV_WindowsFormsApp.Interfaces;
using CV_WindowsFormsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_WindowsFormsApp.Services
{
    public class DegreesService : IDegrees
    {
        private readonly MyDbContext _context;

        public DegreesService(MyDbContext dbContext)
        {
            _context = dbContext;
        }

        public Task<Degree> AddNewDegree(Degree degree)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteDegree(int degreeIDtoDelete)
        {
            throw new NotImplementedException();
        }

        public Task<Degree> EditDegree(Degree degree)
        {
            throw new NotImplementedException();
        }

        public Task<Degree> GetDegree(int DegreeID)
        {
            throw new NotImplementedException();
        }

        public Task<List<Degree>> GetDegrees()
        {
            throw new NotImplementedException();
        }
    }
}
