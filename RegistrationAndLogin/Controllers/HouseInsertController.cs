using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domki_Rezerwacje.Models;

namespace Domki_Rezerwacje.Controllers
{
    public class HouseInsertController : Controller
    {
        // GET: HouseInsert
        [HttpGet]
        public ActionResult HouseAdd()
        {
            return View();
        }

        //House Add POST action 
        [HttpPost]
        public ActionResult HouseAdd([Bind] House house)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    #region Save to Database
                    using (MyDatabaseEntities dc = new MyDatabaseEntities())
                    {
                        dc.Houses.Add(house);
                        dc.SaveChanges();

                    }
                    #endregion

                    // return view z gratulacjami
                    return View("HouseAddSuccess");

                }
                catch
                {
                    // return view z niepowodzeniem
                    return View("HouseAddFailure");

                }
                
                
            }
            else
            {
                // return view z niepowodzeniem
                return View("HouseAddFailure");
            }

            
        }

        public ActionResult HouseShow()
        {
            var entities = new MyDatabaseEntities();

            return View(entities.Houses.ToList());
        }

    }
}
