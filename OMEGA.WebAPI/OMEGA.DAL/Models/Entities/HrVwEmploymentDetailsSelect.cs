using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class HrVwEmploymentDetailsSelect
{
    [Column("emp_ref_no")]
    public int? EmpRefNo { get; set; }

    [Column("empt_dept_id")]
    public int? EmptDeptId { get; set; }

    [Column("empt_desig_id")]
    public int? EmptDesigId { get; set; }

    [Column("probation_period")]
    public int? ProbationPeriod { get; set; }

    [Column("empt_type")]
    public int? EmptType { get; set; }

    [Column("empt_start_date", TypeName = "datetime")]
    public DateTime? EmptStartDate { get; set; }

    [Column("empt_end_date", TypeName = "datetime")]
    public DateTime? EmptEndDate { get; set; }

    [Column("empt_status")]
    public int? EmptStatus { get; set; }

    [Column("notice_period")]
    public int? NoticePeriod { get; set; }

    [Column("notice_period_in")]
    [StringLength(4)]
    public string? NoticePeriodIn { get; set; }

    [Column("work_day_type")]
    public int? WorkDayType { get; set; }

    [Column("supervisor_id")]
    public long? SupervisorId { get; set; }

    [Column("approver_id")]
    public long? ApproverId { get; set; }

    [Column("night_shift")]
    public short? NightShift { get; set; }

    [Column("emp_supr_name")]
    [StringLength(101)]
    public string? EmpSuprName { get; set; }

    [Column("emp_appr_name")]
    [StringLength(101)]
    public string? EmpApprName { get; set; }

    [Column("empt_ref_no")]
    public long? EmptRefNo { get; set; }

    [Column("resignation_date", TypeName = "datetime")]
    public DateTime? ResignationDate { get; set; }

    [Column("resignation_reason")]
    [StringLength(500)]
    public string? ResignationReason { get; set; }
}
