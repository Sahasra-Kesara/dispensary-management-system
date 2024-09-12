using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dispensery_management_system.Models;
using System.Threading.Tasks;
using System.Linq;
using dispensery_management_system.Services;

namespace dispensery_management_system.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DoctorsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Doctors
        public async Task<IActionResult> Index()
        {
            var doctors = await _context.Doctors.Include(d => d.UserProfile).ToListAsync();

            // Map to DoctorDto
            var doctorDtos = doctors.Select(d => new DoctorDto
            {
                DoctorID = d.DoctorID,
                UserID = d.UserProfile.FirstName + " " + d.UserProfile.LastName, // Concatenate names for display
                Specialization = d.Specialization,
                ExperienceYears = d.ExperienceYears,
                ConsultationFee = d.ConsultationFee
            });

            return View(doctorDtos);
        }

        // GET: Doctors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Doctors/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DoctorID,UserID,Specialization,ExperienceYears,ConsultationFee")] DoctorDto doctorDto)
        {
            if (ModelState.IsValid)
            {
                var doctor = new Doctor
                {
                    DoctorID = doctorDto.DoctorID,
                    UserID = doctorDto.UserID,
                    Specialization = doctorDto.Specialization,
                    ExperienceYears = doctorDto.ExperienceYears,
                    ConsultationFee = doctorDto.ConsultationFee
                };

                _context.Add(doctor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(doctorDto);
        }

        // GET: Doctors/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctor = await _context.Doctors.FindAsync(id);
            if (doctor == null)
            {
                return NotFound();
            }

            var doctorDto = new DoctorDto
            {
                DoctorID = doctor.DoctorID,
                UserID = doctor.UserID,
                Specialization = doctor.Specialization,
                ExperienceYears = doctor.ExperienceYears,
                ConsultationFee = doctor.ConsultationFee
            };

            return View(doctorDto);
        }

        // POST: Doctors/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("DoctorID,UserID,Specialization,ExperienceYears,ConsultationFee")] DoctorDto doctorDto)
        {
            if (id != doctorDto.DoctorID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var doctor = new Doctor
                {
                    DoctorID = doctorDto.DoctorID,
                    UserID = doctorDto.UserID,
                    Specialization = doctorDto.Specialization,
                    ExperienceYears = doctorDto.ExperienceYears,
                    ConsultationFee = doctorDto.ConsultationFee
                };

                try
                {
                    _context.Update(doctor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoctorExists(doctorDto.DoctorID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(doctorDto);
        }

        // GET: Doctors/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctor = await _context.Doctors
                .FirstOrDefaultAsync(m => m.DoctorID == id);
            if (doctor == null)
            {
                return NotFound();
            }

            return View(doctor);
        }

        private bool DoctorExists(string id)
        {
            return _context.Doctors.Any(e => e.DoctorID == id);
        }
    }
}
