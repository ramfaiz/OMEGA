using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class HrVwSelectInternalCompany
{
    [Column("sub_type_id")]
    public int SubTypeId { get; set; }

    [Column("SM_STATION_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string SmStationCode { get; set; } = null!;

    [Column("billing_sub_type")]
    [StringLength(240)]
    [Unicode(false)]
    public string? BillingSubType { get; set; }

    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("SM_DELETESTATUS")]
    public byte? SmDeletestatus { get; set; }

    [Column("COMP_IS_INTERNAL")]
    public byte? CompIsInternal { get; set; }
}
