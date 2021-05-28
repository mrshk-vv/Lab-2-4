using DomainModel.Models;
using DomainModel.Storage;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class ResettlementController : Controller
    {
        // GET: ResettlementController
        public ActionResult Index()
        {
            if(Storage.Instance.db.Students.Count == 0)
                return RedirectToAction("Index", "Student");
            else if(Storage.Instance.db.Rooms.Count == 0)
                RedirectToAction("Index", "Room");

            return View(Storage.Instance.db.Resettlements);
        }

        // GET: ResettlementController/Create
        public ActionResult Create()
        {
            return View(new Resettlement());
        }

        // POST: ResettlementController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Resettlement entity)
        {
            try
            {
                Storage.Instance.db.Resettlements.Add(entity);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ResettlementController/Edit/5
        public ActionResult Edit(int id)
        {
            if (Storage.Instance.db.Resettlements.Any(x => x.Id == id))
            {
                var resettlement = Storage.Instance.db.Resettlements.FirstOrDefault(x => x.Id == id);
                return View(resettlement);
            }

            return View(new Resettlement());
        }

        // POST: ResettlementController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Resettlement entity)
        {
            try
            {
                if (id != entity.Id || !Storage.Instance.db.Resettlements.All(x => x.Id == id))
                    throw new Exception("Ressetlement doesnt exist");

                ;
                foreach (var resettlement in Storage.Instance.db.Resettlements)
                {
                    if (resettlement.Id == entity.Id)
                    {
                        resettlement.GradeBookNumber = entity.GradeBookNumber;
                        resettlement.HostelNumber = entity.HostelNumber;
                        resettlement.RoomId = entity.RoomId;
                    }
                }


                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: ResettlementController/Delete/5
        public ActionResult Delete(int id)
        {
            var resettlement = Storage.Instance.db.Resettlements.FirstOrDefault(x => x.Id == id);
            if (resettlement != null)
            {
                Storage.Instance.db.Resettlements.Remove(resettlement);
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
