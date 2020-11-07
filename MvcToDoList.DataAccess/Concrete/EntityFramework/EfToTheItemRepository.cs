using MvcToDoList.DataAccess.Abstract;
using MvcToDoList.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcToDoList.DataAccess.Concrete.EntityFramework
{
    public class EfToTheItemRepository : EfGenericRepository<ToTheItem> , IToTheItemRepository
    {
       
    }
}
