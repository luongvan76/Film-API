using Film_Project.Data;
using Film_Project.Models.DTO;
using Film_Project.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Film_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DirectorsController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        private readonly IDirectorRepository _directorRepository;

        public DirectorsController(AppDbContext dbContext, IDirectorRepository directorRepository)
        {
            _dbContext = dbContext;
            _directorRepository = directorRepository;
        }

        [HttpGet("Get-All-Directors")]
        [Authorize(Roles = "Read, Write")]
        public IActionResult GetAllDirectors()
        {
            var allDirectors = _directorRepository.GetAllDirectors();
            return Ok(allDirectors);
        }

        [HttpGet("Get-Director-By-Id/{id}")]
        [Authorize(Roles = "Read, Write")]
        public IActionResult GetDirectorById(int id)
        {
            var directorWithId = _directorRepository.GetDirectorById(id);
            return Ok(directorWithId);
        }

        [HttpPost("Add-Director")]
        [Authorize(Roles = "Write")]
        public IActionResult AddDirector([FromBody] DirectorDTO directorDTO)
        {
            var directorAdd = _directorRepository.AddDirector(directorDTO);
            return Ok(directorAdd);
        }

        [HttpPut("Update-Director-By-Id/{id}")]
        [Authorize(Roles = "Write")]
        public IActionResult UpdateDirectorById(int id, [FromBody] DirectorDTO directorDTO)
        {
            var updateDirector = _directorRepository.UpdateDirectorById(id, directorDTO);
            return Ok(updateDirector);
        }

        [HttpDelete("Delete-Director-By-Id/{id}")]
        [Authorize(Roles = "Write")]
        public IActionResult DeleteDirectorById(int id)
        {
            var deleteDirector = _directorRepository.DeleteDirectorById(id);
            return Ok(deleteDirector);
        }
    }
}