using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcAppW2.Models;
using System.Data.SqlClient;
using MvcAppW2.NW;
using Microsoft.EntityFrameworkCore;

namespace MvcAppW2.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            IQueryable<MvcAppW2.NW.Categories> qry = from c in context.Categories
                                                     select c;

            ViewBag.CategoryName = qry;

            return View(qry);
        }

        public IActionResult Details(int id)
        {
            IQueryable<MvcAppW2.NW.Categories> qry = from c in context.Categories
                                                     where c.CategoryId == id
                                                     select c;

            MvcAppW2.NW.Categories oneCategory = qry.First();

            return View(oneCategory);
        }

        //=============================================================

        static NorthwindContext context = new NorthwindContext();
    }
}
