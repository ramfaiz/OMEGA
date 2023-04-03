using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class VwDefDept
{
    [Column("dept_id")]
    public short DeptId { get; set; }

    [Column("display_value")]
    [StringLength(240)]
    public string? DisplayValue { get; set; }

    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("is_default")]
    public byte? IsDefault { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("dept_code")]
    [StringLength(15)]
    [Unicode(false)]
    public string DeptCode { get; set; } = null!;
}
