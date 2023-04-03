using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("HR_TB_EMPLOYEE_LEAVE")]
public partial class HrTbEmployeeLeave
{
    [Key]
    [Column("leave_ref_no")]
    public long LeaveRefNo { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("year")]
    public int? Year { get; set; }

    [Column("Casual_taken")]
    public double? CasualTaken { get; set; }

    [Column("Sick_taken")]
    public double? SickTaken { get; set; }

    [Column("Maternity_taken")]
    public double? MaternityTaken { get; set; }

    [Column("Paternity_taken")]
    public double? PaternityTaken { get; set; }

    [Column("CompOff_taken")]
    public double? CompOffTaken { get; set; }

    [Column("OnDuty_taken")]
    public double? OnDutyTaken { get; set; }

    [Column("LossofPay_taken")]
    public double? LossofPayTaken { get; set; }

    [Column("Compassionate_taken")]
    public double? CompassionateTaken { get; set; }

    [Column("Casual_total")]
    public double? CasualTotal { get; set; }

    [Column("Sick_total")]
    public double? SickTotal { get; set; }

    [Column("Maternity_total")]
    public double? MaternityTotal { get; set; }

    [Column("Paternity_total")]
    public double? PaternityTotal { get; set; }

    [Column("CompOff_total")]
    public double? CompOffTotal { get; set; }
}
