using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CooperTestDemo.Models;
using CooperTestDemo.Entities;
using CooperTestDemo.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CooperTestDemo.Controllers
{
    public class HomeController : Controller
    {
        ITestRepository rep = new TestRepository();
        
        public IActionResult Index()
        {
            testEntity obj = new testEntity();
            var tests = rep.GetTests();
            obj.lstTests = tests.Where(s=>s.RecordStatus == Constants.ACTIVE).ToList();
            ViewBag.tests = getTestsList(tests);
            return View(obj);
        }


        private List<SelectListItem> getTestsList(List<Tests> lstTests)
        {
            List<SelectListItem> lst = new List<SelectListItem>();
            foreach(var item in lstTests)
            {
                lst.Add(new SelectListItem { Selected = false, Text = item.Name, Value = item.Name });
            }
            return lst;
        }

        private List<SelectListItem> getAthleteList(List<Athlete> lstTests)
        {
            List<SelectListItem> lst = new List<SelectListItem>();
            foreach (var item in lstTests)
            {
                lst.Add(new SelectListItem { Selected = false, Text = item.Name, Value = item.Id.ToString() });
            }
            return lst;
        }

        [HttpPost]
        public IActionResult Index(testEntity model)
        {
            Tests t = new Tests();
            t.Name = model.testType;
            t.TestDate = model.testDate;
            t.RecordStatus = Constants.ACTIVE;
            t.CreatedDate = DateTime.Now;
            t.CreatedBy = "Test";
            t.LastUpdated = DateTime.Now;
            t.UpdatedBy = "Test";            
            rep.SaveTest(t);
            var tests = rep.GetTests();
            model.lstTests = tests.Where(s => s.RecordStatus == Constants.ACTIVE).ToList();
            ViewBag.tests = getTestsList(tests);
            return View(model);
        }

        public IActionResult Athletes(int? id)
        {
            athleteEntity obj = new athleteEntity();
            var test = rep.getTestById(id);
            if(test.Id > 0)
            {
                obj.test_id = test.Id;
                obj.test_name = test.Name + " D. " + test.TestDate.Value.ToString("ddMMyy");
            }
            obj.lstAthletes = rep.GetAthleteTestsById(id);
            var lst = rep.GetAthletes();
            ViewBag.Athletes = getAthleteList(lst);
            return View(obj);
        }

        [HttpPost]
        public IActionResult Athletes(athleteEntity model)
        {
            if(model.deleteTest)
            {
                var test = rep.getTestById(model.test_id);
                test.RecordStatus = Constants.DELETED;
                if (model.test_id > 0) { rep.SaveTest(test); } else { return RedirectToAction("Index"); }
                return RedirectToAction("Index");
            } else if(model.isForDelete && model.athleteTestId > 0)
            {
                var athlete = rep.GetAthleteTestById(model.athleteTestId);
                athlete.RecordStatus = Constants.DELETED;
                rep.SaveAthelte(athlete);
            } else
            {
                AthleteTests at = new AthleteTests();
                at.Id = model.athleteTestId;
                at.AthleteId = model.athleteId;
                at.Distance = Convert.ToDecimal(model.distance);
                at.TestId = model.test_id;
                at.RecordStatus = Constants.ACTIVE;
                at.CreateDate = DateTime.Now;
                at.CreatedBy = "Test";
                at.LastUpdated = DateTime.Now;
                at.UpdatedBy = "Test";
                rep.SaveAthelte(at);
            }            
            model.lstAthletes = rep.GetAthleteTestsById(model.test_id);
            var lst = rep.GetAthletes();
            ViewBag.Athletes = getAthleteList(lst);
            return View(model);
        }

        

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
