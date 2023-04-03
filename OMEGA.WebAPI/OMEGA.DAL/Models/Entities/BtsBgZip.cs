using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("BTS_BG_Zips")]
public partial class BtsBgZip
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? State { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? County { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? City { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Zip { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? StateCode { get; set; }
}
