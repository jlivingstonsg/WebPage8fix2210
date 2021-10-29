using WebPage8.Data;
using WebPage8.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ComputerShop2.Controllers
{
    public class ManageUsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ManageUsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ManageUsers
        public async Task<IActionResult> Index()
        {
            List<dynamic> oneList = new List<dynamic>();
            foreach (var item in _context.Users)
            {
                dynamic dyObj = new ExpandoObject();
                dyObj.UserId = item.Id;
                dyObj.UserName = item.Email;
                dyObj.UserFName = item.FirstName;
                dyObj.UserLName = item.LastName;
                dyObj.UserEmail = item.Email;
                dyObj.UserPhoneNumber = item.PhoneNumber;
                dyObj.UserPassword = item.PasswordHash;
                dyObj.UserRole = GetUserRoleName(item.Id); ;
                oneList.Add(dyObj);
            }

            ViewBag.data = oneList;
            return View(await _context.Users.ToListAsync());
        }

        public string GetUserRoleName(string Id)
        {
            var query = from a in _context.Users
                        join b in _context.UserRoles on a.Id equals b.UserId
                        join c in _context.Roles on b.RoleId equals c.Id
                        where a.Id == Id
                        select c.Name.SingleOrDefault();

            return query.ToString();
        }

        // GET: ManageUsers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Manageuser/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Manageuser/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,FirstName,LastName,PhoneNumber,Email,PasswordHash")] ApplicationUser user,string UserRole)
        {
            
            ViewData["UserRoles"] = new SelectList(_context.Roles, "Name", "Name");
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: ManageUsers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: ManageUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit( string id, string firstName, string lastName,
            string passwordHash, string email, string phoneNumber )
        {
             ApplicationUser user = new ApplicationUser
            {
                FirstName = firstName,
                LastName = lastName,
                PasswordHash = passwordHash,
                Email = email,
                PhoneNumber = phoneNumber
            };
            ApplicationUser userToEdit = _context.Users.FirstOrDefault(u => u.Id == id);

            if (id != userToEdit.Id)
            {
                return NotFound();
            }
            else
            {
                userToEdit.FirstName = user.FirstName;
                userToEdit.LastName = user.LastName;
                userToEdit.PhoneNumber = user.PhoneNumber;
                userToEdit.PasswordHash = user.PasswordHash;
                userToEdit.Email = user.Email;

                _context.Update(userToEdit);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));

        }

        // GET: ManageUsers/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: ManageUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user = await _context.Users.FindAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(string id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}

