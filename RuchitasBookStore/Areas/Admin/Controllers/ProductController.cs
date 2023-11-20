using Microsoft.AspNetCore.Mvc;
using RuchitasBooks.DataAccess.Repository;
using RuchitasBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RuchitasBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly UnitOfWork _unitOfWork;
        public ProductController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id) //action method for upsert
        {
            Category category = new Category();
            if (id == null)
            {
                //this is for create
                return View(category);
            }
            category = _unitOfWork.Category.Get(id.GetValueOrDefault());
            //this is for edit
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Product product)
        {
            if (ModelState.IsValid)
            {
                if (product.Id == 0)
                {
                    _unitOfWork.Product.Add(product);
                }
                else
                {
                    _unitOfWork.Product.Update(product);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        
        //API calls here
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            //return NotFound();
            var allObj = _unitOfWork.Product.GetAll();
            return Json(new { data = allObj });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Product.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.Product.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });
        }
        #endregion

    }
}
