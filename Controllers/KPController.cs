using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using placucci.gabriele._5H.SecondaWeb.Models;
using Microsoft.AspNetCore.Authorization;

namespace placucci.gabriele._5H.SecondaWeb.Controllers
{
    public class KPController : Controller
    {
        private readonly ILogger<KPController> _logger;

        public KPController(ILogger<KPController> logger)
        {
            _logger = logger;
        }
        public IActionResult biografia()    //biografia
        {
            return View();
        }
        
        public IActionResult discografia() //discografia
        {
            return View();
        }

        public IActionResult news() //notizie
        {
            return View();
        }

        [Authorize]    //richiedo una autenticazione all'utente per poter effettuare la prenotazione
        public IActionResult prenotazioni() //prenotazioni
        {
            return View();
        }
        
        
       
        public IActionResult concerti()  //concerti
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
