﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SportSchool111.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SchoolSportsProgramsEntities : DbContext
    {
        public SchoolSportsProgramsEntities()
            : base("name=SchoolSportsProgramsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Attendance> Attendance { get; set; }
        public virtual DbSet<Coaches> Coaches { get; set; }
        public virtual DbSet<CompetingTeams> CompetingTeams { get; set; }
        public virtual DbSet<Competitions> Competitions { get; set; }
        public virtual DbSet<Genders> Genders { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<Results> Results { get; set; }
        public virtual DbSet<Schools> Schools { get; set; }
        public virtual DbSet<Sections> Sections { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<trainigs> trainigs { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
