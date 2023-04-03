using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class LanguageLocationView
{
    [Column("display_value")]
    [StringLength(240)]
    [Unicode(false)]
    public string? DisplayValue { get; set; }

    [Column("LANGUAGE_CODE")]
    public short LanguageCode { get; set; }

    [Column("ISDEFAULT")]
    public byte? Isdefault { get; set; }

    [Column("LM_DELETESTATUS")]
    public byte? LmDeletestatus { get; set; }

    [Column("LM_UPDATEDDATE", TypeName = "datetime")]
    public DateTime? LmUpdateddate { get; set; }

    [Column("LM_UPDATEDBY")]
    public int? LmUpdatedby { get; set; }

    [Column("LM_CREATEDDATE", TypeName = "datetime")]
    public DateTime? LmCreateddate { get; set; }

    [Column("LM_CREATEDBY")]
    public int? LmCreatedby { get; set; }

    [Column("LM_LOCATION_ID")]
    public int LmLocationId { get; set; }

    [Column("LM_LOCATION_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string LmLocationCode { get; set; } = null!;

    [Column("LM_LOCATION_NAME")]
    [StringLength(240)]
    [Unicode(false)]
    public string? LmLocationName { get; set; }
}
