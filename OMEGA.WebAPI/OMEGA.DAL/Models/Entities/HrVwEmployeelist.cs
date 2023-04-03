using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class HrVwEmployeelist
{
    [Column("EM_EMPLOYEE_ID")]
    public long EmEmployeeId { get; set; }

    [Column("EM_EMPLOYEE_CODE")]
    [StringLength(100)]
    public string? EmEmployeeCode { get; set; }

    [Column("EM_EMPLOYEE_NAME")]
    [StringLength(50)]
    public string? EmEmployeeName { get; set; }

    [Column("EM_EMP_FULL_NAME")]
    [StringLength(50)]
    public string? EmEmpFullName { get; set; }

    [Column("EM_STATION_ID")]
    public int? EmStationId { get; set; }

    [Column("empt_comp_id")]
    public int? EmptCompId { get; set; }

    [Column("LM_LOCATION_NAME")]
    [StringLength(240)]
    [Unicode(false)]
    public string? LmLocationName { get; set; }

    [Column("SM_STATION_NAME")]
    [StringLength(240)]
    [Unicode(false)]
    public string? SmStationName { get; set; }

    [Column("EM_DEPT_ID")]
    public short EmDeptId { get; set; }

    [Column("dept_name")]
    [StringLength(240)]
    public string? DeptName { get; set; }

    [Column("EM_DELETESTATUS")]
    public byte? EmDeletestatus { get; set; }

    [Column("empt_status")]
    public int? EmptStatus { get; set; }

    [Column("mobile_number")]
    [StringLength(50)]
    public string? MobileNumber { get; set; }

    [Column("local_state")]
    [StringLength(50)]
    public string? LocalState { get; set; }

    [Column("local_street")]
    [StringLength(50)]
    public string? LocalStreet { get; set; }

    [Column("email_id")]
    [StringLength(50)]
    public string? EmailId { get; set; }

    [Column("em_location_id")]
    public int? EmLocationId { get; set; }

    [Column("EM_DESIGNATION_ID")]
    public short? EmDesignationId { get; set; }

    [Column("Designation_Name")]
    [StringLength(240)]
    public string? DesignationName { get; set; }

    [Column("designation_code")]
    [StringLength(15)]
    public string? DesignationCode { get; set; }

    [Column("file_name")]
    [StringLength(100)]
    public string? FileName { get; set; }

    [Column("file_path")]
    [StringLength(100)]
    public string? FilePath { get; set; }

    [Column("empt_set_ref_no")]
    public long? EmptSetRefNo { get; set; }

    [Column("empt_detail_ref_no")]
    public long EmptDetailRefNo { get; set; }

    [Column("night_shift")]
    public short? NightShift { get; set; }

    [Column("gender")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Gender { get; set; }

    [Column("empt_start_date", TypeName = "datetime")]
    public DateTime? EmptStartDate { get; set; }

    [Column("empt_end_date", TypeName = "datetime")]
    public DateTime? EmptEndDate { get; set; }

    [Column("bank_account_no")]
    [StringLength(50)]
    public string? BankAccountNo { get; set; }

    [Column("resignation_date", TypeName = "datetime")]
    public DateTime? ResignationDate { get; set; }

    [Column("resignation_reason")]
    [StringLength(500)]
    public string? ResignationReason { get; set; }

    [Column("user_id")]
    public long? UserId { get; set; }

    [Column("ref_no")]
    public long? RefNo { get; set; }

    [Column("username")]
    [StringLength(500)]
    public string? Username { get; set; }

    [Column("password")]
    [StringLength(500)]
    public string? Password { get; set; }

    [Column("password_expiry", TypeName = "datetime")]
    public DateTime? PasswordExpiry { get; set; }

    [Column("role_id")]
    public long? RoleId { get; set; }

    [Column("access_level")]
    public byte? AccessLevel { get; set; }

    [Column("active_date", TypeName = "datetime")]
    public DateTime? ActiveDate { get; set; }

    [Column("inactive_date", TypeName = "datetime")]
    public DateTime? InactiveDate { get; set; }

    [Column("status_id")]
    public byte? StatusId { get; set; }

    [Column("role_name")]
    [StringLength(500)]
    public string? RoleName { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("language_code")]
    public short? LanguageCode { get; set; }
}
