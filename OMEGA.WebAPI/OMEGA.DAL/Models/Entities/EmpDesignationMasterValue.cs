using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[PrimaryKey("DesignationId", "LanguageCode")]
[Table("EMP_DESIGNATION_MASTER_VALUES")]
public partial class EmpDesignationMasterValue
{
    [Key]
    [Column("designation_id")]
    public short DesignationId { get; set; }

    [Key]
    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("short_display")]
    [StringLength(15)]
    public string? ShortDisplay { get; set; }

    [Column("display_value")]
    [StringLength(240)]
    public string? DisplayValue { get; set; }

    [Column("department_id")]
    public short? DepartmentId { get; set; }

    [ForeignKey("DesignationId")]
    [InverseProperty("EmpDesignationMasterValues")]
    public virtual EmpDesignationMasterRef Designation { get; set; } = null!;
}
