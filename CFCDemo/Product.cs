using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFCDemo
{
    [Table("KProduct")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "ProductName最大長度為50"), MinLength(2)]
        [Column("ProductName")]
        [Index("ProductNameIndex", 1, IsUnique = true)]
        public string Name { get; set; }
        [Column("ListPirce", TypeName = "Money")]
        public int? UnitPrice { get; set; }
        [Index("CategoryIndex", 2)]
        public int Category { get; set; }
        [NotMapped]
        public decimal SPrice { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Created { get; set; }
    }
}
