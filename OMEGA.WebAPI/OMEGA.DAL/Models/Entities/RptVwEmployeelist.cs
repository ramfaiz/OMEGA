using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class RptVwEmployeelist
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

    [Column("title")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Title { get; set; }

    [Column("employee_type")]
    [StringLength(100)]
    [Unicode(false)]
    public string? EmployeeType { get; set; }

    [Column("maritial_status")]
    [StringLength(100)]
    [Unicode(false)]
    public string? MaritialStatus { get; set; }

    [Column("nationality")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Nationality { get; set; }

    [Column("religion")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Religion { get; set; }

    [Column("gender")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Gender { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("foreign_address")]
    [StringLength(285)]
    public string? ForeignAddress { get; set; }

    [Column("foreign_street")]
    [StringLength(50)]
    public string? ForeignStreet { get; set; }

    [Column("foreign_state")]
    [StringLength(50)]
    public string? ForeignState { get; set; }

    [Column("foreign_postal_code")]
    public int? ForeignPostalCode { get; set; }

    [Column("email_id")]
    [StringLength(50)]
    public string? EmailId { get; set; }

    [Column("foreign_unit")]
    [StringLength(50)]
    public string? ForeignUnit { get; set; }

    [Column("mobile_number")]
    [StringLength(50)]
    public string? MobileNumber { get; set; }

    [Column("phone_number")]
    [StringLength(50)]
    public string? PhoneNumber { get; set; }

    [Column("birth_place")]
    [StringLength(50)]
    public string? BirthPlace { get; set; }

    [Column("local_address")]
    [StringLength(285)]
    public string? LocalAddress { get; set; }

    [Column("local_postal_code")]
    public int? LocalPostalCode { get; set; }

    [Column("local_street")]
    [StringLength(50)]
    public string? LocalStreet { get; set; }

    [Column("highest_qualification")]
    [StringLength(100)]
    [Unicode(false)]
    public string? HighestQualification { get; set; }

    [Column("emp_highest_qual_remarks")]
    [StringLength(500)]
    public string? EmpHighestQualRemarks { get; set; }
}
