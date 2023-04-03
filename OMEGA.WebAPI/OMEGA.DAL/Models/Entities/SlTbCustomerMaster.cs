using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("SL_TB_CUSTOMER_MASTER")]
public partial class SlTbCustomerMaster
{
    [Key]
    [Column("CM_CUSTOMER_ID")]
    public int CmCustomerId { get; set; }

    [Column("CM_CUSTOMER_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string CmCustomerCode { get; set; } = null!;

    [Column("CM_CUSTOMER_NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string CmCustomerName { get; set; } = null!;

    [Column("CM_CUSTOMER_FULL_NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CmCustomerFullName { get; set; }

    [Column("CM_ACCOUNT_GROUP")]
    public long? CmAccountGroup { get; set; }

    [Column("CM_CUSTOMER_STATUS")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CmCustomerStatus { get; set; }

    [Column("CM_PO_BOX")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CmPoBox { get; set; }

    [Column("CM_ADDRESS1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CmAddress1 { get; set; }

    [Column("CM_CITY")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CmCity { get; set; }

    [Column("CM_TEL_NO")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CmTelNo { get; set; }

    [Column("CM_FAX_NO")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CmFaxNo { get; set; }

    [Column("CM_EMAIL")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CmEmail { get; set; }

    [Column("CM_WEBSITE")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CmWebsite { get; set; }

    [Column("CM_BUSINESS_TYPE")]
    public byte? CmBusinessType { get; set; }

    [Column("CM_TRADE_LIC_NO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CmTradeLicNo { get; set; }

    [Column("CM_TRADE_LIC_EXP_DATE", TypeName = "datetime")]
    public DateTime? CmTradeLicExpDate { get; set; }

    [Column("CM_CREDIT_PERIOD")]
    public int? CmCreditPeriod { get; set; }

    [Column("CM_CREDIT_TERMS")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CmCreditTerms { get; set; }

    [Column("CM_CREDIT_LIMIT")]
    public double? CmCreditLimit { get; set; }

    [Column("CM_PRICING_CATEGORY")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CmPricingCategory { get; set; }

    [Column("CM_BANK1_NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CmBank1Name { get; set; }

    [Column("CM_BANK1_ACCNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CmBank1Accno { get; set; }

    [Column("CM_BANK2_NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CmBank2Name { get; set; }

    [Column("CM_BANK2_ACCNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CmBank2Accno { get; set; }

    [Column("CM_SPONSOR_NAME")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CmSponsorName { get; set; }

    [Column("CM_REMARKS")]
    [StringLength(150)]
    [Unicode(false)]
    public string? CmRemarks { get; set; }

    [Column("CM_CREATEDBY")]
    public int? CmCreatedby { get; set; }

    [Column("CM_CREATEDDATE", TypeName = "datetime")]
    public DateTime? CmCreateddate { get; set; }

    [Column("CM_UPDATEDBY")]
    public int? CmUpdatedby { get; set; }

    [Column("CM_UPDATEDDATE", TypeName = "datetime")]
    public DateTime? CmUpdateddate { get; set; }

    [Column("CM_DELETESTATUS")]
    public int CmDeletestatus { get; set; }

    [Column("CM_MAKE_ACCOUNT")]
    public long? CmMakeAccount { get; set; }

    [Column("gl_coam_account_code")]
    public long? GlCoamAccountCode { get; set; }

    [Column("CM_LC_NO")]
    [StringLength(100)]
    public string? CmLcNo { get; set; }

    [Column("CM_CREDIT_APP")]
    public byte? CmCreditApp { get; set; }

    [Column("CM_SEC_CHEQUES")]
    public int? CmSecCheques { get; set; }

    [Column("CM_CUSTOMER_SIZE")]
    public byte? CmCustomerSize { get; set; }

    [Column("CM_MANAGEMENT")]
    public byte? CmManagement { get; set; }

    [Column("CM_CUSTOMER_SPECS")]
    public byte? CmCustomerSpecs { get; set; }

    [Column("CM_ADDRESS2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CmAddress2 { get; set; }

    [Column("CM_ADRESS3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CmAdress3 { get; set; }

    [Column("CM_LGA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CmLga { get; set; }

    [Column("CM_STATE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CmState { get; set; }

    [Column("CM_POAREA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CmPoarea { get; set; }

    [Column("CM_COMP_REP")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CmCompRep { get; set; }

    [Column("CM_BRANCH1")]
    [StringLength(500)]
    [Unicode(false)]
    public string? CmBranch1 { get; set; }

    [Column("CM_BRANCH2")]
    [StringLength(500)]
    [Unicode(false)]
    public string? CmBranch2 { get; set; }

    [Column("franchise_code")]
    public short? FranchiseCode { get; set; }

    [Column("currency_code")]
    public short? CurrencyCode { get; set; }

    [Column("language_code")]
    public short? LanguageCode { get; set; }

    [Column("exrate_class")]
    public short? ExrateClass { get; set; }

    [Column("country_code")]
    public long? CountryCode { get; set; }

    [Column("company_type_code")]
    public short? CompanyTypeCode { get; set; }

    [Column("active_date", TypeName = "datetime")]
    public DateTime? ActiveDate { get; set; }

    [Column("bill_period")]
    [StringLength(3)]
    [Unicode(false)]
    public string? BillPeriod { get; set; }

    [Column("next_bill_date", TypeName = "datetime")]
    public DateTime? NextBillDate { get; set; }

    [Column("cm_district_id")]
    public int? CmDistrictId { get; set; }

    [Column("org_ref_no")]
    public long? OrgRefNo { get; set; }

    [Column("comp_ref_no")]
    public long? CompRefNo { get; set; }

    public byte? IsParent { get; set; }

    public long? ParentId { get; set; }

    [Column("client_group_id")]
    public long? ClientGroupId { get; set; }

    [Column("bts_client_id")]
    public int? BtsClientId { get; set; }

    [Column("is_ngl_client")]
    public byte? IsNglClient { get; set; }

    [Column("bts_sub_client_id")]
    public int? BtsSubClientId { get; set; }
}
