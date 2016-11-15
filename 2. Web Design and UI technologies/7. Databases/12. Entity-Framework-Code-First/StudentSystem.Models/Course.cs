using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentSystem.Models
{
    public class Course
    {
        private ICollection<Student> students;
        private ICollection<Homework> homeworks;

        public Course()
        {
            this.students = new HashSet<Student>();
        }
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]        
        public string Name { get; set; }

        [MaxLength(20)]
        public string Discription { get; set; }

        [MaxLength(20)]
        public string Materials { get; set; }

        public ICollection<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }

        public ICollection<Homework> Homeworks
        {
            get { return this.homeworks; }
            set { this.homeworks = value; }
        }
    }
}
