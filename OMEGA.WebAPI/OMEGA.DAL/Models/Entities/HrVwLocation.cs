using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class HrVwLocation
{
    [Column("value")]
    public int Value { get; set; }

    [Column("LM_LOCATION_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string LmLocationCode { get; set; } = null!;

    [StringLength(240)]
    [Unicode(false)]
    public string? DispalyText { get; set; }

    [Column("LANGUAGE_CODE")]
    public short LanguageCode { get; set; }
}
