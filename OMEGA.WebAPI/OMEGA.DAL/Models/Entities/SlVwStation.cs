using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class SlVwStation
{
    [Column("SM_STATION_ID")]
    public int SmStationId { get; set; }

    [Column("SM_STATION_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string SmStationCode { get; set; } = null!;

    [Column("SM_STATION_NAME")]
    [StringLength(240)]
    [Unicode(false)]
    public string? SmStationName { get; set; }

    [Column("SM_MAIN_STATION")]
    public byte? SmMainStation { get; set; }

    [Column("SM_CREATEDBY")]
    public int? SmCreatedby { get; set; }

    [Column("SM_CREATEDDATE", TypeName = "datetime")]
    public DateTime? SmCreateddate { get; set; }

    [Column("SM_UPDATEDBY")]
    public int? SmUpdatedby { get; set; }

    [Column("SM_UPDATEDDATE", TypeName = "datetime")]
    public DateTime? SmUpdateddate { get; set; }

    [Column("SM_DELETESTATUS")]
    public byte? SmDeletestatus { get; set; }

    [Column("SM_ISPRODUCTABLE")]
    public byte? SmIsproductable { get; set; }

    [Column("LANGUAGE_CODE")]
    public short LanguageCode { get; set; }

    [Column("input_language")]
    public short InputLanguage { get; set; }

    [Column("short_display")]
    [StringLength(15)]
    [Unicode(false)]
    public string? ShortDisplay { get; set; }

    [Column("display_value")]
    [StringLength(240)]
    [Unicode(false)]
    public string? DisplayValue { get; set; }

    [Column("ISDEFAULT")]
    public byte? Isdefault { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string DefStation { get; set; } = null!;

    [Column("LM_LOCATION_NAME")]
    [StringLength(240)]
    [Unicode(false)]
    public string? LmLocationName { get; set; }

    [Column("LM_LOCATION_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string LmLocationCode { get; set; } = null!;

    [Column("LM_LOCATION_ID")]
    public int? LmLocationId { get; set; }
}
