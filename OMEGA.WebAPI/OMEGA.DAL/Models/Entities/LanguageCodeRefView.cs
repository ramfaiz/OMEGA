using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class LanguageCodeRefView
{
    [Column("display_value")]
    [StringLength(240)]
    [Unicode(false)]
    public string? DisplayValue { get; set; }

    [Column("short_display")]
    [StringLength(15)]
    [Unicode(false)]
    public string? ShortDisplay { get; set; }

    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("input_language")]
    public short InputLanguage { get; set; }

    [Column("is_default")]
    public byte? IsDefault { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }
}
