using System.ComponentModel.DataAnnotations;

namespace Atividade01.Model
{
    public class Class
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(15)]
        public string? PhoneNumber { get; set; }
        public DateOnly DateBirth { get; set; }
    }
}
