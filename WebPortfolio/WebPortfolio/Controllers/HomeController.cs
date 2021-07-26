﻿using System.Threading.Tasks;
using System.Web.Mvc;
using WebPortfolio.Models.ViewModels;

namespace WebPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        
        public async Task<ActionResult> Resume()
        {
            var vm =  await ResumeViewModel.LoadFrom();
            return View(vm);
        }
    }
}