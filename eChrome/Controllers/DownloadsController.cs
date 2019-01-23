using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using eChrome.Models;
using Microsoft.AspNetCore.Mvc;
using SQLite;

namespace eChrome.Controllers
{
    public class DownloadsController : Controller
    {
        public IActionResult Index()
        {
            var list = new List<Downloads>();
            string PATH = @"History";
            using (var conn = new SQLiteConnection(PATH))
            {
                
                var query = conn.Table<Downloads>().ToList();

                list = query.ToList();

                
            }
            return View(list);
        }
    }
}