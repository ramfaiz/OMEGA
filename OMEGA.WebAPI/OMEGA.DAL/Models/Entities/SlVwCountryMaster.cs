using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class SlVwCountryMaster
{
    [Column("country_code")]
    [StringLength(50)]
    public string CountryCode { get; set; } = null!;

    [Column("display_value")]
    [StringLength(240)]
    [Unicode(false)]
    public string DisplayValue { get; set; } = null!;

    [Column("short_display")]
    [StringLength(15)]
    [Unicode(false)]
    public string? ShortDisplay { get; set; }

    [Column("is_default")]
    public byte IsDefault { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("country_id")]
    public int CountryId { get; set; }

    [Column("language_code")]
    public short LanguageCode { get; set; }
}
