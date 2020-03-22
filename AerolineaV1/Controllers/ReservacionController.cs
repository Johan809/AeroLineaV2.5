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
    public class ReservacionController : Controller
    {
        private readonly ReservacionContext _context;
        private VueloContext _Vuelocontext;
        private ClienteContext _Clientecontext;

        public ReservacionController(ReservacionContext context, VueloContext vuelo, ClienteContext cliente)
        {
            _context = context;
            _Vuelocontext = vuelo;
            _Clientecontext = cliente;
        }

        // GET: Reservacion
        public async Task<IActionResult> Index()
        {
            return View(await _context.Reservaciones.ToListAsync());
        }

        // GET: Reservacion/Create
        public IActionResult AddOrEdit(int id = 0)
        {
            _ = new List<Vuelo>();
            List<Vuelo> li = _Vuelocontext.Vuelos.ToList();
            ViewBag.Vuelos = li;

            List<Cliente> cli = new List<Cliente>();
            cli = _Clientecontext.Clientes.ToList();
            ViewBag.Clientes = cli;

            if (id == 0)
                return View(new Reservacion());
            else
                return View(_context.Reservaciones.Find(id));
        }

        // POST: Reservacion/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("ReservaID,NombreCliente,PaisDestino,CategoriaVuelo,PosAsiento")] Reservacion reservacion)
        {
            if (ModelState.IsValid)
            {
                if (reservacion.ReservaID == 0)
                    _context.Add(reservacion);
                else
                    _context.Update(reservacion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reservacion);
        }

        // GET: Reservacion/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var res = await _context.Reservaciones.FindAsync(id);
            _context.Reservaciones.Remove(res);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

       
    }
}
