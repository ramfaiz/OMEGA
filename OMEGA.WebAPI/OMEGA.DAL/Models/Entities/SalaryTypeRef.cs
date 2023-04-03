using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("SALARY_TYPE_REF")]
public partial class SalaryTypeRef
{
    [Key]
    [Column("Sal_Type_Id")]
    public int SalTypeId { get; set; }

    [Column("Sal_Type_Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string SalTypeCode { get; set; } = null!;

    [Column("Sal_Type")]
    public short SalType { get; set; }

    [Column("Is_Default")]
    public byte? IsDefault { get; set; }

    [Column("Created_By")]
    public short? CreatedBy { get; set; }

    [Column("Created_Date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("Updated_By")]
    public short? UpdatedBy { get; set; }

    [Column("Updated_Date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("Delete_Status")]
    public byte? DeleteStatus { get; set; }
}
