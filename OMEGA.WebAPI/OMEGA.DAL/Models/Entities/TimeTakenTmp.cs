using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TimeTakenTmp")]
public partial class TimeTakenTmp
{
    [Column("time_taken")]
    public long? TimeTaken { get; set; }
}
