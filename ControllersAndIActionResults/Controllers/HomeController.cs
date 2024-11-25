using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ControllersAndIActionResults.Controllers
{
    public class HomeController : Controller
    {
        [Route("content")]
        public IActionResult Index()
        {

            return Content("Hello world");
        }

        [Route("json")]
        public JsonResult Person()
        {
            User user = new User()
            {
                Name = "Max Schessler",
                Email = "email@email.com",
                Password = "Password!"
            };

            return Json(user);
        }

        [Route("file")]
        public FileResult File()
        {
            return File("/Just Hired Graphic - Red.jpg", "application/jpg");
        }


        [Route("file-content")]
        public FileContentResult FileContent()
        {
            Byte[] bytes = System.IO.File.ReadAllBytes("C:\\New folder\\Test.txt.txt");
            return File(bytes, "application/jpg");
        }


    }
}


public class User
{
    [Required]
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

}