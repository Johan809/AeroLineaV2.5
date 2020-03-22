using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AerolineaV1.Models
{
    public class ReservacionContext: DbContext
    {
        public ReservacionContext(DbContextOptions<ReservacionContext> options):base(options)
        {}

        public DbSet<Reservacion> Reservaciones { get; set; }
    }
}
