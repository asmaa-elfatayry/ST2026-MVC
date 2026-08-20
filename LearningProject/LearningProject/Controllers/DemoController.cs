using Microsoft.AspNetCore.Mvc;

namespace LearningProject.Controllers
{
    public class DemoController : Controller
    {

        #region return results

        // content - string 
        // Demo/GetContent
        //public ContentResult GetContent()
        //{
        //    var Contente = new ContentResult();
        //    Contente.Content = "hi mvc";
        //    return Contente;
        //}
        public ContentResult GetContent()
        {
            return Content("hi mvc");
        }

        // json

        public JsonResult GetJson()
        {
            return Json(new { Msg = "Hi MVC" });

        }

        // redirect action 

        public RedirectToActionResult GetRedirect()
        {
            return RedirectToAction("GetJson", "Demo");
        }
        // redirect

        public RedirectResult GetRedirectToExternal()
        {
            return Redirect("https://www.google.com");
        }
        // view 

        public ViewResult GetView()
        {
            int x = 2;
            return View("Home", x);  // view name + model 
            /* return View(x); */   // model 
                                    //return View();   // view name == action name 
                                    //return View("Home"); // view name
        }

        public IActionResult OddNumber(int id)
        {
            if (id % 2 == 0)
            {
                return Content("even ");

            }
            else
            {
                return Json(new { Msg = "Odd" });
            }
        }
        #endregion

        #region binding 

        //public IActionResult Home(int x ,string name ) // default 
        //{
        //    return Content("Home");
        //}

        //[Route("Demo/Home/{id}/{name}")]
        //public IActionResult Home(int id, string name) // default 
        //{
        //    return Content("Home");
        //}
        //[Route("Demo/Home/{x}")]
        //public IActionResult Home(int x) 
        //{
        //    return Content("Home");
        //}


        //public IActionResult Home(Student student)
        //{
        //    return Content("Home");
        //}

        public IActionResult BindArray(string[] Names)
        {
            return Content("Home");
        }
        #endregion


        public IActionResult Home()
        {
            return View();
        }

    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
