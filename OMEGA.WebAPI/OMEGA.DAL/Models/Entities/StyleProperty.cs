using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("STYLE_PROPERTIES")]
public partial class StyleProperty
{
    [Key]
    public short StylePropertyId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PropertyName { get; set; }
}
