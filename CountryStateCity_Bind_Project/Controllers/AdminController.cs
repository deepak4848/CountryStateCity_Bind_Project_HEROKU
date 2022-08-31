using CountryStateCity_Bind_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CountryStateCity_Bind_Project.Controllers
{
    public class AdminController : Controller
    {
        private readonly DatabaseContext _context;

        public AdminController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create(int id = 0)
        {
            ViewBag.BT = "Save";
            TblUserCollection obj = new TblUserCollection();
            if (id > 0)
            {
                var data = (from a in _context.Users where a.User_Id == id select a).ToList();
                obj.User_Id = data[0].User_Id;
                obj.User_Name = data[0].User_Name;
                obj.User_Country = data[0].User_Country;
                obj.User_State = data[0].User_State;
                obj.User_City = data[0].User_City;
                ViewBag.BT = "Update";
            }
            ViewBag.Ctr = _context.tblCountries.ToList();
            //ViewBag.btr = _context.tblCitys.ToList();
            //ViewBag.Str = _db.tblStates.Where(x =>x.CId == obj.User_Country).ToList();
            ViewBag.Str = (from a in _context.tblStates where a.CId == obj.User_Country select a).ToList();
            ViewBag.bbt = (from a in _context.tblCitys where a.SId == obj.User_State select a).ToList();
            return View(obj);
        }
        [HttpPost]
        public IActionResult Create(User _Usr)
        {

            if (_Usr.User_Id > 0)
            {
                _context.Entry(_context).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            else
            {
                _context.Users.Add(_Usr);
            }
            _context.SaveChanges();
            return RedirectToAction("Show");
        }
        public JsonResult GetState(int A)
        {

            var data = (from a in _context.tblStates where a.CId == A select a).ToList();
            //var data = _context.tblStates.Where(x => x.CId == A).ToList();
            return Json(data);
            // return Json(new {data=data});

        }
        public JsonResult GetCity(int A)
        {

           var data = (from a in _context.tblCitys where a.SId == A select a).ToList();
            //var data = _context.tblCitys.Where(x => x.SId == A).ToList();
            return Json(data);
            // return Json(new {data=data});

        }
        [HttpGet]
        public IActionResult Show()
        {
            var data = (from a in _context.Users

                        join b in _context.tblCountries
                        on a.User_Country equals b.CId
                        join c in _context.tblStates
                        on a.User_State equals c.SId
                        join d in _context.tblCitys
                        on a.User_City equals d.DId
                        select new UserJoin
                        {
                            User_Id = a.User_Id,
                            User_Name = a.User_Name,
                            User_Country = b.CName,
                            User_State = c.SName,
                           User_City = d.DName,
                           
                        }).ToList();

            return View(data);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = _context.Users.Where(x => x.User_Id == id).FirstOrDefault();
            ViewBag.StateName = _context.tblStates.Find(data.User_State).SName;
            ViewBag.Country = _context.tblCountries.Find(data.User_Country).CName;
            ViewBag.City = _context.tblCitys.Find(data.User_City).DName;
            return View(data);
        }
        public IActionResult Delete(User u)
        {
            var data = _context.Users.Remove(u);
            _context.SaveChanges();
            return RedirectToAction("Show");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var data = _context.Users.Where(x => x.User_Id == id).FirstOrDefault();
            ViewBag.StateName = _context.tblStates.Find(data.User_State).SName;
            ViewBag.Country = _context.tblCountries.Find(data.User_Country).CName;
            ViewBag.City = _context.tblCitys.Find(data.User_City).DName;
            return View(data);
        }
    //    [HttpGet]
    //    public IActionResult Edit(int id)
    //    {
    //        //var data = _context.Users.Find(id);
    //        var data = _context.Users.Where(x => x.User_Id == id).FirstOrDefault();
    //        //var data = _context.Users.Where(x => x.User_Id == id).FirstOrDefault();
    //        var countries = _context.tblCountries.ToList();
    //       ViewBag.AllCountry = new SelectList(countries, "CId", "CName");
    //        var states = _context.tblStates.Where(x => x.CId == data.User_Country).ToList();
    //        ViewBag.AllState = new SelectList(states, "SId", "SName");
    //        var city = _context.tblCitys.Where(x => x.DId == data.User_State).ToList();
    //        ViewBag.AllCity = new SelectList(city, "DId", "DName");


    //        //ViewBag.StateName = _context.tblStates.Find(data.User_State).SName;
    //        //ViewBag.Country = _context.tblCountries.Find(data.User_Country).CName;
    //        return View(data);
    //    }
    //    [HttpPost]
    //    public IActionResult Edit(User _Usr)
    //    {

    //        //if (_Usr.User_Id > 0)
    //        //{
    //        //    _context.Users.Update()
    //        //}
    //        //else
    //        //{
    //        //}
    //        _context.Users.Update(_Usr);

    //        _context.SaveChanges();
    //        return RedirectToAction("Show");
    //    }
    }
}
