using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PkuEmployee.Model
{
    [Table("Employees")]
    public class Employee : IComparable
    {
        [Key]
        public int Id { get; set; }
        public string No { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SecondName { get; set; }
        public DateTime BirthDate { get; set; }
        public string IdCardName { get; set; }
        public string IdCardNo { get; set; }
        public DateTime IdCardDate { get; set; }
        public string IdCardGov { get; set; }
        public DateTime IdCardValidity { get; set; }
        public int? NationalityId { get; set; }
        public virtual Nationality Nationality { get; set; }
        public int? PostId { get; set; }
        public virtual Post Post { get; set; }
        public string Description { get; set; }
        public byte[] Photo { get; set; }
        public DateTime RecruitmentDate { get; set; }
        public DateTime? DismissalDate { get; set; }

        public virtual List<Education> Educations { get; set; }
        public virtual List<Experience> Experiences { get; set; }
        public virtual List<Course> Courses { get; set; }
        public virtual List<EmployeesSubject> EmployeesSubjects { get; set; }
        public virtual List<Order> Orders { get; set; }
        public Employee()
        {
            Educations = new List<Education>();
            Experiences = new List<Experience>();
            Courses = new List<Course>();
            EmployeesSubjects = new List<EmployeesSubject>();
            Orders = new List<Order>();
        }

        [NotMapped]
        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - BirthDate.Year;
                if (BirthDate.Date > today.AddYears(-age)) age--;
                return age;
            }
        }
        [NotMapped]
        public string ShortName
        {
            get
            {
                var lastName = string.IsNullOrWhiteSpace(LastName) ? "" : (LastName[0].ToString().ToUpper() + ".");
                var secondName = string.IsNullOrWhiteSpace(SecondName) ? "" : (SecondName[0].ToString().ToUpper() + ".");
                return $"{FirstName} {lastName}{secondName}";
            }
        }
        [NotMapped]
        public string FullName
        {
            get
            {
                var lastName = string.IsNullOrWhiteSpace(LastName) ? "" : (" " + LastName);
                var secondName = string.IsNullOrWhiteSpace(SecondName) ? "" : (" " + SecondName);
                return FirstName + lastName + secondName;
            }
        }

        public override string ToString()
        {
            return FullName;
        }

        public int CompareTo(object obj)
        {
            if (obj is Employee)
            {
                return FullName.CompareTo((obj as Employee).FullName);
            }
            return 0;
        }
    }
}
