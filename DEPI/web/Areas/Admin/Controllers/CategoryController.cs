using DataAccess.Data;
using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace web.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var CategoryListModel = _unitOfWork.Category.GetAll();
            return View(CategoryListModel);
        }

        public IActionResult Create()
        {
            //return View(new Category()); wasn't needed with tag helper
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveCreate(Category category)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Category.Add(category);
                _unitOfWork.Save();
                TempData["success"] = "Category Created Successfully";
                return RedirectToAction("Index");
            }
            return View("Create", category);
        }
        public IActionResult Edit(int id)
        {
            var categoryModel = _unitOfWork.Category.Get(c => c.Id == id);
            return View(categoryModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveEdit(Category category, int id)
        {
            if (ModelState.IsValid)
            {
                var oldCategory = _unitOfWork.Category.Get(c => c.Id == id);
                oldCategory.Name = category.Name;
                oldCategory.DisplayOrder = category.DisplayOrder;
                _unitOfWork.Save();
                TempData["success"] = "Category Updated Successfully";
                return RedirectToAction("Index");
            }
            return View("Edit", category);
        }

        public IActionResult Delete(int id)
        {
            var categoryModel = _unitOfWork.Category.Get(c => c.Id == id);
            return View(categoryModel);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var targetCategory = _unitOfWork.Category.Get(c => c.Id == id);

            _unitOfWork.Category.Remove(targetCategory);
            _unitOfWork.Save();
            TempData["success"] = "Category Deleted Successfully";
            return RedirectToAction("Index");
        }
    }
}
