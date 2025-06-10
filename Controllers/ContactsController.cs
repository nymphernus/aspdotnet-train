using aspdotnet_train.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspdotnet_train.Controllers
{
    public class ContactsController : Controller
    {
        // GET: ContactsController
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check(Contact contact)
        {
            if (ModelState.IsValid)
            {
                return Redirect("/");
            }

            return View("Index");
        }

    }
}
