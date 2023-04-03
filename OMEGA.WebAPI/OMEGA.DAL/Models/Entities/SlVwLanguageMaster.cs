using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class SlVwLanguageMaster
{
    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("display_value")]
    [StringLength(240)]
    [Unicode(false)]
    public string? DisplayValue { get; set; }

    [Column("is_default")]
    public byte? IsDefault { get; set; }

    [Column("short_display")]
    [StringLength(15)]
    [Unicode(false)]
    public string? ShortDisplay { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }
}
