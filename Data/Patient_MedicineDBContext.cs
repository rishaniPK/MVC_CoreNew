using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_CoreNew.Models;

namespace MVC_CoreNew.Models
{
    public class Patient_MedicineDBContext : DbContext
    {
        public Patient_MedicineDBContext (DbContextOptions<Patient_MedicineDBContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_CoreNew.Models.Patients> Patients { get; set; }

        public DbSet<MVC_CoreNew.Models.Medicines> Medicines { get; set; }
    }
}
