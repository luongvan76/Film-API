using System.ComponentModel.DataAnnotations;

namespace Film_Project.Models.Domain
{
    public class Directors
    {
        [Key]
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public List<FilmDirectors>? FilmDirectors { get; set; }
    }
}