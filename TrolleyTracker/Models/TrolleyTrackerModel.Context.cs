﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrolleyTracker.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TrolleyTrackerEntities : DbContext
    {
        public TrolleyTrackerEntities()
            : base("name=TrolleyTrackerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<RouteStop> RouteStops { get; set; }
        public virtual DbSet<Shape> Shapes { get; set; }
        public virtual DbSet<Stop> Stops { get; set; }
        public virtual DbSet<Trolley> Trolleys { get; set; }
        public virtual DbSet<RouteSchedule> RouteSchedules { get; set; }
    }
}
