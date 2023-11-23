using CV_WindowsFormsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_WindowsFormsApp.Interfaces
{
    public interface ICandidates
    {
        Task<Candidate> GetCandidate(int CandidateID);
        Task<List<Candidate>> GetCandidates();

        Task<Candidate> AddNewCandidate(Candidate candidate);

        Task<Candidate> EditCandidate(Candidate candidate);

        Task<bool> DeleteCandidate(int candidateIDtoDelete);
    }
}
