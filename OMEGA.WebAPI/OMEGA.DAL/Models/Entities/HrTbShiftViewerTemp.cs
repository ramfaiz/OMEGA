using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("HR_TB_SHIFT_VIEWER_TEMP")]
public partial class HrTbShiftViewerTemp
{
    [Key]
    [Column("temp_id")]
    public long TempId { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("day1")]
    [StringLength(50)]
    public string? Day1 { get; set; }

    [Column("day2")]
    [StringLength(50)]
    public string? Day2 { get; set; }

    [Column("day3")]
    [StringLength(50)]
    public string? Day3 { get; set; }

    [Column("day4")]
    [StringLength(50)]
    public string? Day4 { get; set; }

    [Column("day5")]
    [StringLength(50)]
    public string? Day5 { get; set; }

    [Column("day6")]
    [StringLength(50)]
    public string? Day6 { get; set; }

    [Column("day7")]
    [StringLength(50)]
    public string? Day7 { get; set; }

    [Column("shift_id")]
    public byte? ShiftId { get; set; }

    [Column("emp_first_name")]
    [StringLength(500)]
    public string? EmpFirstName { get; set; }
}
