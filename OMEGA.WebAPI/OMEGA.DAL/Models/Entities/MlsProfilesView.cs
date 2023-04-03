using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class MlsProfilesView
{
    public int? SiteType { get; set; }

    public string? SiteDesc { get; set; }

    public short? UserType { get; set; }

    [StringLength(500)]
    public string? UserName { get; set; }

    [StringLength(500)]
    public string? Password { get; set; }

    [Column("CM_CUSTOMER_NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CmCustomerName { get; set; }

    public byte? SiteStatus { get; set; }

    [Column("county_name")]
    [StringLength(240)]
    [Unicode(false)]
    public string? CountyName { get; set; }

    [Column("no_of_user")]
    public long? NoOfUser { get; set; }

    [Column("state_name")]
    [StringLength(240)]
    [Unicode(false)]
    public string? StateName { get; set; }

    [StringLength(500)]
    public string? Url { get; set; }

    public byte? DeleteStatus { get; set; }
}
