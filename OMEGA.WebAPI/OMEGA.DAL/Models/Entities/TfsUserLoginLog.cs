using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_USER_LOGIN_LOG")]
public partial class TfsUserLoginLog
{
    [Column("sl_no")]
    public int SlNo { get; set; }

    [Column("emp_id")]
    [StringLength(10)]
    public string EmpId { get; set; } = null!;

    [Column("login_time", TypeName = "datetime")]
    public DateTime? LoginTime { get; set; }

    [Column("logout_time", TypeName = "datetime")]
    public DateTime? LogoutTime { get; set; }

    [Column("ip_address")]
    [StringLength(50)]
    public string? IpAddress { get; set; }
}
