using e_commerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace e_commerce.Controllers
{
    public class SiteUserController : Controller
    {
        Entity context = new Entity();
        // Get All Users
        public IActionResult Index()
        {
            List<Site_User> usersModel = context.SiteUsers.ToList();
            return View(usersModel);
        }

        // Add New SiteUser 

        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveNew(Site_User user)
        {
            if (ModelState.IsValid)
            {
                context.Add(user);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("New",user);
        }

        // Edit SiteUser Info
        public IActionResult Edit(int id)
        {
            Site_User userOldVersion = context.SiteUsers.FirstOrDefault(u => u.Id == id);
            return View(userOldVersion);
        }
        [HttpPost]
        public IActionResult SaveEdit(Site_User user , int id)
        {
            if(ModelState.IsValid)
            {
                Site_User userOldVersion = context.SiteUsers.FirstOrDefault(u=>u.Id == id);
                userOldVersion.EmailAddress = user.EmailAddress;
                userOldVersion.PhoneNumber = user.PhoneNumber;
                userOldVersion.Password = user.Password;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Edit", user);
        }

        // delete user
        public IActionResult Delete(int id)
        {
            Site_User siteUser = context.SiteUsers.FirstOrDefault(u=>u.Id==id);
            if (siteUser != null)
            {
                context.SiteUsers.Remove(siteUser);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}
