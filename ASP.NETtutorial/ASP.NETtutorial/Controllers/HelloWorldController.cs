using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NETtutorial.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        // GET: HelloWorld/Welcome
        public ActionResult Welcome(string firstName = "Not defined", string lastName = "Not defined", int age = 0)
        {
            ViewBag.firstName = firstName;
            ViewBag.lastName = lastName;
            ViewBag.age = age;
            return View();
        }

        public string WelcomeAgain(string firstName = "Not defined",
            string lastName = "Not defined",
            string job = "unemployed")
        {
            var response = HttpUtility.HtmlEncode($"Hello, number {firstName}. Your last name is: {lastName}. You are currently a: {job}");
            return response;
        }

        public string HelloAgain(int id = 1,
            string lastName = "Not defined",
            string job = "unemployed")
        {
            var response = HttpUtility.HtmlEncode($"Hello, number {id}. Your last name is: {lastName}. You are currently a: {job}");
            return response;
        }
    }
}