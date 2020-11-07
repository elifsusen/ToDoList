using MvcToDoList.Business.Abstract;
using MvcToDoList.DataAccess.Abstract;
using MvcToDoList.DataAccess.Concrete.EntityFramework;
using MvcToDoList.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcToDoList.Business.Concrete
{
    public class ToTheItemManager : IToTheItemService
    {
        private IToTheItemRepository _toTheItemRepo;

        public ToTheItemManager(IToTheItemRepository toTheItemRepo)
        {
            _toTheItemRepo = toTheItemRepo;
        }

        public void Create(ToTheItem entity)
        {
            _toTheItemRepo.Create(entity);
        }

        public void Delete(ToTheItem entity)
        {
            _toTheItemRepo.Delete(entity);
        }

        public List<ToTheItem> GetAll()
        {
            return _toTheItemRepo.GetAll().ToList();
        }

        public ToTheItem GetById(int id)
        {
            return _toTheItemRepo.GetById(id);
        }

        public void Update(ToTheItem entity)
        {
            _toTheItemRepo.Update(entity);
        }
    }
}
