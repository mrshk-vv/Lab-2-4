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
    public class RoomController : Controller
    {
        // GET: RoomsController
        public ActionResult Index()
        {
            return View(Storage.Instance.db.Rooms);
        }

        // GET: RoomsController/Create
        public ActionResult Create()
        {
            return View(new Room());
        }

        // POST: RoomsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Room entity)
        {
            try
            {
                Storage.Instance.db.Rooms.Add(entity);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoomsController/Edit/5
        public ActionResult Edit(int id)
        {
            if (Storage.Instance.db.Rooms.Any(x => x.Id == id))
            {
                var room = Storage.Instance.db.Rooms.FirstOrDefault(x => x.Id == id);
                return View(room);
            }

            return View(new Room());
        }

        // POST: RoomsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Room entity)
        {
            try
            {
                if (id != entity.Id || !Storage.Instance.db.Rooms.All(x => x.Id == id))
                    throw new Exception("Room doesnt exist");

                ;
                foreach (var room in Storage.Instance.db.Rooms)
                {
                    if (room.Id == entity.Id)
                    {
                        room.RoomNumber = entity.RoomNumber;
                        room.Capacity = entity.Capacity;
                        room.HostelNumber = entity.HostelNumber;
                        room.FloorNumber = entity.FloorNumber;
                    }
                }


                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: RoomsController/Delete/5
        public ActionResult Delete(int id)
        {
            var room = Storage.Instance.db.Rooms.FirstOrDefault(x => x.Id == id);
            if (room != null)
            {
                Storage.Instance.db.Rooms.Remove(room);
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
