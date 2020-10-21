using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    // OLD DATA CONTEXT -> NEW DATA CONTEXT = WickedAirSourceContextDupe
    public class WickedAirSourceContext :DbContext
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            //optionsBuilder.UseSqlServer("Server = HIDDEN; Initial Catalog = wickedair; User Id = HIDDEN; Password = HIDDEN"); // now redundant only used for scaffolding the remote db to models
            base.OnConfiguring(optionsBuilder);

        }


    }
}
