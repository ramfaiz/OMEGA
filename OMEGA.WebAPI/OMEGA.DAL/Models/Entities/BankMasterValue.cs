using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[PrimaryKey("BankId", "LanguageCode")]
[Table("BANK_MASTER_VALUES")]
public partial class BankMasterValue
{
    [Key]
    [Column("bank_id")]
    public short BankId { get; set; }

    [Key]
    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("short_display")]
    [StringLength(15)]
    public string? ShortDisplay { get; set; }

    [Column("display_value")]
    [StringLength(240)]
    public string? DisplayValue { get; set; }

    [ForeignKey("BankId")]
    [InverseProperty("BankMasterValues")]
    public virtual BankMasterRef Bank { get; set; } = null!;
}
