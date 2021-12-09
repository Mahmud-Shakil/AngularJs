using DotNetCore_5.DAL;
using DotNetCore_5.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static DotNetCore_5.DAL.Repositories;

namespace DotNetCore_5.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class FileUploadController : ControllerBase
    {
        private readonly IWebHostEnvironment iWebHostEnvironment;
        ICustomer _iCustomerRepository;
        public FileUploadController(IWebHostEnvironment _iWebHostEnvironment, ICustomer iCustomerRepository)
        {
            iWebHostEnvironment = _iWebHostEnvironment;
            _iCustomerRepository = iCustomerRepository;
        }
        [Route("api/FileUpload/UploadFiles")]
        [HttpPost]
        public IActionResult UploadFiles(int id)
        {
            IFormFile photo = null;
            string uniqueImageName = null;
            var files = HttpContext.Request.Form.Files;
            foreach (IFormFile Photo in HttpContext.Request.Form.Files)
            {
                photo = Photo;
            }
            CustomerViewModel obj = _iCustomerRepository.GetById(id);
            if (photo != null)
            {
                string uploadFolder = Path.Combine(iWebHostEnvironment.WebRootPath, "images/customer_images");
                string uploadFolder1 = Path.Combine(iWebHostEnvironment.WebRootPath, "images/customer_images/");
                uniqueImageName = Guid.NewGuid().ToString() + "_" + photo.FileName;
                string filePath = Path.Combine(uploadFolder, uniqueImageName);
                FileStream fileStream = new FileStream(filePath, FileMode.Create);
                photo.CopyTo(fileStream);
                fileStream.Close();
                obj.ImageName = uniqueImageName;
                obj.ImageFullPath = uploadFolder1 + obj.ImageName;
                _iCustomerRepository.Update(obj);
            }
             var customer = _iCustomerRepository.GetAll();

            //IFormFile Photo = null;

            //string uniqueImageName = null;
            //var files = HttpContext.Request.Form.Files;
            //foreach (IFormFile photo in HttpContext.Request.Form.Files)
            //{
            //    Photo = photo;

            //}
            //if (Photo != null)
            //{
            //    string uploadFolder = Path.Combine(iWebHostEnvironment.WebRootPath, "images/customer_images");

            //    uniqueImageName = Photo.FileName;
            //    string filePath = Path.Combine(uploadFolder, uniqueImageName);
            //    FileStream fileStream = new FileStream(filePath, FileMode.Create);
            //    Photo.CopyTo(fileStream);
            //    fileStream.Close();

            //}


            return Ok(customer);
        }
        [Route("api/FileUpload/UploadVehicelFiles")]
        [HttpPost]
        public IActionResult UploadVehicelFiles()
        {
            IFormFile Photo = null;

            string uniqueImageName = null;
            var files = HttpContext.Request.Form.Files;
            foreach (IFormFile photo in HttpContext.Request.Form.Files)
            {
                Photo = photo;

            }
            if (Photo != null)
            {
                string uploadFolder = Path.Combine(iWebHostEnvironment.WebRootPath, "images/vehicel_images");
               
                uniqueImageName = Photo.FileName;
                string filePath = Path.Combine(uploadFolder, uniqueImageName);
                FileStream fileStream = new FileStream(filePath, FileMode.Create);
                Photo.CopyTo(fileStream);
                fileStream.Close();

            }
            ////Create the Directory.
            //string path = HttpContext.Current.Server.MapPath("~/Uploads/");
            //if (!Directory.Exists(path))
            //{
            //    Directory.CreateDirectory(path);
            //}

            ////Save the Files.
            //foreach (string key in HttpContext.Current.Request.Files)
            //{
            //    HttpPostedFile postedFile = HttpContext.Current.Request.Files[key];
            //    postedFile.SaveAs(path + postedFile.FileName);
            //}

            //Send OK Response to Client.

            return Ok();
        }
    }
}
