using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class RptVwClientList
{
    [Column("CM_CUSTOMER_ID")]
    public long CmCustomerId { get; set; }

    [Column("CM_CUSTOMER_NAME")]
    [StringLength(100)]
    public string? CmCustomerName { get; set; }

    [Column("from_mail")]
    public string? FromMail { get; set; }

    [Column("CM_EMAIL")]
    [StringLength(500)]
    public string? CmEmail { get; set; }

    [Column("CM_STATE")]
    public int? CmState { get; set; }

    [Column("DM_DISTRICT_NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DmDistrictName { get; set; }

    [Column("CM_DELETESTATUS")]
    public byte? CmDeletestatus { get; set; }

    [Column("is_ngl_client")]
    public byte? IsNglClient { get; set; }
}
