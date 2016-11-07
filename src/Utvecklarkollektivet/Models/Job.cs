using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Utvecklarkollektivet.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Keywords { get; set; }
        public string Description { get; set; }
        public string ApplyDescription { get; set; }
        public string Company { get; set; }
        public string CompanyLocation { get; set; }
        public string CompanyUrl { get; set; }
        public string CompanyEmail { get; set; }

        public string Location { get; set; }
        public bool Remote { get; set; }
        public string Salary { get; set; }
        public bool HightLight { get; set; }

    }
}
