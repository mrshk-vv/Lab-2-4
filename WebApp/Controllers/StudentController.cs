using DomainModel.Models;
using DomainModel.Storage;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace WebApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: StudentController
        public ActionResult Index()
        {
            return View(Storage.Instance.db.Students);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View(new Student());
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student entity)
        {
            try
            {
                Storage.Instance.db.Students.Add(entity);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            if(Storage.Instance.db.Students.Any(x => x.Id == id))
            {
                var student = Storage.Instance.db.Students.FirstOrDefault(x => x.Id == id);
                return View(student);
            }

            return View(new Student());

        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Student entity)
        {
            try
            {
                if (id != entity.Id || !Storage.Instance.db.Students.All(x => x.Id == id))
                    throw new Exception("Student doesnt exist");

                ;
                foreach (var student in Storage.Instance.db.Students)
                {
                    if(student.Id == entity.Id)
                    {
                        student.Name = entity.Name;
                        student.Surname = entity.Surname;
                        student.Patronymic = entity.Patronymic;
                        student.GroupNumber = entity.GroupNumber;
                    }
                }
                

                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            var student = Storage.Instance.db.Students.FirstOrDefault(x => x.Id == id);
            if (student != null)
            {
                Storage.Instance.db.Students.Remove(student);
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
