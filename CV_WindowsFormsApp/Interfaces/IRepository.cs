using CV_WindowsFormsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_WindowsFormsApp.Interfaces
{
    public interface IRepository
    {
        IQueryable<List<Candidate>> GetAllCandidatesTest();
    }
}
