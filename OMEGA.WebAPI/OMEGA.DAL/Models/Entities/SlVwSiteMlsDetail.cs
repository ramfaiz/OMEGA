using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class SlVwSiteMlsDetail
{
    public long? CustomerId { get; set; }

    public int? SiteType { get; set; }

    [Column("site_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SiteName { get; set; }

    public string? SiteDesc { get; set; }

    [StringLength(500)]
    public string? UserName { get; set; }

    [StringLength(500)]
    public string? Password { get; set; }

    [StringLength(500)]
    public string? Question1 { get; set; }

    [StringLength(500)]
    public string? Answer1 { get; set; }

    [StringLength(500)]
    public string? Question2 { get; set; }

    [StringLength(500)]
    public string? Answer2 { get; set; }

    [StringLength(500)]
    public string? Question3 { get; set; }

    [StringLength(500)]
    public string? Answer3 { get; set; }

    public byte? SiteStatus { get; set; }

    [Column("DM_DISTRICT_NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DmDistrictName { get; set; }

    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("AM_AREA_NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string? AmAreaName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Status { get; set; }

    public long? DmDistrictId { get; set; }

    public long? AmAreaId { get; set; }

    public short? UserType { get; set; }

    [Column("no_of_user")]
    public long? NoOfUser { get; set; }

    [StringLength(500)]
    public string? DisplayValue { get; set; }

    public long SiteRefNo { get; set; }
}
