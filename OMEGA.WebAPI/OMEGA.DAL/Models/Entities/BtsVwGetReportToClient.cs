using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class BtsVwGetReportToClient
{
    [Column("ref_no")]
    public long RefNo { get; set; }

    [Column("full_name")]
    [StringLength(100)]
    public string? FullName { get; set; }

    [Column("first_name")]
    [StringLength(100)]
    public string? FirstName { get; set; }

    [Column("last_name")]
    [StringLength(100)]
    public string? LastName { get; set; }

    [Column("agent_type")]
    public byte? AgentType { get; set; }

    [Column("cpd_report_to")]
    public long? CpdReportTo { get; set; }

    [Column("report_to")]
    public long? ReportTo { get; set; }

    [Column("report_to_name")]
    [StringLength(100)]
    public string? ReportToName { get; set; }

    [Column("user_type")]
    public byte? UserType { get; set; }

    [Column("title")]
    public byte? Title { get; set; }

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

    [Column("mail_option")]
    public byte? MailOption { get; set; }

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

    [Column("hierarchy_level")]
    public short? HierarchyLevel { get; set; }

    [Column("broker_name")]
    [StringLength(100)]
    public string? BrokerName { get; set; }

    [Column("broker_company_name")]
    [StringLength(100)]
    public string? BrokerCompanyName { get; set; }

    [Column("broker_license_no")]
    [StringLength(100)]
    public string? BrokerLicenseNo { get; set; }

    [Column("broker_license_expiry_dt", TypeName = "datetime")]
    public DateTime? BrokerLicenseExpiryDt { get; set; }

    [Column("broker_phone_no")]
    [StringLength(500)]
    public string? BrokerPhoneNo { get; set; }

    [Column("broker_state_id")]
    public int? BrokerStateId { get; set; }

    [Column("ref1_profession")]
    [StringLength(500)]
    public string? Ref1Profession { get; set; }

    [Column("ref1_profession_others")]
    [StringLength(500)]
    public string? Ref1ProfessionOthers { get; set; }

    [Column("ref1_contact_no")]
    [StringLength(500)]
    public string? Ref1ContactNo { get; set; }

    [Column("ref1_email_id")]
    [StringLength(500)]
    public string? Ref1EmailId { get; set; }

    [Column("ref2_profession")]
    [StringLength(500)]
    public string? Ref2Profession { get; set; }

    [Column("ref2_profession_others")]
    [StringLength(500)]
    public string? Ref2ProfessionOthers { get; set; }

    [Column("ref2_contact_no")]
    [StringLength(500)]
    public string? Ref2ContactNo { get; set; }

    [Column("ref2_email_id")]
    [StringLength(500)]
    public string? Ref2EmailId { get; set; }

    [Column("ref3_profession")]
    [StringLength(500)]
    public string? Ref3Profession { get; set; }

    [Column("ref3_profession_others")]
    [StringLength(500)]
    public string? Ref3ProfessionOthers { get; set; }

    [Column("ref3_contact_no")]
    [StringLength(500)]
    public string? Ref3ContactNo { get; set; }

    [Column("ref3_email_id")]
    [StringLength(500)]
    public string? Ref3EmailId { get; set; }

    [Column("broker_address")]
    public string? BrokerAddress { get; set; }

    [Column("re_license_no")]
    [StringLength(500)]
    public string? ReLicenseNo { get; set; }

    [Column("re_license_Expiry_date", TypeName = "datetime")]
    public DateTime? ReLicenseExpiryDate { get; set; }

    [Column("re_license_issued_date", TypeName = "datetime")]
    public DateTime? ReLicenseIssuedDate { get; set; }

    [Column("eo_policy_no")]
    [StringLength(500)]
    public string? EoPolicyNo { get; set; }

    [Column("eo_effective_date", TypeName = "datetime")]
    public DateTime? EoEffectiveDate { get; set; }

    [Column("eo_expiry_date", TypeName = "datetime")]
    public DateTime? EoExpiryDate { get; set; }

    [Column("eo_policy_limit_amt")]
    [StringLength(100)]
    public string? EoPolicyLimitAmt { get; set; }

    [Column("w9_company_name")]
    [StringLength(100)]
    public string? W9CompanyName { get; set; }

    [Column("w9_ein_tax_id")]
    [StringLength(500)]
    public string? W9EinTaxId { get; set; }

    [Column("ref1_name")]
    [StringLength(100)]
    public string? Ref1Name { get; set; }

    [Column("ref2_name")]
    [StringLength(100)]
    public string? Ref2Name { get; set; }

    [Column("ref3_name")]
    [StringLength(100)]
    public string? Ref3Name { get; set; }

    [Column("is_submitted")]
    public byte? IsSubmitted { get; set; }

    [Column("report_to_seq_no")]
    public long? ReportToSeqNo { get; set; }
}
