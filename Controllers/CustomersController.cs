using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Trash_Collector.Data;
using Trash_Collector.Models;

namespace Trash_Collector.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var currentCustomer = await _context.Customer
                .Include(c => c.Account)
                .Include(c => c.Address)
                .Where(c => c.IdentityUserId == userId)
                .ToListAsync();
            return View(currentCustomer);
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .Include(c => c.Account)
                .Include(c => c.Address)
                .Include(c => c.IdentityUser)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            ViewData["AccountID"] = new SelectList(_context.Set<Account>(), "ID", "ID");
            ViewData["AddressID"] = new SelectList(_context.Set<Address>(), "AddressID", "AddressID");
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                customer.IdentityUserId = userId;

                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Customers");

            }
            ViewData["AccountID"] = new SelectList(_context.Set<Account>(), "ID", "ID", customer.AccountID);
            ViewData["AddressID"] = new SelectList(_context.Set<Address>(), "AddressID", "AddressID", customer.AddressID);
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customer.IdentityUserId);
            return View("Index", customer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            ViewData["AccountID"] = new SelectList(_context.Set<Account>(), "ID", "ID", customer.AccountID);
            ViewData["AddressID"] = new SelectList(_context.Set<Address>(), "AddressID", "AddressID", customer.AddressID);
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customer.IdentityUserId);
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Customer customer)
        {
            if (id != customer.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //var customerDB = _context.Customer.Where(c => c.ID == customer.ID).Single();
                    //customerDB.Account.StartDay = customer.Account.StartDay;
                    //customerDB.Account.EndDay = customer.Account.EndDay;

                    //*Won't save my changes to pickup day-one-time pickup-suspend start & end dates*//

                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index",customer);
            }
            ViewData["AccountID"] = new SelectList(_context.Set<Account>(), "ID", "ID", customer.AccountID);
            ViewData["AddressID"] = new SelectList(_context.Set<Address>(), "AddressID", "AddressID", customer.AddressID);
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customer.IdentityUserId);
            return View(customer);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .Include(c => c.Account)
                .Include(c => c.Address)
                .Include(c => c.IdentityUser)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customer.FindAsync(id);
            _context.Customer.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customer.Any(e => e.ID == id);
        }
        //private bool SuspendService(Account account)
        //{
        //    var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

        //    DateTime currentDate = DateTime.Today;

        //    if (currentDate >= account.StartDay && currentDate <= account.EndDay)

        //    {    
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}    
    }
}
