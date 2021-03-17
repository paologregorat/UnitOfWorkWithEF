using MyReservation.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyReservation.Repository.UnitOfWork
{
    public interface IUnitOfWork<TDbContext> where TDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        IGenericRepository<Event, Guid> EventRepository { get; }
        int Save();
    }
}
