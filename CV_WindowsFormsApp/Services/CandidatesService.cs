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
    public class CandidatesService : ICandidates
    {
        private readonly MyDbContext _context;

        public CandidatesService(MyDbContext dbContext) 
        {
            _context = dbContext;
        }
        public Task<Candidate> AddNewCandidate(Candidate candidate)
        {
            throw new NotImplementedException();
            //_context.Candidates.Add(candidate);
            //_context.SaveChanges();
            
        }

        public Task<bool> DeleteCandidate(int candidateIDtoDelete)
        {
            throw new NotImplementedException();
        }

        public Task<Candidate> EditCandidate(Candidate candidate)
        {
            throw new NotImplementedException();
        }

        public Task<Candidate> GetCandidate(int CandidateID)
        {
            throw new NotImplementedException();
            //var result= _context.Candidates.Find(CandidateID);
            //return result;
        }

        public Task<List<Candidate>> GetCandidates()
        {
            throw new NotImplementedException();
            //return _context.Candidates.ToList();
        }
    }
}
