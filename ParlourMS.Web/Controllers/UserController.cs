using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParlourMS.BL.Services.Interfaces;
using ParlourMS.Data.Models;

namespace ParlourMS.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController ( IUserService userService )
        {
            _userService = userService;
        }

        // GET: UserController
        public ActionResult Index ()
        {
            var userList=_userService.GetUserList();
            return View ( userList );
        }

        // GET: UserController/Details/5
        public ActionResult Details ( int id )
        {
            return View ();
        }

        // GET: UserController/Create
        public ActionResult Create ()
        {
            return View (new User());
        }

        // POST: UserController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create ( User user )
        {
            try
            {
                _userService.AddUser ( user );
                return RedirectToAction ( nameof ( Index ) );
            }
            catch
            {
                return View ();
            }
        }

        // GET: UserController/Edit/5
        public ActionResult Edit ( string id )
        {
            var user=_userService.GetUser(id);
            return View ( user );
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit ( int id, IFormCollection collection )
        {
            try
            {
                return RedirectToAction ( nameof ( Index ) );
            }
            catch
            {
                return View ();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete ( int id )
        {
            return View ();
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete ( int id, IFormCollection collection )
        {
            try
            {
                return RedirectToAction ( nameof ( Index ) );
            }
            catch
            {
                return View ();
            }
        }
    }
}
