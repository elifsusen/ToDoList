using MvcToDoList.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcToDoList.DataAccess.Concrete.EntityFramework
{
    public class DatabaseInitializer : CreateDatabaseIfNotExists<ToTheListContext>
    {
        protected override void Seed(ToTheListContext context)
        {
            List<ToTheItem> toTheItems = new List<ToTheItem>()
            {
                new ToTheItem() {Description="item 1" , PlannedDate= DateTime.Now , PlannedHour= DateTime.Now.TimeOfDay  },
                new ToTheItem() {Description="item 2" , PlannedDate= DateTime.Now , PlannedHour= DateTime.Now.TimeOfDay  }
            };
            toTheItems.ForEach(x => context.ToTheItems.Add(x));
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
