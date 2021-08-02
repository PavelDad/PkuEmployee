using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PkuEmployee.Model
{
    [Table("Organizations")]
    public class Organization : IComparable, INameble
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Education> Educations { get; set; }
        public virtual List<Experience> Experiences { get; set; }
        public virtual List<Course> Courses { get; set; }
        public Organization()
        {
            Educations = new List<Education>();
            Experiences = new List<Experience>();
            Courses = new List<Course>();
        }

        public override string ToString()
        {
            return Name;
        }

        public int CompareTo(object obj)
        {
            if (obj is Organization)
            {
                return Name.CompareTo((obj as Organization).Name);
            }
            return 0;
        }
    }
}
