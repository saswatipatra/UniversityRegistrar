using Microsoft.AspNetCore.Mvc;
using Registrar.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Registrar.ViewModels;
using Microsoft.AspNetCore.Hosting;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Registrar.Controllers
{
    public class CoursesController : Controller
    {
        private readonly RegistrarContext _db;
        private readonly IHostingEnvironment hostingEnvironment;

        public CoursesController(RegistrarContext db, IHostingEnvironment hostingEnvironment)
        {
            _db = db;
            this.hostingEnvironment = hostingEnvironment;
        }

        public ActionResult Index()
        {
            List<Course> model = _db.Courses.ToList();
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(RegistrarCreateViewModel model)
        {   
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;

                // If the Photo property on the incoming model object is not null, then the user
                // has selected an image to upload.
                if (model.Photo != null)
                {
                    // The image must be uploaded to the images folder in wwwroot
                    // To get the path of the wwwroot folder we are using the inject
                    // HostingEnvironment service provided by ASP.NET Core
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    Console.WriteLine(uploadsFolder);
                    // To make sure the file name is unique we are appending a new
                    // GUID value and and an underscore to the file name
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    Console.WriteLine(filePath);
                    // Use CopyTo() method provided by IFormFile interface to
                    // copy the file to wwwroot/images folder
                    model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                Course newCourse = new Course
                {
                    Name = model.Name,
                    // Store the file name in PhotoPath property of the Course object
                    // which gets saved to the Courses database table
                    Image = uniqueFileName
                };  
                 _db.Courses.Add(newCourse);
                _db.SaveChanges();  
        }
        
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var thisCourse = _db.Courses
                .Include(course => course.Students)
                .ThenInclude(join => join.Student)
                .FirstOrDefault(course => course.CourseId == id);
            return View(thisCourse);
        }
        public ActionResult Edit(int id)
        {
            var thisCourse = _db.Courses.FirstOrDefault(Courses => Courses.CourseId == id);
            return View(thisCourse);
        }

        [HttpPost]
        public ActionResult Edit(Course course)
        {
            _db.Entry(course).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult Delete(int id)
        {
            var thisCourse = _db.Courses.FirstOrDefault(courses => courses.CourseId == id);
            return View(thisCourse);
        }


        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var thisCourse = _db.Courses.FirstOrDefault(courses => courses.CourseId == id);

            _db.Courses.Remove(thisCourse);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}