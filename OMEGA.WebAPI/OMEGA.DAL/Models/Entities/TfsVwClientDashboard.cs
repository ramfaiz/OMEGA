using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class TfsVwClientDashboard
{
    [Column("ref_no")]
    public int? RefNo { get; set; }

    [Column("full_name")]
    public string? FullName { get; set; }

    [Column("assign")]
    public int? Assign { get; set; }

    [Column("unassign")]
    public int? Unassign { get; set; }

    [Column("unassign_due")]
    public int? UnassignDue { get; set; }

    public int? Total { get; set; }

    [Column("update_time", TypeName = "datetime")]
    public DateTime? UpdateTime { get; set; }
}
