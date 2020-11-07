
using MvcToDoList.Business.Abstract;
using MvcToDoList.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MvcToDoList.WebUI.Controllers
{
    public class ToTheItemController : Controller
    {
        private IToTheItemService _toTheItemService;
        

        public ToTheItemController(IToTheItemService toTheItemService)
        {
            _toTheItemService = toTheItemService;
        }

        // GET: ToTheItem
        public ActionResult Index()
        {
            var model = _toTheItemService.GetAll();
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ToTheItem toTheItem)
        {
            _toTheItemService.Create(toTheItem);
            return RedirectToAction("Index");
        }


        public ActionResult Delete(int id)
        {
            ToTheItem toTheItem = _toTheItemService.GetById(id);
            if (toTheItem != null)
            {
                _toTheItemService.Delete(toTheItem);
            }
           
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ToTheItem toTheItem = _toTheItemService.GetById((int)id);
            if (toTheItem == null)
            {
                return HttpNotFound();
            }
            return View(toTheItem);
        }

        [HttpPost]
        public ActionResult Edit(ToTheItem toTheItem)
        {
            _toTheItemService.Update(toTheItem);
            return RedirectToAction("Index");
        }
    }
}