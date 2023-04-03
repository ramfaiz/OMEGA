using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class HrVwLeaveEntryEmpList
{
    [Column("emp_ref_no")]
    public long EmpRefNo { get; set; }

    [Column("emp_ref_code")]
    [StringLength(100)]
    public string? EmpRefCode { get; set; }

    [Column("emp_first_name")]
    [StringLength(50)]
    public string? EmpFirstName { get; set; }

    [Column("emp_middle_name")]
    [StringLength(50)]
    public string? EmpMiddleName { get; set; }

    [Column("emp_last_name")]
    [StringLength(50)]
    public string? EmpLastName { get; set; }

    [Column("employee_type")]
    public short? EmployeeType { get; set; }

    [Column("gender")]
    public short? Gender { get; set; }

    [Column("empt_detail_ref_no")]
    public long EmptDetailRefNo { get; set; }

    [Column("empt_desig_id")]
    public int? EmptDesigId { get; set; }

    [Column("empt_start_date", TypeName = "datetime")]
    public DateTime? EmptStartDate { get; set; }

    [Column("empt_end_date", TypeName = "datetime")]
    public DateTime? EmptEndDate { get; set; }

    [Column("empt_status")]
    public int? EmptStatus { get; set; }

    [Column("is_verfied")]
    public byte? IsVerfied { get; set; }

    [Column("LM_LOCATION_ID")]
    public int LmLocationId { get; set; }

    [Column("LM_LOCATION_NAME")]
    [StringLength(240)]
    [Unicode(false)]
    public string? LmLocationName { get; set; }

    [Column("SM_STATION_ID")]
    public int SmStationId { get; set; }

    [Column("SM_STATION_NAME")]
    [StringLength(240)]
    [Unicode(false)]
    public string? SmStationName { get; set; }

    [Column("dept_id")]
    public short DeptId { get; set; }

    [Column("Department_Name")]
    [StringLength(240)]
    public string? DepartmentName { get; set; }

    [Column("Emp_Designation")]
    [StringLength(240)]
    public string? EmpDesignation { get; set; }

    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("residence_country")]
    public long? ResidenceCountry { get; set; }

    [Column("empt_set_ref_no")]
    public long? EmptSetRefNo { get; set; }

    [Column("file_name")]
    [StringLength(100)]
    public string? FileName { get; set; }

    [Column("file_path")]
    [StringLength(100)]
    public string? FilePath { get; set; }

    [Column("supervisor_id")]
    public long? SupervisorId { get; set; }

    [Column("email_id")]
    [StringLength(50)]
    public string? EmailId { get; set; }
}
