using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace LSTN.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = parameters =>
            {
                return View["Index"];
            };
        }
    }
}