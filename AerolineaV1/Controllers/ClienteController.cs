using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AerolineaV1.Models;

namespace AerolineaV1.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ClienteContext _context;

        public ClienteController(ClienteContext context)
        {
            _context = context;
        }

        // GET: Cliente
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clientes.ToListAsync());
        }

        // GET: Cliente/Create
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Cliente());
            else
                return View(_context.Clientes.Find(id));
        }

        // POST: Cliente/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("ClienteID,Pasaporte,Cedula,NombreCompleto,Nacionalidad,Direccion")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                if (cliente.ClienteID == 0)
                    _context.Add(cliente);
                else
                    _context.Update(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        // GET: Cliente/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var cli = await _context.Clientes.FindAsync(id);
            _context.Clientes.Remove(cli);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

    }
}
