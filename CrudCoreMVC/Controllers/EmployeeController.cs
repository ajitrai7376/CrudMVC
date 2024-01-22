using CrudCoreMVC.Data.Context;
using CrudCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudCoreMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeContext _db;

        public EmployeeController(EmployeeContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var employees = _db.Emp.ToList();
            return View(employees);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(EmployeeModel emp)
        {
            if (ModelState.IsValid)
            {
                _db.Add(emp);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(emp);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null)
            {
                return RedirectToAction("Index");
            }
            var empDetails = await _db.Emp.FindAsync(id);
            return View(empDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EmployeeModel emp)
        {
            if (ModelState.IsValid)
            {
                _db.Update(emp);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(emp);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var empDetails = await _db.Emp.FindAsync(id);
            return View(empDetails);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var empDetails = await _db.Emp.FindAsync(id);
            return View(empDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(EmployeeModel emp)
        {
            _db.Emp.Remove(emp);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
