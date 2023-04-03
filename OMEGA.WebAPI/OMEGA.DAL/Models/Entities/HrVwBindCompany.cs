using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class HrVwBindCompany
{
    [Column("LM_LOCATION_NAME")]
    [StringLength(240)]
    [Unicode(false)]
    public string? LmLocationName { get; set; }

    [Column("SM_STATION_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string SmStationCode { get; set; } = null!;

    [Column("SM_STATION_NAME")]
    [StringLength(240)]
    [Unicode(false)]
    public string? SmStationName { get; set; }

    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("LM_LOCATION_ID")]
    public int LmLocationId { get; set; }

    [Column("SM_DELETESTATUS")]
    public byte? SmDeletestatus { get; set; }

    [Column("SM_STATION_ID")]
    public int SmStationId { get; set; }
}
