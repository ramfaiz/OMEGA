using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class GlVwBindDepartment
{
    [Column("display_value")]
    [StringLength(240)]
    public string? DisplayValue { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("dept_code")]
    [StringLength(15)]
    [Unicode(false)]
    public string DeptCode { get; set; } = null!;

    [Column("is_default")]
    public byte? IsDefault { get; set; }

    [Column("dept_id")]
    public short DeptId { get; set; }

    [Column("location_id")]
    public int? LocationId { get; set; }

    [Column("station_id")]
    public int? StationId { get; set; }
}
