using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class RptVwClientDetail
{
    [Column("CM_CUSTOMER_NAME")]
    [StringLength(100)]
    public string? CmCustomerName { get; set; }

    [Column("CM_ADDRESS1")]
    public string? CmAddress1 { get; set; }

    [Column("address2")]
    [StringLength(1223)]
    public string Address2 { get; set; } = null!;

    [Column("language_code")]
    public short LanguageCode { get; set; }
}
