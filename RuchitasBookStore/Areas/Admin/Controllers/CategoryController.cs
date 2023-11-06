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
    public class CategoryController : Controller
    {
        private readonly UnitOfWork _unitOfWork;
        public CategoryController(UnitOfWork unitOfWork)
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
            if(id == null)
            {
                //this is for create
                return View(category);
            }

            //this is for edit
            if(category == null)
            {
                return NotFound();
            }
            return View();
        }

        //API calls here
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            //return NotFound();
            var allObj = _unitOfWork.Category.GetAll();
            return Json(new { data = allObj });
        }
        #endregion
    }
}
