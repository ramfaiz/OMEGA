using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("HR_TB_DOCUMENT_FIELDS")]
public partial class HrTbDocumentField
{
    [Key]
    [Column("field_id")]
    public int FieldId { get; set; }

    [Column("field_description")]
    [StringLength(200)]
    [Unicode(false)]
    public string? FieldDescription { get; set; }

    [Column("field_type")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FieldType { get; set; }
}
