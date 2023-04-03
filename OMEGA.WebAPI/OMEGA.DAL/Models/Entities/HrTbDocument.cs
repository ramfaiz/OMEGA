using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("HR_TB_DOCUMENTS")]
public partial class HrTbDocument
{
    [Key]
    [Column("document_id")]
    public short DocumentId { get; set; }

    [Column("document_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string DocumentName { get; set; } = null!;
}
