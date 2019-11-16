using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskManager.Web.Models.DTOs;

namespace TaskManager.Web.Controllers
{
    public class HomeController : Controller
    {
        private List<TaskDTO> _Tasks;

        public HomeController()
        { 

            _Tasks = new List<TaskDTO>()
            {
                new TaskDTO() { Id = 1, Name = "Create Model" },
                new TaskDTO() { Id = 1, Name = "Create Controller" },
                new TaskDTO() { Id = 1, Name = "Create view" },
            };
        }


        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}