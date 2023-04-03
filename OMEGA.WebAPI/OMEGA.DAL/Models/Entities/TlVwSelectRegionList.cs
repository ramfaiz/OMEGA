using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class TlVwSelectRegionList
{
    [Column("EM_EMIRATE_ID")]
    public int EmEmirateId { get; set; }

    [Column("EM_EMIRATE_CODE")]
    [StringLength(15)]
    [Unicode(false)]
    public string EmEmirateCode { get; set; } = null!;

    [Column("country_code")]
    public int CountryCode { get; set; }

    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("display_value")]
    [StringLength(240)]
    [Unicode(false)]
    public string? DisplayValue { get; set; }

    [Column("deleteflag")]
    public byte Deleteflag { get; set; }
}
