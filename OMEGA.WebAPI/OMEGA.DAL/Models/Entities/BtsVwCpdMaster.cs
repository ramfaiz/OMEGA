using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class BtsVwCpdMaster
{
    [Column("ref_no")]
    public long RefNo { get; set; }

    [Column("full_name")]
    [StringLength(100)]
    public string? FullName { get; set; }

    [Column("report_to")]
    public long? ReportTo { get; set; }

    [Column("report_to_name")]
    [StringLength(100)]
    public string? ReportToName { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("role_id")]
    public byte? RoleId { get; set; }
}
