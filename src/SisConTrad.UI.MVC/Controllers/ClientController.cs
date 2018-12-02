using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SisConTrad.Core.Interfaces.Services;
using SisConTrad.Core.Model;
using SisConTrad.Infrastructure.Data;

namespace SisConTrad.UI.MVC.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientService _clientService;


        // GET: Client

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        // GET: Client/Details/5
        public IActionResult Index()
        {
            return View(_clientService.GetAll());
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = _clientService.GetById(id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // GET: Client/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Client/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Name,Email,WhatsApp,IsActive")] Client client)
        {
            if (ModelState.IsValid)
            {
                _clientService.Create(client);
                return RedirectToAction(nameof(Index));
            }
            return View(client);
        }

        // GET: Client/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = _clientService.GetById(id);
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }

        // POST: Client/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Name,Email,WhatsApp,IsActive")] Client client)
        {
            if (id != client.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _clientService.Update(client);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientExists(client.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(client);
        }

        // GET: Client/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = _clientService.GetById(id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // POST: Client/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _clientService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private bool ClientExists(int id)
        {
            return _clientService.GetAll().Any(e => e.Id == id);
        }
    }
}
