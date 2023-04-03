using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("BTS_TB_CLIENT_PHOTOGHR_MAP")]
public partial class BtsTbClientPhotoghrMap
{
    [Key]
    [Column("ref_no")]
    public long RefNo { get; set; }

    [Column("client_id")]
    public long? ClientId { get; set; }

    [Column("photographer_id")]
    public long? PhotographerId { get; set; }

    [Column("latitude")]
    public string? Latitude { get; set; }

    [Column("longitude")]
    public string? Longitude { get; set; }

    [Column("is_default")]
    public short? IsDefault { get; set; }
}
