using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using examProject21.Models;
using Microsoft.EntityFrameworkCore;

namespace examProject21.Controllers
{
    public class EmpController1 : Controller
    {
        private readonly ConnectionStringClass _cc;
        public EmpController1(ConnectionStringClass cc)
        {
            _cc = cc;

        }

        public IActionResult Index()
        {
            var results = _cc.Sheet1.ToList();

            return View(results);
        }
    }
}
