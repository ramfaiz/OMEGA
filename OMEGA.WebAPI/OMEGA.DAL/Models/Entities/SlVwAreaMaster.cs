using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class SlVwAreaMaster
{
    [Column("AM_AREA_ID")]
    public int AmAreaId { get; set; }

    [Column("AM_AREA_CODE")]
    [StringLength(15)]
    [Unicode(false)]
    public string AmAreaCode { get; set; } = null!;

    [Column("short_display")]
    [StringLength(15)]
    [Unicode(false)]
    public string? ShortDisplay { get; set; }

    [Column("AM_AREA_NAME")]
    [StringLength(240)]
    [Unicode(false)]
    public string? AmAreaName { get; set; }

    [Column("DM_DISTRICT_ID")]
    public int? DmDistrictId { get; set; }

    [Column("EM_EMIRATE_ID")]
    public int? EmEmirateId { get; set; }

    [Column("country_code")]
    public int? CountryCode { get; set; }

    [Column("deleteflag")]
    public byte Deleteflag { get; set; }

    [Column("EM_EMIRATE_NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string EmEmirateName { get; set; } = null!;

    [Column("DM_DISTRICT_NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string DmDistrictName { get; set; } = null!;

    [Column("Country_Name")]
    [StringLength(240)]
    [Unicode(false)]
    public string CountryName { get; set; } = null!;

    [Column("language_code")]
    public short LanguageCode { get; set; }
}
