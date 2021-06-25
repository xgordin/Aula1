using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Aula1.Models;

namespace Aula1.Context
{
    public class Aula1Context:DbContext
    {
        
        public Aula1Context()
        : base("Aula1Context") { 

                    }
        public DbSet<Cliente> Cliente { get; set; }
    }
}
