using e_commerce.Models;
using e_commerce.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace e_commerce.Controllers
{
    public class SiteUserController : Controller
    {

        private readonly ISiteUserService _userService;
        public SiteUserController(ISiteUserService userService)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }


        public async Task<IActionResult> Index()
        {
            var users = await _userService.GetAllUsers();
            return View(users);
        }

        //  SiteUser Details
        public async Task<IActionResult> Details(int id)
        {
            var user = await _userService.GetUserById(id);
            if (user == null) return NotFound();
            return View(user);
        }

        //// Add New SiteUser 

        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveNew(Site_User user)
        {
            if (ModelState.IsValid)
            {
                await _userService.AddUser(user);
                return RedirectToAction("Index");
            }
            return View("New",user);
        }

        // Edit SiteUser Info
        public async Task<IActionResult> Edit(int id)
        {
            var user = await _userService.GetUserById(id);
            if (user == null) return NotFound();
            return View(user);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveEdit(Site_User user , int id)
        {
            if (id != user.Id) return BadRequest();
            if (ModelState.IsValid)
            {
                await _userService.UpdateUser(user);
                return RedirectToAction("Index");
            }
            return View("Edit", user);
        }

        // Delete user
        public async Task<IActionResult> Delete(int id)
        {
            var user = await _userService.GetUserById(id);
            if (user == null) return NotFound();
            return View(user);
        }

        // Delete Confirmed ( delete it from data base )
        //[HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _userService.DeleteUser(id);
            return RedirectToAction("Index");
        }


        //// delete user
        //public IActionResult Delete(int id)
        //{
        //    Site_User siteUser = context.SiteUsers.FirstOrDefault(u=>u.Id==id);
        //    if (siteUser != null)
        //    {
        //        context.SiteUsers.Remove(siteUser);
        //        context.SaveChanges();
        //    }
        //    return RedirectToAction("Index");
        //}

    }
}
