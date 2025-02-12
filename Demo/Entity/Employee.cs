//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Demo.Entity
//{
//    EF Core : Supports 4 ways to map a class in DB[Table - View - Function]
//    1.By Convention[Default Behaviour]
//    2.Data Annotation[Set of attributes used for data validation]
//    3.FLuent APIs
//    4.Class Configuration

//    POCO
//    Plain Old CLR Object
//    Entity


//    Table
//    By Convention
//    internal class Employee
//    {
//        public int Id { get; set; } //Public numeric property [Id - EmployeeId] --> PK Identity Constraints
//        public string Name { get; set; } // Reference Type : nvarchar(max) - Required  
//        public int? Age { get; set; } //int : Nullable type : int(Age) - Optional
//        public double Salary { get; set; } //Float : value type - required 
//        public string? Address { get; set; }//Nullable reference type :  Optional
//        public DateTime DateOfCreation { get; set; } //datetime2

//    }

//    Data Annotation
//    [Table("Employees", Schema = "dbo")]
//    internal class Employee
//    {
//        [Key]
//        [DatabaseGenerated(DatabaseGeneratedOption.None)]
//        public int EmpId { get; set; }


//        [Required]
//        [Column("EmpName", TypeName = "varchar")]
//        [MaxLength(50)]
//        [StringLength(50, MinimumLength = 10)]
//        public string? Name { get; set; }


//        [Range(20, 60)]
//        public int? Age { get; set; }

//        [Column(TypeName = "money")]
//        public double Salary { get; set; }


//        [EmailAddress]
//        [DataType(DataType.EmailAddress)]
//        public string Email { get; set; }//Emp@example.com

//        [Phone]
//        public string PhoneNumber { get; set; }

//        [NotMapped]
//        public double TotalSalary { get; set; }
//        public string Password { get; set; }

//    }

//    class Employee
//    {
//        public string EmpId { get; set; }
//        public string Name { get; set; }
//        public int? Age { get; set; }
//        public string Email { get; set; }
//        public double Salary { get; set; }
//        public DateTime DateOfCreation { get; set; }

//    }

//}