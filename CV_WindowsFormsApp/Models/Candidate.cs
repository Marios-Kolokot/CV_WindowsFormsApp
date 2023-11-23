using NMemory.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CV_WindowsFormsApp.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        [Required]
        public string LastName {  get; set; }
        [Required]
        public string FirstName { get; set; }
        public string Email {  get; set; }
        public string Mobile {  get; set; }
        public List<Degree> DegreesList { get; set; }
        public string Degree { get; set; }
        public string CVBlob {  get; set; }
        public DateTime MyDateTime { get; set; } = DateTime.Now;

        //public string FormattedDateTime {  get; set; }= MyDateTime.ToString("dd/MM/yyyy hh: mm tt");
    }
}
