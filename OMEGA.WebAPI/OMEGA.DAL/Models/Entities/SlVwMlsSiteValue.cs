using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class SlVwMlsSiteValue
{
    public long SiteRefNo { get; set; }

    [StringLength(50)]
    public string? SiteRefCode { get; set; }

    public long? DmDistrictId { get; set; }

    public long? AmAreaId { get; set; }

    public byte? SiteTypeId { get; set; }

    [StringLength(500)]
    public string? Url { get; set; }

    public byte? IsBrowserDependent { get; set; }

    public long? BrowserId { get; set; }

    public byte? IsSecurityQueReq { get; set; }

    public byte? IsSingleSession { get; set; }

    public byte? SessionStatus { get; set; }

    public byte? DeleteStatus { get; set; }

    public byte? Status { get; set; }

    [StringLength(500)]
    public string? DisplayValue { get; set; }

    [Column("BTS_site_ref_no")]
    public long? BtsSiteRefNo { get; set; }

    [StringLength(500)]
    public string? ShortDisplayValue { get; set; }

    public byte? LanguageCode { get; set; }
}
