using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("BTS_BG_Customer_Details")]
public partial class BtsBgCustomerDetail
{
    [Key]
    [Column("ID")]
    public long Id { get; set; }

    [Column("CustomerID")]
    public long? CustomerId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Website { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WebsiteUsername { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WebsitePassword { get; set; }

    [Unicode(false)]
    public string? Notes { get; set; }

    [Unicode(false)]
    public string? Log { get; set; }
}
