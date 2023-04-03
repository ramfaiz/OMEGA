using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class BtsVwClientPhtList
{
    [Column("user_id")]
    public long UserId { get; set; }

    [Column("user_type")]
    public byte? UserType { get; set; }

    [Column("full_name")]
    [StringLength(100)]
    public string? FullName { get; set; }

    [Column("username")]
    [StringLength(500)]
    public string? Username { get; set; }

    [Column("state_id")]
    public int? StateId { get; set; }

    [Column("county_id")]
    public int? CountyId { get; set; }

    [Column("state_name")]
    [StringLength(500)]
    public string StateName { get; set; } = null!;

    [Column("county_name")]
    [StringLength(500)]
    public string CountyName { get; set; } = null!;

    [Column("city_name")]
    public string CityName { get; set; } = null!;

    [Column("address1")]
    public string Address1 { get; set; } = null!;

    [Column("address2")]
    public string Address2 { get; set; } = null!;

    [Column("email_id")]
    [StringLength(500)]
    public string EmailId { get; set; } = null!;

    [Column("mobile_no")]
    [StringLength(500)]
    public string MobileNo { get; set; } = null!;

    [Column("phone_no")]
    [StringLength(500)]
    public string PhoneNo { get; set; } = null!;

    [Column("gender")]
    public byte? Gender { get; set; }

    [Column("b_address")]
    public string BAddress { get; set; } = null!;

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("city")]
    [StringLength(500)]
    public string? City { get; set; }

    [Column("title")]
    public byte? Title { get; set; }

    [Column("ref_no")]
    public long RefNo { get; set; }

    [Column("zipcode")]
    [StringLength(500)]
    public string? Zipcode { get; set; }

    [Column("password")]
    [StringLength(500)]
    public string? Password { get; set; }

    [Column("report_to")]
    public long? ReportTo { get; set; }

    [Column("hierarchy_level")]
    public short? HierarchyLevel { get; set; }
}
