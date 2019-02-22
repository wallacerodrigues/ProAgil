﻿using Microsoft.EntityFrameworkCore;
using ProAgil.API.Model;

namespace ProAgil.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Evento> Eventos { get; set; }
    }
}
