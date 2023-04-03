using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class BtsVwClientVsPhotoghr
{
    [Column("client_id")]
    public long? ClientId { get; set; }

    [Column("photographer_id")]
    public long? PhotographerId { get; set; }

    [Column("full_name")]
    [StringLength(100)]
    public string? FullName { get; set; }

    [Column("ref_no")]
    public long RefNo { get; set; }

    [Column("user_type")]
    public byte? UserType { get; set; }

    [Column("dob", TypeName = "datetime")]
    public DateTime? Dob { get; set; }

    [Column("phtgrapher_id")]
    [StringLength(500)]
    public string? PhtgrapherId { get; set; }

    [Column("nationality_id")]
    public int? NationalityId { get; set; }

    [Column("state_id")]
    public int? StateId { get; set; }

    [Column("county_id")]
    public int? CountyId { get; set; }

    [Column("address1")]
    public string? Address1 { get; set; }

    [Column("address2")]
    public string? Address2 { get; set; }

    [Column("city")]
    [StringLength(500)]
    public string? City { get; set; }

    [Column("zipcode")]
    [StringLength(500)]
    public string? Zipcode { get; set; }

    [Column("email_id")]
    [StringLength(500)]
    public string? EmailId { get; set; }

    [Column("mobile_no")]
    [StringLength(500)]
    public string? MobileNo { get; set; }

    [Column("phone_no")]
    [StringLength(500)]
    public string? PhoneNo { get; set; }

    [Column("gender")]
    public byte? Gender { get; set; }

    [Column("b_address")]
    public string? BAddress { get; set; }

    [Column("b_licenseno")]
    [StringLength(500)]
    public string? BLicenseno { get; set; }

    [Column("b_state")]
    [StringLength(500)]
    public string? BState { get; set; }

    [Column("latitude")]
    public string? Latitude { get; set; }

    [Column("longitude")]
    public string? Longitude { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("title")]
    public byte? Title { get; set; }

    [Column("client_name")]
    [StringLength(100)]
    public string? ClientName { get; set; }
}
