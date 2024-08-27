using Microsoft.AspNetCore.Mvc;
using System;

namespace InAndOut.Controllers
{
    public class ReturnTypeController : Controller
    {
      
        #region :: Redirect Result ::       
        /// <summary>
        /// Rediret to specified string URL with permanent 301 property set to false
        /// </summary>    
        /// <return></return>
        public IActionResult RedirectResult()
        {
            return Redirect("https://www.google.com");
        }

        #endregion

        #region :: Redirect To Action Result ::       
        /// <summary>
        /// RediretToActionResult can redirect us to an action.
        /// It takes in the action name, controller name, and route value.
        /// </summary>    
        /// <return></return>
        public IActionResult RedirectToActionResult()
        {
            return RedirectToAction("target","Appointment");
        }

        #endregion

        #region :: File Result ::       
        /// <summary>
        /// Returns the file content as pdf content.
        /// </summary>    
        /// <return></return>
        public IActionResult FileResult()
        {
            return File("~/download/pdf-sample.pdf", "application/pdf");
        }

        #endregion

        #region :: Virtual File Result ::       
        /// <summary>
        /// Use VirtualFileResult if you want to read a file form
        /// a virtual address and return it.
        /// </summary>    
        /// <return></return>
        public IActionResult VirtualFileResult()
        {
            //Paths given to the VirtualFileResult are relative
            //to the wwwroot folder. 
            return new VirtualFileResult
                ("/dowload/pdf-sample.pdf", "application/pdf");
        }

        #endregion

        #region :: Content Result ::       
        /// <summary>
        /// It renders a specified view to the response stream.
        /// </summary>    
        /// <return></return>
        public IActionResult Index()
        {
            return View();
        }

        #endregion

        #region :: Partial View Result ::       
        /// <summary>
        /// Renders a specifed partial view to the response stream.
        /// </summary>    
        /// <return></return>
        public IActionResult PartialViewResult()
        {
            return PartialView();
        }

        #endregion

        #region :: Json Result ::       
        /// <summary>
        /// Return JsonResult (JavaScript Object Notation result)
        /// </summary>    
        /// <return></return>
        public IActionResult JsonResult()
        {
            return Json(new
            { 
                message = "This is a JSON result.",
                date = DateTime.Now
            });
        }

        #endregion

    }
}
