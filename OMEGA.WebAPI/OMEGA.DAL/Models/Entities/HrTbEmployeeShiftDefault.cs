using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("HR_TB_EMPLOYEE_SHIFT_DEFAULT")]
public partial class HrTbEmployeeShiftDefault
{
    [Key]
    [Column("dfl_ref_no")]
    public long DflRefNo { get; set; }

    [Column("week_day_id")]
    public byte? WeekDayId { get; set; }

    [Column("night_shift")]
    public short? NightShift { get; set; }

    [Column("shift_id")]
    public int? ShiftId { get; set; }
}
