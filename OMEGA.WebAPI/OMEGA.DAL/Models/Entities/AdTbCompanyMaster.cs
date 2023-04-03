using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("AD_TB_COMPANY_MASTER")]
public partial class AdTbCompanyMaster
{
    [Key]
    [Column("CM_COMPANY_ID")]
    public long CmCompanyId { get; set; }

    [Column("CM_COMPANY_CODE")]
    [StringLength(15)]
    [Unicode(false)]
    public string CmCompanyCode { get; set; } = null!;

    [Column("CM_COMPANY_NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CmCompanyName { get; set; }

    [Column("CM_COMPANY_FULL_NAME")]
    [StringLength(75)]
    [Unicode(false)]
    public string? CmCompanyFullName { get; set; }

    [Column("CM_POBOX")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CmPobox { get; set; }

    [Column("CM_ADDRESS")]
    [StringLength(75)]
    [Unicode(false)]
    public string? CmAddress { get; set; }

    [Column("CM_CITY")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CmCity { get; set; }

    [Column("CM_PHONE")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CmPhone { get; set; }

    [Column("CM_FAX")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CmFax { get; set; }

    [Column("CM_SPONSER_NAME")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CmSponserName { get; set; }

    [Column("CM_TRADE_LICENSE_NO")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CmTradeLicenseNo { get; set; }

    [Column("CM_LIC_ISSUE_DATE", TypeName = "datetime")]
    public DateTime? CmLicIssueDate { get; set; }

    [Column("CM_LIC_EXPIRY_DATE", TypeName = "datetime")]
    public DateTime? CmLicExpiryDate { get; set; }

    [Column("CM_EMAIL_ID")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CmEmailId { get; set; }

    [Column("CM_ACCOUNT_PERIOD")]
    public int? CmAccountPeriod { get; set; }

    [Column("CM_POSTING_METHOD")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CmPostingMethod { get; set; }

    [Column("CM_AUDITOR_NAME")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CmAuditorName { get; set; }

    [Column("CM_AUDITOR_ADDRESS")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CmAuditorAddress { get; set; }

    [Column("CM_REMARKS")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CmRemarks { get; set; }

    [Column("CM_CREATEDBY")]
    public int? CmCreatedby { get; set; }

    [Column("CM_CREATEDATE", TypeName = "datetime")]
    public DateTime? CmCreatedate { get; set; }

    [Column("CM_DELETESTATUS")]
    public byte? CmDeletestatus { get; set; }

    [Column("CM_FINYRFROM", TypeName = "datetime")]
    public DateTime? CmFinyrfrom { get; set; }

    [Column("CM_UPDATEDDATE", TypeName = "datetime")]
    public DateTime? CmUpdateddate { get; set; }

    [Column("CM_UPDATEDBY")]
    public int? CmUpdatedby { get; set; }

    [Column("CM_OWNING_COST_ID")]
    public int? CmOwningCostId { get; set; }

    [Column("CM_STATE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CmState { get; set; }

    [Column("language_code")]
    public byte LanguageCode { get; set; }

    [Column("currency_code")]
    public byte CurrencyCode { get; set; }

    [Column("installation_type")]
    public byte? InstallationType { get; set; }

    [Column("inactive_date", TypeName = "datetime")]
    public DateTime? InactiveDate { get; set; }
}
