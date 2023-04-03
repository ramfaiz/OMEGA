using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[PrimaryKey("EnumerationKey", "Value", "LanguageCode", "CategoryId")]
[Table("GENERIC_ENUMERATION_VALUES")]
public partial class GenericEnumerationValue
{
    [Key]
    [Column("enumeration_key")]
    [StringLength(160)]
    public string EnumerationKey { get; set; } = null!;

    [Key]
    [Column("value")]
    [StringLength(160)]
    public string Value { get; set; } = null!;

    [Key]
    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("short_display")]
    [StringLength(240)]
    public string? ShortDisplay { get; set; }

    [Column("display_value")]
    [StringLength(240)]
    public string DisplayValue { get; set; } = null!;

    public bool IsDefault { get; set; }

    [Key]
    [Column("category_id")]
    public short CategoryId { get; set; }
}
