using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("MLS_ASSIGN_DASHBOARD")]
public partial class MlsAssignDashboard
{
    [Column("mls_id")]
    public int? MlsId { get; set; }

    [Column("mls_name")]
    public string? MlsName { get; set; }

    [Column("assign")]
    public int? Assign { get; set; }

    [Column("unassign")]
    public int? Unassign { get; set; }

    [Column("unassign_due")]
    public int? UnassignDue { get; set; }
}
