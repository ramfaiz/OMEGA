using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class TfsVwEmployeeDetail
{
    [Column("emp_ref_no")]
    public long EmpRefNo { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("role_id")]
    public long? RoleId { get; set; }

    [Column("emp_full_name")]
    [StringLength(101)]
    public string? EmpFullName { get; set; }

    [Column("emp_comp_id")]
    public long? EmpCompId { get; set; }
}
