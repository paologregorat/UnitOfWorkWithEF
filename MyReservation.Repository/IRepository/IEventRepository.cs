using MyReservation.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyReservation.Repository
{
    public interface IEventRepository : IGenericRepository<Event, Guid>
    {

    }
}
