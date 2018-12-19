namespace SaveImage
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBContext : DbContext
    {
        public DBContext()
            : base(Common.connectionString)            
        {
        }

        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Data> Data { get; set; }
        public virtual DbSet<Defect> Defects { get; set; }
        public virtual DbSet<Pressform> Pressforms { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<WorkCenter> WorkCenters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Color>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Data>()
                .Property(e => e.Shift)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Data>()
                .Property(e => e.BoxNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Data>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<Data>()
                .Property(e => e.ClosedNests)
                .IsUnicode(false);

            modelBuilder.Entity<Defect>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Pressform>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<WorkCenter>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
