using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace utvecklarkollektivet.Models
{
    public class UtvecklarkollektivetDb : DbContext
    {
        public UtvecklarkollektivetDb() : base("name=DefaultConnection")
        {
        }

        public DbSet<SlackRequest> SlackRequests { get; set; }
    }
}