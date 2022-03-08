using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityGitLesson.domain.Models
{
    public class Subject : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
