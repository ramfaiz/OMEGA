using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class HrVwEmpOrderPriority
{
    [Column("empt_comp_id")]
    public int? EmptCompId { get; set; }

    [Column("empt_org_id")]
    public int? EmptOrgId { get; set; }

    [Column("emp_ref_no")]
    public int? EmpRefNo { get; set; }

    [Column("empt_ref_no")]
    public long? EmptRefNo { get; set; }

    [Column("empt_detail_ref_no")]
    public long EmptDetailRefNo { get; set; }

    [StringLength(50)]
    public string? EmpName { get; set; }

    [Column("emp_ref_code")]
    [StringLength(100)]
    public string? EmpRefCode { get; set; }

    [Column("file_path")]
    [StringLength(100)]
    public string? FilePath { get; set; }

    [Column("file_name")]
    [StringLength(100)]
    public string? FileName { get; set; }

    [Column("emp_last_name")]
    [StringLength(50)]
    public string? EmpLastName { get; set; }

    [Column("empt_status")]
    public int? EmptStatus { get; set; }

    [StringLength(240)]
    public string? Department { get; set; }

    [StringLength(240)]
    public string? Designation { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }
}
