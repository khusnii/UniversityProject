using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityGitLesson.domain.Models
{
    public class Teacher : BaseEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public ICollection<Subject> Subjects { get; set; }
        public ICollection<Group> Groups { get; }
    }
}
