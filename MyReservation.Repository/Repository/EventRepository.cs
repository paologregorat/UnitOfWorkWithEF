using MyReservation.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MyReservation.Infrastructure.Persistence;

namespace MyReservation.Repository
{
    public class EventRepository : GenericRepository<Event, Guid>, IEventRepository
    {
        public EventRepository(MyReservationContext context) : base(context)
        {

        }
    }
}
