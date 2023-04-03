using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class SiteMasterView
{
    public long SiteRefNo { get; set; }

    [StringLength(50)]
    public string? SiteRefCode { get; set; }

    [StringLength(500)]
    public string? DisplayValue { get; set; }

    public byte? SiteTypeId { get; set; }

    public byte? SessionStatus { get; set; }

    public byte? Status { get; set; }

    public long? DmDistrictId { get; set; }

    public long? BrowserId { get; set; }

    [StringLength(500)]
    public string? ShortDisplayValue { get; set; }

    public long? AmAreaId { get; set; }

    [StringLength(500)]
    public string? Url { get; set; }

    public byte? IsBrowserDependent { get; set; }

    public byte? IsSecurityQueReq { get; set; }

    public byte? IsSingleSession { get; set; }

    public byte? DeleteStatus { get; set; }

    public byte? LanguageCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SiteName { get; set; }

    [StringLength(240)]
    [Unicode(false)]
    public string? State { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Browser { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Session { get; set; }
}
