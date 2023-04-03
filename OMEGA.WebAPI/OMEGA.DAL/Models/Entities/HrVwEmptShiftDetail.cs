using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class HrVwEmptShiftDetail
{
    [Column("emp_ref_no")]
    public long EmpRefNo { get; set; }

    [Column("emp_first_name")]
    [StringLength(50)]
    public string? EmpFirstName { get; set; }

    [Column("empt_detail_ref_no")]
    public long EmptDetailRefNo { get; set; }

    [Column("shift_id")]
    public long ShiftId { get; set; }

    [Column("shift_name")]
    [StringLength(500)]
    public string? ShiftName { get; set; }

    [Column("empt_set_ref_no")]
    public long? EmptSetRefNo { get; set; }
}
