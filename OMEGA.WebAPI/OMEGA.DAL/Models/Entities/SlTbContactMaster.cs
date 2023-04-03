using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("SL_TB_CONTACT_MASTER")]
public partial class SlTbContactMaster
{
    [Key]
    [Column("CM_CONTACT_ID")]
    public int CmContactId { get; set; }

    [Column("CM_CONTACT_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string CmContactCode { get; set; } = null!;

    [Column("CM_CONTACT_NAME")]
    [StringLength(240)]
    [Unicode(false)]
    public string? CmContactName { get; set; }

    [Column("CM_PO_BOX")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CmPoBox { get; set; }

    [Column("CM_CUCLCO_CODE")]
    public int? CmCuclcoCode { get; set; }

    [Column("CM_DESIGNATION")]
    [StringLength(150)]
    [Unicode(false)]
    public string? CmDesignation { get; set; }

    [Column("CM_MOBILE_NO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CmMobileNo { get; set; }

    [Column("CM_TEL_NO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CmTelNo { get; set; }

    [Column("CM_FAX")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CmFax { get; set; }

    [Column("CM_ADDRESS")]
    [StringLength(240)]
    [Unicode(false)]
    public string? CmAddress { get; set; }

    [Column("CM_WEBSITE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CmWebsite { get; set; }

    [Column("CM_REMARKS")]
    [StringLength(250)]
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
    public byte CmDeletestatus { get; set; }

    [Column("CM_CONTACT_TYPE")]
    public byte? CmContactType { get; set; }

    [Column("CM_EMAIL")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CmEmail { get; set; }

    [Column("CM_ADDRESS2")]
    [StringLength(240)]
    [Unicode(false)]
    public string? CmAddress2 { get; set; }

    [Column("CM_ADDRESS3")]
    [StringLength(240)]
    [Unicode(false)]
    public string? CmAddress3 { get; set; }

    [Column("CM_CITY")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CmCity { get; set; }

    [Column("CM_STATE")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CmState { get; set; }

    [Column("CM_POB_AREA")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CmPobArea { get; set; }

    [Column("CM_MOBILE_NO2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CmMobileNo2 { get; set; }
}
