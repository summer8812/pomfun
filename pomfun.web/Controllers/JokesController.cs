﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace pomfun.web.Controllers
{
    public class JokesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}