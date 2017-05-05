using Homework__01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework__01.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index(MyData result)
        {
            List<MyData> list = new List<MyData>();

            Random RR = new Random();

            for (int i = 1; i <= 100; i++)
            {
                int money = RR.Next(1000000);
                var dd = RR.Next(100000);              
                var time = DateTime.Now.AddMilliseconds(dd).AddDays(dd);             
                var name = "";
                var categories = RR.Next(1, 3); 
                if (categories == 1)
                {
                    name = "支出";
                }
                else
                {
                    name = "收入";
                }
                list.Add(new MyData { Category = name, Date = time, Money = money, Number = i });
            }

            return View(list);
        }


    }
}