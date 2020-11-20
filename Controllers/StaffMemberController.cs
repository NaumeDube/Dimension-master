using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dimension.Controllers
{
    public class StaffMemberController : Controller
    {
        [Authorize(Roles = "Employee")]
        public IActionResult Index()
        {
            return View();
        }
    }
}