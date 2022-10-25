using CyoloFrontApp.App_Start;
using CyoloFrontApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CyoloFrontApp.Controllers
{
    public class CourtCaseController : Controller
    {
        // GET: CourtCase
        public ActionResult Index()
        {
            return View();
        }


        // GET: GetByEmailAndDate
        public async Task<ActionResult> GetByEmailAndDate(string date, string email)
        {
            LawyerService ls = new LawyerService();
            var datas = await ls.GetCourtCaseByEmailAndDate("walter.damen@advocatenkantoordamen.be", "2022-10-03");
            ViewBag.datas = datas;
            return View();
        }

        // GET: ViewLawyers
        public async Task<ActionResult> Viewlawyers(string courtCaseNo)
        {
            LawyerService ls = new LawyerService();
            var datas = await ls.GetLawyersByCourtcaseno(courtCaseNo);
            ViewBag.datas = datas;
            return View();
        }


        // GET: CourtCase/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CourtCase/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourtCase/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CourtCase/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CourtCase/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CourtCase/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CourtCase/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
