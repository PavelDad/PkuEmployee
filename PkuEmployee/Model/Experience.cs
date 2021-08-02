using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PkuEmployee.Model
{
    [Table("Experiences")]
    public class Experience
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public int? OrganizationId { get; set; }
        public virtual Organization Organization { get; set; }
        public DateTime RecruitmentDate { get; set; }
        public DateTime DismissalDate { get; set; }
    }
}
