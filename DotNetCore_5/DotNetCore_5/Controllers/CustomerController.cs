
using DotNetCore_5.DAL;
using DotNetCore_5.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using X.PagedList;

namespace DotNetCore_5.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {
        private readonly IWebHostEnvironment _iWebHostEnvironment;
        ICustomer _iCustomerRepository;
        public CustomerController(IWebHostEnvironment iWebHostEnvironment, ICustomer icustomerRepository)
        {
            _iWebHostEnvironment = iWebHostEnvironment;
            _iCustomerRepository = icustomerRepository;
        }
        public IActionResult Index(string SearchString, string CurrentFilter, string SortOrder, int? page)
        {
            if (SearchString != null)
            {
                page = 1;
            }
            else
            {
                SearchString = CurrentFilter;
            }
            ViewBag.SortNameParam = string.IsNullOrEmpty(SortOrder) ? "name_desc" : "";
            ViewBag.CurrentFilter = SearchString;
            IEnumerable<CustomerViewModel> list = _iCustomerRepository.GetAll();
            int slNo = 1;
            foreach (var item in list)
            {
                item.SerialNo = slNo++;
            }
            if (!string.IsNullOrEmpty(SearchString))
            {
                list = list.Where(e => e.FirstName.ToUpper().Contains(SearchString.ToUpper())).ToList();
            }
            switch (SortOrder)
            {
                case "name_desc":
                    list = list.OrderByDescending(e => e.Address).ToList();
                    break;
                default:
                    list = list.OrderBy(e => e.Address).ToList();
                    break;
            }
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(list.ToPagedList(pageNumber, pageSize));
            
        }
        [HttpGet]
        public JsonResult GetAll()
        {
            var buildings = _iCustomerRepository.GetAll();
            return Json(buildings, new JsonSerializerOptions());

        }
        [HttpPost]
        public JsonResult Create([FromBody] CustomerViewModel objModel)
        {
            CustomerViewModel returnObj = new CustomerViewModel();
            if (ModelState.IsValid)
            {
                returnObj = _iCustomerRepository.Save(objModel);
            }
            return Json(returnObj.CustomerId, new JsonSerializerOptions());
            //if (ModelState.IsValid)
            //{
            //    string uploadFolder1 = Path.Combine(_iWebHostEnvironment.WebRootPath, "images/customer_images/");
            //    objModel.ImageFullPath = uploadFolder1 + objModel.ImageFullPath;
            //    _iCustomerRepository.Save(objModel);
            //}
            //var data = _iCustomerRepository.GetAll();
            //return Json(data, new JsonSerializerOptions());

        }
        //[HttpGet]
        //public PartialViewResult Edit(int id)
        //{
           
        //    CustomerViewModel customer = _iCustomerRepository.GetById(id);
        //    ViewBag.Details = "Show";
        //    return PartialView("~/Views/Customer/_Edit.cshtml", customer);
        //}
        [HttpPost]
        public JsonResult Edit([FromBody] CustomerViewModel objModel)
        {
            CustomerViewModel returnObj = new CustomerViewModel();
            if (ModelState.IsValid)
            {
                if (objModel.CustomerId > 0)
                {
                    returnObj = _iCustomerRepository.Update(objModel);
                }
            }
            return Json(returnObj.CustomerId, new JsonSerializerOptions());


            //if (ModelState.IsValid)
            //{
            //    if (objModel.CustomerId>0)
            //    {
            //        string uploadFolder1 = Path.Combine(_iWebHostEnvironment.WebRootPath, "images/customer_images/");
            //        objModel.ImageFullPath = uploadFolder1 + objModel.ImageName;
            //        _iCustomerRepository.Update(objModel);
            //    }
            //}
            //var data = _iCustomerRepository.GetAll();
            //return Json(data, new JsonSerializerOptions());

        }


        public JsonResult Delete(int id)
        {

            _iCustomerRepository.Delete(id);
            var data = _iCustomerRepository.GetAll();
            return Json(data, new JsonSerializerOptions());
        }
     
    }
}
