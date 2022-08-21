using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using homework_4.Models;

namespace homework_4.Controllers
{
    public class HomeController : Controller

    {
        public List<RecyclableMaterials> Rmaterials = new List<RecyclableMaterials>();
        
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Donate()
        {
            return View();
        }

        public ActionResult GetInvolved()
        {
            return View();
        }

        public ActionResult MyProfile()
        {
            return View();
        }
       
        public ActionResult Recycle()
        {

            Glass glass1 = new Glass(3,"01.08.2022", "1083 Prospect Street", "Perplex");
            Glass glass2 = new Glass(1, "05.08.2022", "1083 Prospect Street", "Tinted");
            Glass glass3 = new Glass(4, "08.08.2022", "1083 Prospect Street", "Float");

            Metal metal1 = new Metal(2, "27.07.2022", "1083 Prospect Street", "Steel");
            Metal metal2 = new Metal(3, "27.07.2022", "1083 Prospect Street", "Copper");

            Plastic plastic1 = new Plastic(5, "15.07.2022", "1083 Prospect Street", "PVC");
            Plastic plastic2 = new Plastic(6, "07.08.2022", "1083 Prospect Street", "PET");

            Paper paper1 = new Paper(3, "26.07.2022", "1083 Prospect Street", "Text", "Long-grain");
            Paper paper2 = new Paper(6, "07.08.2022", "1083 Prospect Street", "Cover", "Short-grain");

            Rmaterials.Add(glass1);
            Rmaterials.Add(glass2);
            Rmaterials.Add(glass3);
            Rmaterials.Add(metal1);
            Rmaterials.Add(metal2);
            Rmaterials.Add(plastic1);
            Rmaterials.Add(plastic2);
            Rmaterials.Add(paper1);
            Rmaterials.Add(paper2);




            return View(Rmaterials);
        }

        
    }
}