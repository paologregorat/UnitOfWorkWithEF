﻿using MyReservation.Domain;
using MyReservation.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MyReservation.Test
{
    public class MyReservationContextFixture : IDisposable
    {
        public MyReservationContext Context { get; set; }

        public MyReservationContextFixture()
        {
            var builder = new DbContextOptionsBuilder<MyReservationContext>();
            builder.UseInMemoryDatabase(databaseName: "MyReservationDbInMemory" + Guid.NewGuid().ToString());

            var dbContextOptions = builder.Options;
            Context = new MyReservationContext(dbContextOptions);

            Context.Database.EnsureDeleted();
            bool created = Context.Database.EnsureCreated();

            Assert.True(created);

            SeedData();
        }

        private void SeedData()
        {
            for (int i = 1; i <= 100; i++)
            {
                Context.Customers.Add(new Customer() { Id = new Guid("00000000-0000-0000-0000-" + i.ToString("D12")), Name = "NameTest" + i, Surname = "SurnameTest" + i });
            }

            for (int i = 1; i <= 10; i++)
            {
                Context.Events.Add(new Event() { Id = new Guid("00000000-0000-0000-0000-" + i.ToString("D12")), Date = DateTime.Now.AddDays(i), Title = "Evento live", Description = "Evento live" });
            }

            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context?.Dispose();
        }
    }
}
