using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class HrVwLeaveDateCheck
{
    [Column("leave_ref_no")]
    public long LeaveRefNo { get; set; }

    [Column("leave_empt_detail_ref_no")]
    public long? LeaveEmptDetailRefNo { get; set; }

    [Column("leave_ddate", TypeName = "datetime")]
    public DateTime? LeaveDdate { get; set; }

    [Column("delete_status")]
    public int? DeleteStatus { get; set; }

    [Column("leave_status")]
    public int? LeaveStatus { get; set; }
}
