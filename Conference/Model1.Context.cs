﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Conference
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bd02Entities : DbContext
    {
        public bd02Entities()
            : base("name=bd02Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Organizators> Organizators { get; set; }
        public virtual DbSet<Parcipiants> Parcipiants { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}