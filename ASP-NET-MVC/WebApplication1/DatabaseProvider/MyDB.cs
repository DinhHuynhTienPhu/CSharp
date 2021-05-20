namespace DatabaseProvider
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyDB : DbContext
    {
        public MyDB()
            : base("name=MyDB")
        {
        }

        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<University> Universities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Class>()
                .Property(e => e.UNI_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Class>()
                .Property(e => e.DEP_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Class>()
                .HasMany(e => e.Students)
                .WithOptional(e => e.Class)
                .HasForeignKey(e => new { e.CLA_ID, e.UNI_ID, e.DEP_ID });

            modelBuilder.Entity<Department>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.UNI_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Classes)
                .WithRequired(e => e.Department)
                .HasForeignKey(e => new { e.DEP_ID, e.UNI_ID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.CLA_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.UNI_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.DEP_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<University>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<University>()
                .HasMany(e => e.Departments)
                .WithRequired(e => e.University)
                .HasForeignKey(e => e.UNI_ID)
                .WillCascadeOnDelete(false);
        }
    }
}
