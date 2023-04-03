using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("DEPARTMENT_REF")]
public partial class DepartmentRef
{
    [Key]
    [Column("dept_id")]
    public short DeptId { get; set; }

    [Column("dept_code")]
    [StringLength(15)]
    [Unicode(false)]
    public string DeptCode { get; set; } = null!;

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

    [Column("location_id")]
    public int? LocationId { get; set; }

    [Column("station_id")]
    public int? StationId { get; set; }

    [Column("comp_dept_status")]
    public byte? CompDeptStatus { get; set; }
}
