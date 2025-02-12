using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    //Data Annotation
    [Table("Department",Schema ="dbo")]
    internal class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        public int InstructorId { get; set; }

        [Required]
        [Column("DeptName",TypeName="varchar")]
        [MaxLength(50)]
        public string Name { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime HiringDate { get; set; }


    }
}
