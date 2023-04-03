using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class RptVwEmployeeDetail
{
    [Column("emp_ref_no")]
    public long EmpRefNo { get; set; }

    [Column("emp_ref_code")]
    [StringLength(100)]
    public string? EmpRefCode { get; set; }

    [Column("employee_name")]
    [StringLength(393)]
    public string? EmployeeName { get; set; }

    [Column("date_of_birth")]
    [StringLength(30)]
    [Unicode(false)]
    public string? DateOfBirth { get; set; }

    [Column("employee_type")]
    [StringLength(240)]
    public string EmployeeType { get; set; } = null!;

    [Column("blood_group")]
    [StringLength(240)]
    public string BloodGroup { get; set; } = null!;

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

    [Column("country")]
    [StringLength(240)]
    [Unicode(false)]
    public string? Country { get; set; }

    [Column("foreign_state")]
    [StringLength(50)]
    public string? ForeignState { get; set; }

    [Column("foreign_street")]
    [StringLength(50)]
    public string? ForeignStreet { get; set; }

    [Column("foreign_postal_code")]
    public int? ForeignPostalCode { get; set; }

    [Column("maritial_status")]
    [StringLength(240)]
    public string MaritialStatus { get; set; } = null!;

    [Column("confirmation_date", TypeName = "datetime")]
    public DateTime? ConfirmationDate { get; set; }

    [Column("enumeration_key")]
    [StringLength(160)]
    public string EnumerationKey { get; set; } = null!;

    [Column("enumeration_key1")]
    [StringLength(160)]
    public string EnumerationKey1 { get; set; } = null!;

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("blood_group_ek")]
    [StringLength(160)]
    public string BloodGroupEk { get; set; } = null!;

    [Column("email_id")]
    [StringLength(50)]
    public string? EmailId { get; set; }

    [Column("foreign_level")]
    [StringLength(50)]
    public string? ForeignLevel { get; set; }

    [Column("foreign_unit")]
    [StringLength(50)]
    public string? ForeignUnit { get; set; }

    [Column("maritial_status_ek")]
    [StringLength(160)]
    public string MaritialStatusEk { get; set; } = null!;

    [Column("mobile_number")]
    [StringLength(50)]
    public string? MobileNumber { get; set; }

    [Column("phone_number")]
    [StringLength(50)]
    public string? PhoneNumber { get; set; }

    [Column("birth_place")]
    [StringLength(50)]
    public string? BirthPlace { get; set; }

    [Column("local_postal_code")]
    public int? LocalPostalCode { get; set; }

    [Column("local_street")]
    [StringLength(50)]
    public string? LocalStreet { get; set; }

    [Column("religion_ek")]
    [StringLength(160)]
    public string ReligionEk { get; set; } = null!;

    [Column("religion")]
    [StringLength(240)]
    public string Religion { get; set; } = null!;
}
