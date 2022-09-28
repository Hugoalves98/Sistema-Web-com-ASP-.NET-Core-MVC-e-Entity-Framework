using System.ComponentModel.DataAnnotations;

namespace SaleWebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "{0} deve estar entre {2} e {1}")]
        public string? Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required]
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Required]
        [Range(100.0, 50000.0, ErrorMessage = "{0} deve ser entre {1} a {2}")]
        [Display(Name = "Base Salary")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double BaseSalary { get; set; }

        public Department? Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {

        }
        public Seller(int id, string? name, string? email, DateTime birthDate, double baseSalary, Department? department)
        {
            /*Id = id; */
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }
        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }
        public double TotalSales(DateTime inicial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= inicial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
