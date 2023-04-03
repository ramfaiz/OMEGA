using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class GlVwDepartmentMaster
{
    [Column("dept_id")]
    public short DeptId { get; set; }

    [Column("dept_code")]
    [StringLength(15)]
    [Unicode(false)]
    public string DeptCode { get; set; } = null!;

    [Column("short_display")]
    [StringLength(15)]
    public string? ShortDisplay { get; set; }

    [Column("display_value")]
    [StringLength(240)]
    public string? DisplayValue { get; set; }

    [Column("is_default")]
    public byte? IsDefault { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("location_id")]
    public int? LocationId { get; set; }

    [Column("station_id")]
    public int? StationId { get; set; }

    [Column("LM_LOCATION_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string LmLocationCode { get; set; } = null!;

    [Column("LM_LOCATION_NAME")]
    [StringLength(240)]
    [Unicode(false)]
    public string? LmLocationName { get; set; }

    [Column("SM_STATION_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SmStationCode { get; set; }

    [Column("SM_STATION_NAME")]
    [StringLength(240)]
    [Unicode(false)]
    public string? SmStationName { get; set; }

    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("SM_STATION_ID")]
    public int? SmStationId { get; set; }

    [Column("LM_LOCATION_ID")]
    public int LmLocationId { get; set; }
}
