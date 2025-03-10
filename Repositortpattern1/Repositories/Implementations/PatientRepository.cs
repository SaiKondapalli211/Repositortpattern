using Repositortpattern1.Data;
using Repositortpattern1.Models;
using Repositortpattern1.Repositories.Interfaces;

namespace Repositortpattern1.Repositories.Implementations
{
    public class PatientRepository : IPatient
    {
        private readonly ApplicationDBContext _context;
        public PatientRepository(ApplicationDBContext db)
        {
            _context = db;  
        }


        public int CreatePatient(Patient patient)
        {
            int result = -1;
            if (patient == null)
            {
                return 0;
            }
            else
            {
                _context.Patients.Add(patient); 
                _context.SaveChanges();
                result = patient.Id;
            }
            return result;
        }

        public int DeletePatient(int id)
        {
            return 1;
        }

        public IEnumerable<Patient> GetAllPatients()
        {
            var y = _context.Patients.ToList();
            return y; 
        }

        public Patient GetPatientById(int id)
        {
            var y = _context.Patients.Where(x => x.Id == id).FirstOrDefault() ?? null;
            return y;
        }

        public int UpdatePatient(Patient patient)
        {
            var y = _context.Patients.Where(x => x.Id == patient.Id).FirstOrDefault() ?? null;
            if(y != null)
            {
                y.Id = patient.Id;  
                y.FirstName = patient.FirstName;
                y.LastName = patient.LastName;
                y.Address = patient.Address;
                y.Age = patient.Age;    
                y.PatientType = patient.PatientType;    
                y.bednum = patient.bednum;  
                y.diagnosis = patient.diagnosis;    
                _context.SaveChanges();
                return y.Id;
            }

            return -1;

        }
        public void Dispose()
        {
            _context?.Dispose();
        }


    }
}
