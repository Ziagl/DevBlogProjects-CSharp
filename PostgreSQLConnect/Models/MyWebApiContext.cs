﻿using Microsoft.EntityFrameworkCore;

namespace PostgreSQLConnect.Models
{
    public class MyWebApiContext : DbContext
    {
        public MyWebApiContext(DbContextOptions<MyWebApiContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
