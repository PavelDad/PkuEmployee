using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PkuEmployee.Model
{
    [Table("Subjects")]
    public class Subject : IComparable, INameble
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<EmployeesSubject> EmployeesSubjects { get; set; }
        public Subject()
        {
            EmployeesSubjects = new List<EmployeesSubject>();
        }

        public override string ToString()
        {
            return Name;
        }

        public int CompareTo(object obj)
        {
            if (obj is Subject)
            {
                return Name.CompareTo((obj as Subject).Name);
            }
            return 0;
        }
    }
}
