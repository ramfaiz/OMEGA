using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class SlTbVwMarketMaster
{
    [Column("DM_DISTRICT_ID")]
    public int DmDistrictId { get; set; }

    [Column("DM_DISTRICT_CODE")]
    [StringLength(15)]
    [Unicode(false)]
    public string DmDistrictCode { get; set; } = null!;

    [Column("display_value")]
    [StringLength(240)]
    [Unicode(false)]
    public string? DisplayValue { get; set; }

    [Column("short_display")]
    [StringLength(15)]
    [Unicode(false)]
    public string? ShortDisplay { get; set; }

    [Column("deleteflag")]
    public byte Deleteflag { get; set; }

    [Column("EM_EMIRATE_ID")]
    public int EmEmirateId { get; set; }

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

    [Column("country_id")]
    public int CountryId { get; set; }

    [Column("language_code")]
    public short LanguageCode { get; set; }
}
