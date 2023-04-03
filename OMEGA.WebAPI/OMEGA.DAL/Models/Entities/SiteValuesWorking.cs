using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("SITE_VALUES_working")]
public partial class SiteValuesWorking
{
    public long SiteRefNo { get; set; }

    [StringLength(500)]
    public string? ShortDisplayValue { get; set; }

    [StringLength(500)]
    public string? DisplayValue { get; set; }

    public byte? LanguageCode { get; set; }

    [Column("BTS_site_ref_no")]
    public long? BtsSiteRefNo { get; set; }
}
