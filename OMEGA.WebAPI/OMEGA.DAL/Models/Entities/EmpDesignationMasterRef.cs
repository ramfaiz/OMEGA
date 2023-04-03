using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("EMP_DESIGNATION_MASTER_REF")]
public partial class EmpDesignationMasterRef
{
    [Key]
    [Column("designation_id")]
    public short DesignationId { get; set; }

    [Column("designation_code")]
    [StringLength(15)]
    public string? DesignationCode { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("updated_by")]
    public short? UpdatedBy { get; set; }

    [Column("created_date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("created_by")]
    public short? CreatedBy { get; set; }

    [Column("is_default")]
    public byte? IsDefault { get; set; }

    [InverseProperty("Designation")]
    public virtual ICollection<EmpDesignationMasterValue> EmpDesignationMasterValues { get; } = new List<EmpDesignationMasterValue>();
}
