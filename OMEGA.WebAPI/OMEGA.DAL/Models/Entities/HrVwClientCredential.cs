using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class HrVwClientCredential
{
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

    public int? SiteType { get; set; }

    public long? SiteRefNo { get; set; }

    public string? SiteDesc { get; set; }

    public byte? SiteStatus { get; set; }

    public byte? IsParent { get; set; }

    public long? ParentId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ParentClientName { get; set; }
}
