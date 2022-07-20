using CRUDusingAdo.NetAssignment.DAL;
using CRUDusingAdo.NetAssignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDusingAdo.NetAssignment.Controllers
{
    public class EmployeeController : Controller
    {
        EmployessDAl db = new EmployessDAl();
        // GET: EmployeeController
        public ActionResult Index()
        {
            var model = db.GetAllEmployee();
            return View(model);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            var model = db.GetEmployeeById(id);
            return View(model);
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee Employee)
        {
            try
            {
                int result = db.AddEmployee(Employee);
                if (result == 1)
                    return RedirectToAction(nameof(Index));
                else
                    return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = db.GetEmployeeById(id);
            return View(model);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee Employee)
        {
            try
            {
                int result = db.UpdateEmployee(Employee);
                if (result == 1)
                    return RedirectToAction(nameof(Index));
                else
                    return View();

            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = db.GetEmployeeById(id);
            return View(model);
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]//required 
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                int result = db.DeleteEmployee(id);
                if (result == 1)

                    return RedirectToAction(nameof(Index));
                else
                    return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
