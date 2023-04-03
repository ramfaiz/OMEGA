using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class HrVwEmployeeCompoff
{
    [Column("compoff_id")]
    public int CompoffId { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("employee_name")]
    [StringLength(152)]
    public string? EmployeeName { get; set; }

    [Column("compoff_date", TypeName = "date")]
    public DateTime? CompoffDate { get; set; }

    [Column("supervisor_id")]
    public long? SupervisorId { get; set; }

    [Column("is_approved")]
    public short? IsApproved { get; set; }

    [Column("is_viewed_spr")]
    public short? IsViewedSpr { get; set; }
}
