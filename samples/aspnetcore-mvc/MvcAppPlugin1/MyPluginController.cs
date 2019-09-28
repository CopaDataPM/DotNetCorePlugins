using Microsoft.AspNetCore.Mvc;

namespace MvcAppPlugin1
{
    public class MyPluginController : Controller
    {
        public IActionResult Index()
        {
            return View(new MessageModel
            {
                Message = "Hello from .NET Core Plugin 1!"
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind] MessageModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Thing", "Invalid message");
            }
            return View(model);
        }
    }
}
