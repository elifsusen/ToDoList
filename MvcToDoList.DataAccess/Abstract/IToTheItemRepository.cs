using MvcToDoList.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcToDoList.DataAccess.Abstract
{
    public interface IToTheItemRepository : IRepository<ToTheItem>
    {
    }
}
