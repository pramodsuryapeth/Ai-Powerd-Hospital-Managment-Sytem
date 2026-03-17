using Microsoft.AspNetCore.Mvc;
using System.Linq;
using HospitalManagementAPI.Data;
using HospitalManagementAPI.Models;

namespace HospitalManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AdminController(AppDbContext context)
        {
            _context = context;
        }

        // ADMIN LOGIN
        [HttpPost]
        [Route("AdminLogin")]
        public IActionResult AdminLogin(AdminLoginDTO dto)
        {
            var admin = _context.Admins
                .FirstOrDefault(a => a.Email == dto.Email && a.Password == dto.Password);

            if (admin != null)
            {
                return Ok(admin);
            }
            else
            {
                return BadRequest("Invalid Email or Password");
            }
        }
    }
}