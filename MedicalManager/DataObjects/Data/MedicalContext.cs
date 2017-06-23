using DataObjects.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.Data
{
    class MedicalContext : DbContext
    {
        public MedicalContext(DbContextOptions<MedicalContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().ToTable("Patient");
            modelBuilder.Entity<Person>().ToTable("Person");
            modelBuilder.Entity<Doctor>().ToTable("Doctor");
            modelBuilder.Entity<Parent>().ToTable("Parent");
            modelBuilder.Entity<Allergen>().ToTable("Allergen");
            modelBuilder.Entity<Medication>().ToTable("Medication");
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Allergen> Allergens { get; set; }
        public DbSet<Medication> Medications { get; set; }
    }
}
