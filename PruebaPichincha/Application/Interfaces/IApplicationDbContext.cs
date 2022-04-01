using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Cliente> Cliente { get; set; }
        DbSet<Cuenta> Cuenta { get; set; }
        DbSet<Movimiento> Movimiento { get; set; }
        Task<int> SaveChangesAsync();
    }
}
