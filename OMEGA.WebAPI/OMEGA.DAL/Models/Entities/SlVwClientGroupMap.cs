using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class SlVwClientGroupMap
{
    [Column("client_group_id")]
    public long ClientGroupId { get; set; }

    [Column("CM_CUSTOMER_ID")]
    public long CmCustomerId { get; set; }

    [Column("CM_CUSTOMER_FULL_NAME")]
    [StringLength(100)]
    public string? CmCustomerFullName { get; set; }

    [Column("parent_client_name")]
    [StringLength(100)]
    public string? ParentClientName { get; set; }
}
