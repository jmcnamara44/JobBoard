using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;


namespace JobBoard.Controllers
{
  public class HomeController : Controller
  {
    [Route("/test")] //localhost:5000/test in browser
    public string Test() { return "Testing 1, 2, 3"; }

    [HttpGet("/")]
    public ActionResult Index()
    {
        List<Job> allJobs = Job.GetAll();

        return View(allJobs);
    }

    [HttpGet("/job/new")]
    public ActionResult CreateForm()
    {
        return View();
    }

    [HttpPost("/")]
    public ActionResult Create()
    {
      Contact newContact = new Contact (Request.Form["name"], Request.Form["email"], Request.Form["phoneNumber"]);
      Job newJob = new Job (Request.Form["title"], Request.Form["description"], newContact);
      newJob.Save();
      List<Job> allJobs = Job.GetAll();
      return View("Index", allJobs);
    }

    [HttpPost("/job/delete")]
    public ActionResult DeleteAll()
    {
        Job.ClearAll();
        return View();
    }


  }
}
