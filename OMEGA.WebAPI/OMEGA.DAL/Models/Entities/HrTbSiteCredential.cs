using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("HR_TB_SITE_CREDENTIALS")]
public partial class HrTbSiteCredential
{
    public long? CustomerId { get; set; }

    public int? SiteType { get; set; }

    public long? SiteRefNo { get; set; }

    public string? SiteDesc { get; set; }

    public short? UserType { get; set; }

    public long? DmDistrictId { get; set; }

    public long? AmAreaId { get; set; }

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

    [Column("no_of_user")]
    public long? NoOfUser { get; set; }
}
