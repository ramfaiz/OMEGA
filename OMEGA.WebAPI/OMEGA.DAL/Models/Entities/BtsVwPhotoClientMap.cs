using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class BtsVwPhotoClientMap
{
    [Column("ref_no")]
    public long RefNo { get; set; }

    [Column("client_id")]
    public long? ClientId { get; set; }

    [Column("photographer_id")]
    public long? PhotographerId { get; set; }

    [Column("full_name")]
    [StringLength(100)]
    public string? FullName { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }
}
