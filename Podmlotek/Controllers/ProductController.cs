﻿using Podmlotek.Infrastructure;
using Podmlotek.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Podmlotek.Controllers
{
    public class ProductController : Controller
    {
		// GET: Product
		Context db = new Context();
			
		public ActionResult Details(int id)
		{
			var product = db.Product.Find(id);
			return View(product);
		}		
	}
}