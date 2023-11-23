using CV_WindowsFormsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_WindowsFormsApp.Interfaces
{
    public interface IDegrees
    {
        Task<Degree> GetDegree(int DegreeID);
        Task<List<Degree>> GetDegrees();

        Task<Degree> AddNewDegree(Degree degree);

        Task<Degree> EditDegree(Degree degree);

        Task<bool> DeleteDegree(int degreeIDtoDelete);
    }
}
