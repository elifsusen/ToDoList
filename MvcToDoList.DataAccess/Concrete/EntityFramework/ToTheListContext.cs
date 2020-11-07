using MvcToDoList.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcToDoList.DataAccess.Concrete.EntityFramework
{
   public class ToTheListContext : DbContext
    {
        public ToTheListContext() : base("databaseConnection")
        {
            Database.SetInitializer(new DatabaseInitializer());
        }

        public DbSet<ToTheItem> ToTheItems { get; set; }
    }
}
