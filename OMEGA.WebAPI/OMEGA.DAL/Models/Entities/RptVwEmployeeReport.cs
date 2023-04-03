using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class RptVwEmployeeReport
{
    [Column("emp_ref_no")]
    public long EmpRefNo { get; set; }

    [Column("emp_ref_code")]
    [StringLength(100)]
    public string? EmpRefCode { get; set; }

    [Column("employee_name")]
    [StringLength(253)]
    public string? EmployeeName { get; set; }

    [Column("date_of_birth")]
    [StringLength(30)]
    [Unicode(false)]
    public string? DateOfBirth { get; set; }

    [Column("employee_type")]
    [StringLength(100)]
    [Unicode(false)]
    public string? EmployeeType { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("foreign_address")]
    [StringLength(285)]
    public string? ForeignAddress { get; set; }

    [Column("email_id")]
    [StringLength(50)]
    public string? EmailId { get; set; }

    [Column("mobile_number")]
    [StringLength(50)]
    public string? MobileNumber { get; set; }

    [Column("nationality")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Nationality { get; set; }

    [Column("phone_number")]
    [StringLength(50)]
    public string? PhoneNumber { get; set; }

    [Column("religion")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Religion { get; set; }

    [Column("gender")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Gender { get; set; }

    [Column("maritial_status")]
    [StringLength(100)]
    [Unicode(false)]
    public string? MaritialStatus { get; set; }

    [Column("organisation")]
    [StringLength(240)]
    [Unicode(false)]
    public string? Organisation { get; set; }

    [Column("company")]
    [StringLength(240)]
    [Unicode(false)]
    public string? Company { get; set; }

    [Column("department")]
    [StringLength(240)]
    public string? Department { get; set; }

    [Column("designation")]
    [StringLength(240)]
    public string? Designation { get; set; }

    [Column("qualification")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Qualification { get; set; }

    [Column("specialization")]
    [StringLength(500)]
    public string? Specialization { get; set; }
}
