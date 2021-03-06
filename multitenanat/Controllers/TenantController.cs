﻿using multitenanat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace multitenanat.Controllers
{
    public class TenantController : Controller
    {
        public async Task<ActionResult> Index()
        {
            using (var context = new MultiTenantContext())
            {
                var tenants = await context.Tenants.ToListAsync();
                return View(tenants);
            }

        }

         
    }
}