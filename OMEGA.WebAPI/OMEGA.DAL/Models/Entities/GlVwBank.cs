using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class GlVwBank
{
    [Column("bank_id")]
    public short BankId { get; set; }

    [Column("bank_code")]
    [StringLength(15)]
    [Unicode(false)]
    public string BankCode { get; set; } = null!;

    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("display_value")]
    [StringLength(240)]
    public string? DisplayValue { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }
}
