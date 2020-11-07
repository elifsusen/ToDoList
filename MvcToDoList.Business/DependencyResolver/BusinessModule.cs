using MvcToDoList.Business.Abstract;
using MvcToDoList.Business.Concrete;
using MvcToDoList.DataAccess.Abstract;
using MvcToDoList.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcToDoList.Business.DependencyResolver
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IToTheItemService>().To<ToTheItemManager>().InSingletonScope();
            Bind<IToTheItemRepository>().To<EfToTheItemRepository>().InSingletonScope();
        }
    }
}
