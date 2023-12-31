﻿using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{ 
     public class CustomersController : Controller
     { 
        private ApplicationDbContext _context;

          public CustomersController()
          {
               _context = new ApplicationDbContext();
          }

          protected override void Dispose(bool disposing)
          {
               _context.Dispose();
          }

          // GET: Customers
        public ViewResult Customer()//to view the list of customers
        {
             var customers = _context.Customers.Include(c => c.MembershipType); 

             return View(customers);
        }
 
        public ActionResult Details(int id)
        {
             var customer = _context.Customers.Include(c=> c.MembershipType).SingleOrDefault(c => c.Id == id);
             return View(customer);
        }

     }
}