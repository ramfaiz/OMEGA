using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class HrVwDesignationlist
{
    [Column("designation_id")]
    public short DesignationId { get; set; }

    [Column("designation_code")]
    [StringLength(15)]
    public string? DesignationCode { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("is_default")]
    public byte? IsDefault { get; set; }

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

    [Column("Dept_Name")]
    [StringLength(240)]
    public string? DeptName { get; set; }

    [Column("dept_code")]
    [StringLength(15)]
    [Unicode(false)]
    public string DeptCode { get; set; } = null!;
}
