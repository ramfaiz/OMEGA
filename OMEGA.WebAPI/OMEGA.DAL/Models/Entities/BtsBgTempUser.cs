using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("BTS_BG_Temp_Users")]
public partial class BtsBgTempUser
{
    [Key]
    [Column("ID")]
    public long Id { get; set; }

    [Column("report_to")]
    public long? ReportTo { get; set; }

    [Column("email_id")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EmailId { get; set; }

    [Column("first_name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [Column("last_name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? LastName { get; set; }

    [Column("phone_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PhoneNo { get; set; }

    [Column("broker_address")]
    [StringLength(200)]
    [Unicode(false)]
    public string? BrokerAddress { get; set; }

    [Column("zipcode")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Zipcode { get; set; }

    [Column("user_type")]
    public byte? UserType { get; set; }

    [Column("full_name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FullName { get; set; }

    [Column("delete_status")]
    public bool? DeleteStatus { get; set; }

    [Column("mail_option")]
    public bool? MailOption { get; set; }

    [Column("created_by")]
    public long? CreatedBy { get; set; }

    [Column("created_date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("is_submitted")]
    public bool? IsSubmitted { get; set; }

    [Column("payment_type")]
    public int? PaymentType { get; set; }

    [Column("company_id")]
    public long? CompanyId { get; set; }

    [Column("city")]
    [StringLength(50)]
    [Unicode(false)]
    public string? City { get; set; }
}
