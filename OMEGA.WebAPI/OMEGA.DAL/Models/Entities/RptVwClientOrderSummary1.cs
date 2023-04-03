using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class RptVwClientOrderSummary1
{
    public int? TotalOrder { get; set; }

    [Column("order_date", TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }

    public int TotalAss { get; set; }

    public int TotalUnAss { get; set; }

    public int FreshOrder { get; set; }

    [Column("master_account_no")]
    public long? MasterAccountNo { get; set; }

    [Column("CM_CUSTOMER_NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string CmCustomerName { get; set; } = null!;

    [Column("CM_CUSTOMER_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string CmCustomerCode { get; set; } = null!;

    [Column("language_code")]
    public short? LanguageCode { get; set; }
}
