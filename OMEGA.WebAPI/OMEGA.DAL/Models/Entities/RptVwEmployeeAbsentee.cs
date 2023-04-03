using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class RptVwEmployeeAbsentee
{
    [Column("empt_desig_id")]
    public int? EmptDesigId { get; set; }

    [Column("designation")]
    [StringLength(240)]
    public string? Designation { get; set; }

    [Column("empt_status")]
    public int? EmptStatus { get; set; }

    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("emp_ref_code")]
    [StringLength(100)]
    public string? EmpRefCode { get; set; }

    [Column("employee_name")]
    [StringLength(101)]
    public string? EmployeeName { get; set; }

    [Column("temp_id")]
    public long? TempId { get; set; }

    [Column("month_id")]
    public byte? MonthId { get; set; }

    [Column("year")]
    public long? Year { get; set; }

    [Column("d1")]
    public byte? D1 { get; set; }

    [Column("d2")]
    public byte? D2 { get; set; }

    [Column("d3")]
    public byte? D3 { get; set; }

    [Column("d4")]
    public byte? D4 { get; set; }

    [Column("d5")]
    public byte? D5 { get; set; }

    [Column("d6")]
    public byte? D6 { get; set; }

    [Column("d7")]
    public byte? D7 { get; set; }

    [Column("d8")]
    public byte? D8 { get; set; }

    [Column("d9")]
    public byte? D9 { get; set; }

    [Column("d10")]
    public byte? D10 { get; set; }

    [Column("d11")]
    public byte? D11 { get; set; }

    [Column("d12")]
    public byte? D12 { get; set; }

    [Column("d13")]
    public byte? D13 { get; set; }

    [Column("d14")]
    public byte? D14 { get; set; }

    [Column("d15")]
    public byte? D15 { get; set; }

    [Column("d16")]
    public byte? D16 { get; set; }

    [Column("d17")]
    public byte? D17 { get; set; }

    [Column("d18")]
    public byte? D18 { get; set; }

    [Column("d19")]
    public byte? D19 { get; set; }

    [Column("d20")]
    public byte? D20 { get; set; }

    [Column("d21")]
    public byte? D21 { get; set; }

    [Column("d22")]
    public byte? D22 { get; set; }

    [Column("d23")]
    public byte? D23 { get; set; }

    [Column("d24")]
    public byte? D24 { get; set; }

    [Column("d25")]
    public byte? D25 { get; set; }

    [Column("d26")]
    public byte? D26 { get; set; }

    [Column("d27")]
    public byte? D27 { get; set; }

    [Column("d28")]
    public byte? D28 { get; set; }

    [Column("d29")]
    public byte? D29 { get; set; }

    [Column("d30")]
    public byte? D30 { get; set; }

    [Column("d31")]
    public byte? D31 { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("emp_ref_no")]
    public long EmpRefNo { get; set; }
}
