using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class CmVwCurrentUser
{
    [Column("session_id")]
    public long? SessionId { get; set; }

    [Column("user_id")]
    public long UserId { get; set; }

    [Column("user_name")]
    [StringLength(50)]
    public string? UserName { get; set; }

    [Column("emp_ref_no")]
    public long EmpRefNo { get; set; }

    [Column("emp_ref_code")]
    [StringLength(100)]
    public string? EmpRefCode { get; set; }

    [Column("emp_first_name")]
    [StringLength(101)]
    public string? EmpFirstName { get; set; }

    [Column("loggedin_status")]
    public byte? LoggedinStatus { get; set; }

    [Column("trans_date", TypeName = "date")]
    public DateTime? TransDate { get; set; }
}
