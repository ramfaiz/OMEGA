using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("BTS_TB_SUB_CLIENT_MASTER")]
public partial class BtsTbSubClientMaster
{
    [Key]
    [Column("ref_no")]
    public long RefNo { get; set; }

    [Column("client_ref_id")]
    public long? ClientRefId { get; set; }

    [Column("title")]
    public byte? Title { get; set; }

    [Column("full_name")]
    [StringLength(100)]
    public string? FullName { get; set; }

    [Column("dob", TypeName = "datetime")]
    public DateTime? Dob { get; set; }

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

    [Column("latitude")]
    public string? Latitude { get; set; }

    [Column("longitude")]
    public string? Longitude { get; set; }

    [Column("created_by")]
    public long? CreatedBy { get; set; }

    [Column("created_date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("updated_by")]
    public long? UpdatedBy { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("is_orgin")]
    public byte? IsOrgin { get; set; }
}
