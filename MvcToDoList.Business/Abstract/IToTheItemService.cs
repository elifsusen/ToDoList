using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcToDoList.Entities;


namespace MvcToDoList.Business.Abstract
{
    public interface IToTheItemService
    {
        ToTheItem GetById(int id);
        List<ToTheItem> GetAll();
        void Create(ToTheItem entity);
        void Update(ToTheItem entity);
        void Delete(ToTheItem entity);
    }
}
