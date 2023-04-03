using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("LEAVE_COMPOFF_DAYS")]
public partial class LeaveCompoffDay
{
    [Key]
    [Column("compoff_id")]
    public int CompoffId { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("compoff_date", TypeName = "date")]
    public DateTime? CompoffDate { get; set; }

    [Column("is_approved")]
    public short? IsApproved { get; set; }

    [Column("is_viewed_spr")]
    public short? IsViewedSpr { get; set; }
}
