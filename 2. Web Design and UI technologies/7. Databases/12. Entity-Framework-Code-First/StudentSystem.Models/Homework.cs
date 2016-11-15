using System.ComponentModel.DataAnnotations;

namespace StudentSystem.Models
{
    public class Homework
    {
        public int Id { get; set; }

        [MaxLength(20)]
        public string Content { get; set; }

        public int TimeSpent { get; set; }
    }
}
