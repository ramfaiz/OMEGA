using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class HrVwEmpDetail
{
    [Column("LM_LOCATION_ID")]
    public int LmLocationId { get; set; }

    [Column("CM_COMPANY_ID")]
    public long CmCompanyId { get; set; }

    [Column("dept_id")]
    public short DeptId { get; set; }

    [Column("emp_ref_no")]
    public long EmpRefNo { get; set; }

    [Column("emp_ref_code")]
    [StringLength(100)]
    public string? EmpRefCode { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }
}
