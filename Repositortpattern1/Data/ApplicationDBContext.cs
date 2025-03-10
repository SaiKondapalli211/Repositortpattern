using Microsoft.EntityFrameworkCore;
using Repositortpattern1.Models;

namespace Repositortpattern1.Data
{
    public class ApplicationDBContext :DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public virtual DbSet<Patient> Patients { get; set; }

    }
}
