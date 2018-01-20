using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Website.Models;

namespace Website.Controllers
{
    public class DocsController : Controller
    {

        private const string DefaultView = "Installation";

        [Route("Docs/{view?}")]
        public IActionResult Index(string view)
        {
            if (view == null) view = DefaultView;
            ViewBag.Tag = DocData.Docs.Single(doc => doc.View == view).Tag;
            return View(view);
        }

    }
}