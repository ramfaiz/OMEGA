using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class RptVwEmployeePersonalDetailL
{
    [Column("emp_ref_code")]
    [StringLength(100)]
    public string? EmpRefCode { get; set; }

    [Column("pan_card_no")]
    [StringLength(20)]
    public string? PanCardNo { get; set; }

    [Column("aadhar_no")]
    [StringLength(20)]
    public string? AadharNo { get; set; }

    [Column("blood_group")]
    [StringLength(100)]
    [Unicode(false)]
    public string? BloodGroup { get; set; }

    [Column("date_of_birth")]
    [StringLength(30)]
    [Unicode(false)]
    public string? DateOfBirth { get; set; }

    [Column("gender")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Gender { get; set; }

    [Column("maritial_status")]
    [StringLength(100)]
    [Unicode(false)]
    public string? MaritialStatus { get; set; }

    [Column("religion")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Religion { get; set; }

    [Column("mobile_number")]
    [StringLength(50)]
    public string? MobileNumber { get; set; }

    [Column("local_address")]
    [StringLength(285)]
    public string? LocalAddress { get; set; }

    [Column("foreign_address")]
    [StringLength(285)]
    public string? ForeignAddress { get; set; }

    [Column("emergency_contact")]
    [StringLength(309)]
    public string? EmergencyContact { get; set; }

    [Column("department")]
    [StringLength(240)]
    public string? Department { get; set; }

    [Column("designation")]
    [StringLength(240)]
    public string? Designation { get; set; }

    [Column("emp_ref_no")]
    public long EmpRefNo { get; set; }

    [Column("employee_name")]
    [StringLength(152)]
    public string? EmployeeName { get; set; }

    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("email_id")]
    [StringLength(50)]
    public string? EmailId { get; set; }
}
