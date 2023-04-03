using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class SlVwClientGroupMap1
{
    [Column("client_group_id")]
    public long ClientGroupId { get; set; }

    [Column("CM_CUSTOMER_ID")]
    public int CmCustomerId { get; set; }

    [Column("CM_CUSTOMER_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string CmCustomerCode { get; set; } = null!;

    [Column("CM_CUSTOMER_FULL_NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CmCustomerFullName { get; set; }

    [Column("parent_client_name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ParentClientName { get; set; }
}
