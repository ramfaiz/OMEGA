using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class ClientCoverageView
{
    [Column("DM_DISTRICT_NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DmDistrictName { get; set; }

    public long? DmDistrictId { get; set; }

    public string? City { get; set; }

    public string? Zip { get; set; }

    public long? CustomerId { get; set; }

    [Column("CM_CUSTOMER_NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string CmCustomerName { get; set; } = null!;
}
