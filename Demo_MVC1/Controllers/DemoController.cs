using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using System.Text;

namespace Demo_MVC1.Controllers
{
    public class DemoController : Controller
    {
        //  IActionResult Demo
        public IActionResult Index()
        {
            return View();
        }
        //ViewResult Demo
        public ViewResult Index1()
        {
            return View("Index1");
        }


        //EmptyResult Demo
        public EmptyResult Index2()
        {
            return Empty;
        }

        //RedirectResult 
        public RedirectResult Index3()
        {
            return Redirect("http://www.eenadu.net");

           
        }

        //RedirectToActionResult Demo
        public RedirectToActionResult Index4()
        {

           int n = 11;
            if(n%2==0)
            {
               return  RedirectToAction("Even", "Demo");
            }
            else
            {
               return RedirectToAction("Odd", "Demo");
            } 
           
        }
        public ViewResult Even()
        {
            return View();
        }

        public ViewResult Odd()
        {
            return View();
        }
        //JsonResult Demo
        public JsonResult Index5()
        {
            return new JsonResult(new { Id=1, Name = "Prakash",Course=".Net" });
        }

        //ContentResult Demo
        public ContentResult Index6()
        {
            return Content("Welcome to .Net core MVC");
        }

        // FileStreamResult Demo

        public FileStreamResult Index7()
        {
            //creating a new text file and allows you to download from Browser
            var stream = new MemoryStream(Encoding.ASCII.GetBytes("Hello Guys..I am Prakash"));
            return new FileStreamResult(stream, new MediaTypeHeaderValue("text/plain"))
            {
                FileDownloadName = "Prakash.txt"
            };
        }

       // public FileContentResult DownloadFile()
       public FileContentResult Index8()
        {
            //reading pdf file in Binary format and it allows you to download from Browser
            byte[] fileContents = System.IO.File.ReadAllBytes(@"c:\Prakash\TEG-NewsLetter-Q1-2.pdf");
            return File(fileContents, "application/pdf", "Result.pdf");
        }

        public PartialViewResult Index9()
        {
            //returning a PartialView from Shared folder
            return PartialView("_MyPartialView");
        }
    }
}
