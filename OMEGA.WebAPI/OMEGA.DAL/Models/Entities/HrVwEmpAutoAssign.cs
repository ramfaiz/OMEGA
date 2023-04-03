using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class HrVwEmpAutoAssign
{
    [Column("emp_ref_no")]
    public long EmpRefNo { get; set; }

    [Column("emp_ref_code")]
    [StringLength(100)]
    public string? EmpRefCode { get; set; }

    [Column("emp_first_name")]
    [StringLength(50)]
    public string? EmpFirstName { get; set; }

    [Column("emp_last_name")]
    [StringLength(50)]
    public string? EmpLastName { get; set; }

    [Column("timeclock_id")]
    public long? TimeclockId { get; set; }

    [Column("user_id")]
    public long? UserId { get; set; }

    [Column("loggedin_status")]
    public byte? LoggedinStatus { get; set; }

    [Column("trans_date", TypeName = "date")]
    public DateTime? TransDate { get; set; }

    [Column("empt_desig_id")]
    public int? EmptDesigId { get; set; }
}
