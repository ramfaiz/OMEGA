using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class SlVwRegionMaster
{
    [Column("EM_EMIRATE_ID")]
    public int EmEmirateId { get; set; }

    [Column("EM_EMIRATE_CODE")]
    [StringLength(15)]
    [Unicode(false)]
    public string EmEmirateCode { get; set; } = null!;

    [Column("short_display")]
    [StringLength(15)]
    [Unicode(false)]
    public string? ShortDisplay { get; set; }

    [Column("display_value")]
    [StringLength(240)]
    [Unicode(false)]
    public string? DisplayValue { get; set; }

    [Column("deleteflag")]
    public byte Deleteflag { get; set; }

    [Column("country_code")]
    public int CountryCode { get; set; }

    [Column("Country_Name")]
    [StringLength(240)]
    [Unicode(false)]
    public string CountryName { get; set; } = null!;

    [Column("language_code")]
    public short LanguageCode { get; set; }
}
