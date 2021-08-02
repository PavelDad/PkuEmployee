using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PkuEmployee.Model
{
    [Table("Nationalities")]
    public class Nationality : IComparable, INameble
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Employee> Employees { get; set; }
        public Nationality()
        {
            Employees = new List<Employee>();
        }

        public override string ToString()
        {
            return Name;
        }

        public int CompareTo(object obj)
        {
            if (obj is Nationality)
            {
                return Name.CompareTo((obj as Nationality).Name);
            }
            return 0;
        }
    }
}
