namespace Shwetha
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ShwethaIMDBEntities2 : DbContext
    {
        public ShwethaIMDBEntities2()
            : base("name=ShwethaIMDBEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Actor_Movie> Actor_Movie { get; set; }
        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Producer> Producers { get; set; }
    }
}
