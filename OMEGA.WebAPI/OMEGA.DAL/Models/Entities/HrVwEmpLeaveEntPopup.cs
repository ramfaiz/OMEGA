using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class HrVwEmpLeaveEntPopup
{
    [Column("EM_EMPLOYEE_ID")]
    public long EmEmployeeId { get; set; }

    [Column("EM_EMPLOYEE_CODE")]
    [StringLength(100)]
    public string? EmEmployeeCode { get; set; }

    [Column("EM_EMPLOYEE_NAME")]
    [StringLength(50)]
    public string? EmEmployeeName { get; set; }

    [Column("LM_LOCATION_NAME")]
    [StringLength(240)]
    [Unicode(false)]
    public string? LmLocationName { get; set; }

    [Column("SM_STATION_NAME")]
    [StringLength(240)]
    [Unicode(false)]
    public string? SmStationName { get; set; }

    [Column("DEPT_NAME")]
    [StringLength(240)]
    public string? DeptName { get; set; }

    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("EM_DESIGNATION_ID")]
    public int? EmDesignationId { get; set; }

    [Column("DM_DESG_DESC")]
    [StringLength(240)]
    public string? DmDesgDesc { get; set; }

    [Column("empt_detail_ref_no")]
    public long EmptDetailRefNo { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("LM_LOCATION_ID")]
    public int LmLocationId { get; set; }

    [Column("SM_STATION_ID")]
    public int SmStationId { get; set; }

    [Column("EM_DEPT_ID")]
    public short EmDeptId { get; set; }

    [Column("empt_status")]
    public int? EmptStatus { get; set; }

    [Column("station_id")]
    public int StationId { get; set; }

    [Column("email_id")]
    [StringLength(50)]
    public string? EmailId { get; set; }
}
