using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_TB_CLIENT_ZIPCODE_COUNT")]
public partial class TfsTbClientZipcodeCount
{
    [Column("Client_Id")]
    public int? ClientId { get; set; }

    [Column("State_Id")]
    public int? StateId { get; set; }

    [Column("Portal_Id")]
    public int? PortalId { get; set; }

    [Column("Zip_Code")]
    public int? ZipCode { get; set; }

    public int? Counts { get; set; }

    [Column("Portal_name")]
    [StringLength(50)]
    public string? PortalName { get; set; }
}
