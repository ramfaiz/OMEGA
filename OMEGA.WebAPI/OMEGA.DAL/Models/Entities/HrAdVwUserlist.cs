using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class HrAdVwUserlist
{
    [Column("user_id")]
    public long UserId { get; set; }

    [Column("is_admin_user")]
    public bool? IsAdminUser { get; set; }

    [Column("is_guest_user")]
    public bool? IsGuestUser { get; set; }

    [Column("active_date", TypeName = "datetime")]
    public DateTime? ActiveDate { get; set; }

    [Column("inactive_date", TypeName = "datetime")]
    public DateTime? InactiveDate { get; set; }

    [Column("user_name")]
    [StringLength(50)]
    public string? UserName { get; set; }
}
