using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("SL_TB_CLIENT_PAYMENT_TYPE")]
public partial class SlTbClientPaymentType
{
    [Column("payment_type")]
    public int? PaymentType { get; set; }

    [Column("payment_name")]
    [StringLength(15)]
    public string? PaymentName { get; set; }

    [Column("site_name")]
    public string? SiteName { get; set; }

    [Column("bank_name")]
    public string? BankName { get; set; }

    [Column("account_no")]
    public string? AccountNo { get; set; }

    [Column("company_id")]
    public int? CompanyId { get; set; }

    [Column("Business_name")]
    [StringLength(70)]
    public string? BusinessName { get; set; }

    [StringLength(70)]
    public string? Address { get; set; }

    [StringLength(55)]
    public string? City { get; set; }

    [StringLength(50)]
    public string? Country { get; set; }

    [StringLength(50)]
    public string? PostalCode { get; set; }

    [StringLength(60)]
    public string? Recipient { get; set; }

    [StringLength(50)]
    public string? SwiftCode { get; set; }
}
