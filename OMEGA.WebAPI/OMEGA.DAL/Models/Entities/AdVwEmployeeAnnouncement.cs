using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class AdVwEmployeeAnnouncement
{
    [Column("emp_ref_code")]
    [StringLength(100)]
    public string? EmpRefCode { get; set; }

    [Column("emp_first_name")]
    [StringLength(50)]
    public string? EmpFirstName { get; set; }

    [Column("emp_last_name")]
    [StringLength(50)]
    public string? EmpLastName { get; set; }

    [Column("emp_ref_no")]
    public long EmpRefNo { get; set; }

    [Column("empt_comp_id")]
    public int? EmptCompId { get; set; }

    [Column("LM_LOCATION_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string LmLocationCode { get; set; } = null!;

    [Column("LM_LOCATION_NAME")]
    [StringLength(240)]
    [Unicode(false)]
    public string? LmLocationName { get; set; }

    [Column("empt_org_id")]
    public int? EmptOrgId { get; set; }

    [Column("SM_STATION_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string SmStationCode { get; set; } = null!;

    [Column("SM_STATION_NAME")]
    [StringLength(240)]
    [Unicode(false)]
    public string? SmStationName { get; set; }

    [Column("display_value")]
    [StringLength(240)]
    public string? DisplayValue { get; set; }

    [Column("dept_code")]
    [StringLength(15)]
    [Unicode(false)]
    public string DeptCode { get; set; } = null!;

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("dept_id")]
    public short DeptId { get; set; }

    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("empt_status")]
    public int? EmptStatus { get; set; }

    [Column("LM_LOCATION_ID")]
    public int LmLocationId { get; set; }

    [Column("SM_STATION_ID")]
    public int SmStationId { get; set; }

    public short Expr1 { get; set; }

    public int? Expr2 { get; set; }
}
