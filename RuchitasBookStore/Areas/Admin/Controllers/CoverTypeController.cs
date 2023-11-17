using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RuchitasBooks.DataAccess.Repository;
using RuchitasBooks.Models;

namespace RuchitasBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CoverTypeController : Controller
    {
        private readonly UnitOfWork _unitOfWork;
        public CoverTypeController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id) //action method for upsert
        {
            CoverType covertype = new CoverType();
            if (id == null)
            {
                //this is for create
                return View(covertype);
            }
            covertype = _unitOfWork.Covertype.Get(id.GetValueOrDefault());
            //this is for edit
            if (covertype == null)
            {
                return NotFound();
            }
            return View(covertype);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(CoverType covertype)
        {
            if (ModelState.IsValid)
            {
                if (covertype.Id == 0)
                {
                    _unitOfWork.Covertype.Add(covertype);
                }
                else
                {
                    _unitOfWork.Covertype.Update(covertype);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(covertype);
        }

        //API calls here
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            //return NotFound();
            var allObj = _unitOfWork.Covertype.GetAll();
            return Json(new { data = allObj });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Covertype.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.Covertype.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });
        }
        #endregion
    }
}
