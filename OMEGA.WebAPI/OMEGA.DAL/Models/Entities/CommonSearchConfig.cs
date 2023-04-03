using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("COMMON_SEARCH_CONFIG")]
public partial class CommonSearchConfig
{
    [Key]
    [Column("searchid")]
    public int Searchid { get; set; }

    [Column("searchtitle")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Searchtitle { get; set; }

    [Column("configfile")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Configfile { get; set; }

    [Column("viewname")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Viewname { get; set; }

    [Column("orderby")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Orderby { get; set; }

    [Column("linkfield")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Linkfield { get; set; }
}
